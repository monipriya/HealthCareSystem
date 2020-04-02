using OnlineHealthcareManagement.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OnlineHealthcareManagementSystem.DAL
{
   public class DoctorRepository
    {
        public static IEnumerable<DoctorDetails> DoctorData()
        {
            using (DBContext context = new DBContext())
            {
                return context.DoctorDB.ToList();
            }
        }
        public static void AddDoctors(DoctorDetails doctor)
        {
            DBContext context = new DBContext();
            context.DoctorDB.Add(doctor);
            context.SaveChanges();
        }
        public static DoctorDetails GetDoctorId(string Id)
        {
            using(DBContext context = new DBContext())
            {
                return context.DoctorDB.ToList().Where(id => id.DoctorId == Id).SingleOrDefault();
            }
        }
        public static void Delete(string userId)
        {
            using(DBContext context = new DBContext())
            {
                DoctorDetails doctor = GetDoctorId(userId);
                context.DoctorDB.Attach(doctor);
                context.DoctorDB.Remove(doctor);
                context.SaveChanges();
            }
        }
        public static void UpdateDoctorDetails(DoctorDetails doctor)
        {
            using (DBContext context = new DBContext())
            {
                context.Entry(doctor).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static bool VerifyDoctorDetails(string doctorId)
        {
            bool isExist = false;
            using(DBContext context = new DBContext())
            {
                isExist= context.DoctorDB.Where(e=>e.MailId==doctorId)==null;
            }
            return isExist;
        }
    }
    
}
