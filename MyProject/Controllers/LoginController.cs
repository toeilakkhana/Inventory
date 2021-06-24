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
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private IUnitOfWork _uow;
        public LoginController(ILogger<LoginController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetUser([FromBody] User obj)
        {
            var lEmpData = _uow.UserRepository.GetSingleByCondition(w => w.User_Email == obj.User_Email && w.User_Pass == obj.User_Pass);
            return Json(lEmpData);
        }

    }
}
