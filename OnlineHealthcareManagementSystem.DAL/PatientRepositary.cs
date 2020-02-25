 //using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
//using OnlineHealthcareManagement.Entity;
//namespace OnlineHealthcareManagementSystem.DAL
//{
   
//        public static class PatientRepository
//        {
//            static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
//            static SqlConnection connection = null;
//            public static DataTable ViewPackage()
//            {
//                string procedure = "sp_View_PatientDetails";
//                DataTable table;
//                using (connection = new SqlConnection(connectionString))
//                {
//                    SqlCommand command = new SqlCommand(procedure, connection);
//                    command.CommandType = CommandType.StoredProcedure;
//                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
//                    connection.Open();
//                    table = new DataTable();
//                    dataAdapter.Fill(table);
//                }
//                return table;
//            }
//            public static void DeletePatient(int userId)
//            {
//                string procedure = "sp_Delete_PatientDetails";
//                using (SqlCommand command = new SqlCommand(procedure, connection))
//                {
//                    command.CommandType = CommandType.StoredProcedure;
//                    command.Parameters.AddWithValue("@USERID", userId);
//                    connection.Open();
//                    command.ExecuteNonQuery();
//                }
//            }
//            public static void UpdatePatient(string mailId, string mobileNumber, string name, string userId)
//            {
//                string procedure = "sp_Patient_Update";
//                using (SqlCommand command = new SqlCommand(procedure, connection))
//                {
//                    command.CommandType = CommandType.StoredProcedure;
//                    command.Parameters.AddWithValue("@name", name);
//                    command.Parameters.AddWithValue("@mailid", mailId);
//                    command.Parameters.AddWithValue("@mobileNumber", mobileNumber);
//                    command.Parameters.AddWithValue("@USERID", userId);
//                    connection.Open();
//                    command.ExecuteNonQuery();
//                    connection.Close();
//                }
//            }
//            public static void InsertPatient(Account patient)
//            {
//                string procedure = "usp_Patient_Add";
//                using (SqlCommand command = new SqlCommand(procedure, connection))
//                {
//                    command.CommandType = CommandType.StoredProcedure;
//                    command.Parameters.AddWithValue("@name", patient.Name);
//                    command.Parameters.AddWithValue("@sex", patient.Sex);
//                    command.Parameters.AddWithValue("@dob", patient.Dob);
//                    command.Parameters.AddWithValue("@bloodGroup", patient.BloodGroup);
//                    command.Parameters.AddWithValue("@mobileNumber", patient.MobileNumber);
//                    command.Parameters.AddWithValue("@mailId", patient.MailId);
//                    command.Parameters.AddWithValue("@city", patient.City);
//                    command.Parameters.AddWithValue("@password", patient.Password);
//                    command.Parameters.AddWithValue("@confirmPassword", patient.ConfirmPassword);
//                    connection.Open();
//                    command.ExecuteNonQuery();
//                }
//            }



//        }
//    }
