//using System.Data;
//using OnlineHealthcareManagementSystem.DAL;
//using OnlineHealthcareManagement.Entity;
//namespace OnlineHealthcareManagement.BL
//{
//    public static class PatientUpdate
//    {
//            public static DataTable ShowPatientDetails()
//            {
//                return PatientRepository.ViewPackage();
//            }
//            public static void DeletePatientDetails(int id)
//            {
//                PatientRepository.DeletePatient(id);
//            }
//            public static void UpdatePatientDetails(string mailid, string number, string name, string id)
//            {
//                PatientRepository.UpdatePatient(mailid, number, name, id);
//            }
//            public static void InsertPatientDetails(Account patient)
//            {
//                PatientRepository.InsertPatient(patient);
//            }
//        }
//    }