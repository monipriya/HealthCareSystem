using OnlineHealthcareManagement.BL;
using OnlineHealthcareManagement.Entity;
using OnlineHealthcareManagementMVC.Models;
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
        
        public ActionResult SignUp(UserDetails user)
        {
            if (ModelState.IsValid)
            {
                Account account = new Account();
                account.BloodGroup = user.BloodGroup;
                account.Name = user.Name;
                account.Sex = user.Sex;
                account.MailId = user.MailId;
                account.Dob = user.Dob;
                account.MobileNumber = user.MobileNumber;
                account.Password = user.Password;
                account.City = user.City;
                UserBL.AddCustomer(account);
                Response.Write("Register Successfull");
                return RedirectToAction("SignIn");
            }
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Account account)
        {
            if (ModelState.IsValid)
            {
                SigInModel signIn = new SigInModel();
                account.Name = signIn.UserName;
                account.Password = signIn.Password;
                Response.Write("Login succesful");
            }
            return View();
        }
    }
}