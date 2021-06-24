using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Data.UnitOfWork;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUnitOfWork _uow;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        [HttpPost]
        public JsonResult GetType()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Type");
            return Json(empData);
        }

        [HttpPost]
        public JsonResult GetStatus()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "Status");
            return Json(empData);
        }

        [HttpPost]
        public JsonResult GetProjectMng()
        {
            var empData = _uow.ConfigRepository.GetAll().Where(w => w.Conf_System == "Project" && w.Conf_Type == "ProjectManager");
            return Json(empData);
        }

        [HttpPost]
        public JsonResult Concat()
        {
            var empData = "AA";
            string first = "BA";

            string all = empData + ", " + first; // AA, BA
            return Json(empData);
        }

        [HttpPost]
        public JsonResult GetName([FromBody] string customerId)
        {
            string en = customerId.ToUpper();
            var empAll = _uow.CustomerRepository.GetSingleByCondition(w => w.Customer_Id == en);
            if (empAll != null)
            {
                return Json(empAll);
            }
            else
            {
                return Json(false);
            }
        }

        public JsonResult SaveProject([FromBody] CollectProject obj)
        {
            if (obj != null)
            {
                var rs = new CollectProject()
                {

                    ProjectName = obj.ProjectName,
                    BusinessAnalyst = obj.BusinessAnalyst,
                    JobCode = obj.JobCode,
                    JobCodeName = obj.JobCodeName,
                    NumSR = obj.NumSR,
                    NumPOT = obj.NumPOT,
                    Revenue = obj.Revenue,
                    BusinessUnit = obj.BusinessUnit

                };
                _uow.CollectProjectRepository.Insert(rs);
                _uow.Commit();
                return Json(true);
            }
            else
            {
                return Json(false);
            }

        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Support()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();
        }

        public IActionResult SearchProject()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
