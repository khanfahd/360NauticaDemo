using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Auth.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace AspNetCore.Auth.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("userinformation")]
        [Authorize]
        public IActionResult UserInformation()
        {
            return View();
        }

        [Route("agelimited")]
        [Authorize(Policy = "AgeLimit")]
        public IActionResult AgeLimited()
        {
            return View();
        }

        [Route("borderaccess")]
        [Authorize(Policy = "BorderAccess")]
        public IActionResult BorderAccess()
        {
            return View();
        }

        [Route("adminaccess")]
        [Authorize(Roles = "Admin, HR")]
        public IActionResult AdminAccess()
        {
            return View();
        }
    }
}
