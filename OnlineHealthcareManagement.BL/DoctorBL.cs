using OnlineHealthcareManagement.Entity;
using System.Collections.Generic;
using OnlineHealthcareManagementSystem.DAL;

namespace OnlineHealthcareManagement.BL
{
    public class DoctorBL
    {
        public static void AddDoctor(DoctorDetails doctor)
        {
            DoctorRepository.AddDoctors(doctor);
        }
        public static IEnumerable<DoctorDetails> DoctorData()
        {
            return DoctorRepository.DoctorData();
        }
        public static bool CheckIsExist(string mailId)
        {
            return true;
        }
        public static void DeleteDoctorData(string userId)
        {
            DoctorRepository.Delete(userId);
        }
        public static void UpdateDoctor(DoctorDetails doctor)
        {
            DoctorRepository.UpdateDoctorDetails(doctor);
        }
        public static DoctorDetails GetDoctorId(string Id)
        {
           return DoctorRepository.GetDoctorId(Id);
        }
    }
}
