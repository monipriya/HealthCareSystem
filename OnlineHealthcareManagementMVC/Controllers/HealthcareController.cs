using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineHealthcareManagementMVC.Controllers
{
    public class HealthcareController : Controller
    {
        // GET: Healthcare
        public ActionResult Index()
        {
            return View();
        }
    }
}