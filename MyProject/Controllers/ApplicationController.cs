using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyProject.Data.Context;
using MyProject.Data.UnitOfWork;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ILogger<ApplicationController> _logger;
        private IUnitOfWork _uow;
        public ApplicationController(ILogger<ApplicationController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public JsonResult GetEmployee([FromBody] string emp_ID)
        {
            string en = emp_ID.ToUpper();
            var empAll = _uow.EmployeeRepository.GetSingleByCondition(w => w.Emp_ID == en);
            if (empAll != null)
            {
                return Json(empAll);
            }
            else
            {
                return Json(false);
            }


        }
        [HttpPost]
        public JsonResult GetFocial([FromBody] string emp_ID)
        {
            string en = emp_ID.ToUpper();
            var empAll = _uow.EmployeeRepository.GetSingleByCondition(w => w.Emp_ID == en);
            if (empAll != null)
            {
                return Json(empAll);
            }
            else
            {
                return Json(false);
            }


        }



        [HttpPost]
        public JsonResult GetCustomer([FromBody] string customer_Department)
        {
            string en = customer_Department.ToUpper();
            var empAll = _uow.CustomerRepository.GetMulti(w => w.Customer_Department == en);
            if (empAll != null)
            {
                return Json(empAll);
            }
            else
            {
                return Json(false);
            }


        }

        [HttpPost]
        public JsonResult GetAppOwner([FromBody] string id)
        {

            var distData = _uow.CustomerRepository.GetAll().Where(w => w.Customer_Id == id).ToList();
            return Json(distData);
        }



        [HttpPost]
        public JsonResult GetServerType()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Server_Type");
            return Json(empData);
        }
        [HttpPost]
        public JsonResult GetSmtp()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Smtp");
            return Json(empData);
        }
        [HttpPost]
        public JsonResult GetAppstaName()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Appsta_Name");
            return Json(empData);
        }
        [HttpPost]
        public JsonResult GetOsSystem()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Os_Sys");
            return Json(empData);
        }

        [HttpPost]
        public JsonResult GetAppStatus()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "App_Status");
            return Json(empData);
        }
        [HttpPost]
        public JsonResult GetSoftwareVer()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Software_Ver");
            return Json(empData);
        }

        [HttpPost]
        public JsonResult GetDepartment()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Department");
            return Json(empData);
        }


        public JsonResult SaveSupport([FromBody] Application obj)
        {
            if (obj != null)
            {
                var rs = new Application()
                {

                    AppId = obj.AppId,
                    AppName = obj.AppName,
                    AppObj = obj.AppObj,
                    AppUrl = obj.AppUrl,
                    Company = obj.Company,
                    DocPath = obj.DocPath,
                    FucDes = obj.FucDes,
                    Remark = obj.Remark,
                    Source_Path = obj.Source_Path,
                    Port = obj.Port,
                    OcioName = obj.OcioName,
                    ProjectManager = obj.ProjectManager,
                    DatabaseName = obj.DatabaseName,
                    Bu = obj.Bu,
                    AppStatusName = obj.AppStatusName,
                    AppStatus = obj.AppStatus,
                    Department = obj.Department,
                    OsSystem = obj.OsSystem,
                    Smtp = obj.Smtp,
                    ServerType = obj.ServerType,
                    SoftwareVer = obj.SoftwareVer,
                    Criticality = obj.Criticality
                };
                _uow.ApplicationRepository.Insert(rs);
                _uow.Commit();
                return Json(true);
            }
            else
            {
                return Json(false);
            }

        }

    }
}


