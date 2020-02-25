using OnlineHealthcareManagement.BL;
using OnlineHealthcareManagement.Entity;
using System.Web.Mvc;

namespace OnlineHealthcareManagementMVC.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult Index() 
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Account account)
        {
            
            if (ModelState.IsValid)
            {
                //UserBL.GetUsers();
                UserBL.AddCustomer(account);
                Response.Write("Register Successfull"); 
                return RedirectToAction("SignIn");
            }
            return View();
        }
        public ActionResult SignIn(Account account)
        {
            if (ModelState.IsValid)
            {
                Response.Write("Login succesful");
            }
            return View();
        }
     }
}