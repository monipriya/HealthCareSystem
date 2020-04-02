using AutoMapper;
using OnlineHealthcareManagement.BL;
using OnlineHealthcareManagement.Entity;
using OnlineHealthcareManagementMVC.Models;
using System;
using System.Web.Mvc;
namespace OnlineHealthcareManagementMVC.Controllers
{
    [HandleError]
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

        public ActionResult SignUp(SignUp user)
        {
            if (ModelState.IsValid)
            {
                var Register = Mapper.Map<SignUp, Account>(user);
                UserBL.AddCustomer(Register);
                return RedirectToAction("SignIn");
            }
            
            //if (ModelState.IsValid)
            //{
            //    Account account = new Account();
            //    account.BloodGroup = user.BloodGroup;
            //    account.Name = user.Name;
            //    account.Sex = user.Sex;
            //    account.MailId = user.MailId;
            //    account.Dob = user.Dob;
            //    account.MobileNumber = user.MobileNumber;
            //    account.Password = user.Password;
            //    account.City = user.City;
            //    account.Role = user.Role;
            //    UserBL.AddCustomer(account);
            //    return RedirectToAction("SignIn");
            //}
            //TempData["message"] = "Register Successful";
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SigInModel signIn)
        {
            Account account = new Account()
            {
                MailId = signIn.UserName,
                Password = signIn.Password,
            };
            account = UserBL.Login(account);
            
            try
            {
                if (account.Role  == "Admin")
                {
                    return RedirectToAction("DisplayDoctorDetails", "Admin");
                }
                else 
                {
                    return RedirectToAction("Index", "Patient");
                }
            }
            catch (Exception)
            {
                Response.Write("Enter the correct username and password");
            }
            return View();
        }
    }
}