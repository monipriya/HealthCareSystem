using System.Web.Mvc;
using OnlineHealthcareManagementMVC.Models;
using OnlineHealthcareManagement.Entity;
using OnlineHealthcareManagement.BL;
using AutoMapper;
using System.Collections.Generic;
namespace OnlineHealthcareManagementMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AddDoctorDetails()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDoctorDetails(DoctorModel doctor)
        {
            
            if (ModelState.IsValid)
            {
                var Add = Mapper.Map<DoctorModel, DoctorDetails>(doctor);
                //if (DoctorBL.CheckIsExist(Mapper.Map(M))
                    DoctorBL.AddDoctor(Add);
            }
            return View();
        }
        public ViewResult DisplayDetails()
        {
            IEnumerable<DoctorDetails> doctor = DoctorBL.DoctorData();
            TempData["Doctor Details"] = doctor;
            return View(doctor);
        }
       public ActionResult DeleteDoctorData(string id)
        {
            DoctorBL.DeleteDoctorData(id);
            return RedirectToAction("DisplayDetails");
        }
        [HttpGet]
        public ActionResult Edit(string id)
        { 
                DoctorDetails doctor = DoctorBL.GetDoctorId(id);
                DoctorModel doctorModel = AutoMapper.Mapper.Map<DoctorDetails, DoctorModel>(doctor);
                return View(doctorModel);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Name,Specialist,MobileNumber,AvailableFromTime,AvailableToTime,MailId,Password")]DoctorModel doctorDetails)
        {
                DoctorDetails doctor= AutoMapper.Mapper.Map<DoctorModel,DoctorDetails>(doctorDetails);
                DoctorBL.UpdateDoctor(doctor);
                return RedirectToAction("DisplayDetails");
        }
        //public ActionResult UpdateDoctorData([Bind(Include ="Name,Specialist,MobileNumber,AvailableFromTime,AvailableToTime")]DoctorModel doctorDetails)
        //{
        //    DoctorDetails doctor = DoctorBL.GetDoctorId(doctorDetails.MailId);
        //    doctor.Name = doctorDetails.Name;
        //    doctor.Specialist = doctorDetails.Specialist;
        //    doctor.MobileNumber = doctorDetails.MobileNumber;
        //    doctor.AvailableFromTime = doctorDetails.AvailableFromTime;
        //    doctor.AvailableToTime = doctorDetails.AvailableToTime;
        //    DoctorBL.UpdateDoctor(doctor);
        //    TempData["Message"] = "Doctor Details Updated";
        //    return RedirectToAction("DisplayDetails");
        //}
        public ActionResult Homepage()
        { 
            return View();
        }
    }
}