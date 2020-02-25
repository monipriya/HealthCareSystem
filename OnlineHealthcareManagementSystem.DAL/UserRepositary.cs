using System;
using System.Linq;
using System.Collections.Generic;
using OnlineHealthcareManagement.Entity;

namespace OnlineHealthcareManagementSystem.DAL
{
    public class UserRepositary
    {
        public static IEnumerable<Account> GetUsers()
        {
            DBContext context = new DBContext();
            return context.UserDB.ToList();
        }
        public static void AddCustomer(Account account)
        {
            DBContext context = new DBContext();
            context.UserDB.Add(account);
            context.SaveChanges();
        }
    //    }
    //    static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
    //    public static int AddPatient(Account patient)
    //    {
    //        SqlConnection connection = new SqlConnection(connectionString);
    //        string query = "SP_Patient_ADD";
    //        int rows;

    //        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
    //        {

    //            sqlCommand.CommandType = CommandType.StoredProcedure;
    //            SqlParameter param = new SqlParameter();
    //            param = new SqlParameter();
    //            param.ParameterName = "@name";
    //            param.Value = patient.Name;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@sex";
    //            param.Value = patient.Sex;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@DOB";
    //            param.Value = patient.Dob;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@bloodGroup";
    //            param.Value = patient.BloodGroup;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@mobileNumber";
    //            param.Value = patient.MobileNumber;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@city";
    //            param.Value = patient.City;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@mailId";
    //            param.Value = patient.MailId;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@password";
    //            param.Value = patient.Password;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@confirmPassword";
    //            param.Value = patient.ConfirmPassword;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            sqlCommand.Parameters.Add(param);
    //            connection.Open();
    //            rows = sqlCommand.ExecuteNonQuery();
    //        }
    //        return rows;
    //    }
    //    public static bool ValidateLogin(string username, string password)
    //    {
    //        bool isValue = false;
    //        SqlConnection connection = new SqlConnection(connectionString);
    //        string query = "usp_Patient_Select";
    //        using (SqlCommand command = new SqlCommand(query, connection))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            SqlParameter param = new SqlParameter();
    //            param.ParameterName = "@username";
    //            param.Value = username;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            command.Parameters.Add(param);

    //            param = new SqlParameter();
    //            param.ParameterName = "@password";
    //            param.Value = password;
    //            param.SqlDbType = SqlDbType.VarChar;
    //            command.Parameters.Add(param);

    //            connection.Open();
    //            SqlDataReader data;
    //            data = command.ExecuteReader();
    //            if (data.HasRows)
    //                isValue = true;
    //        }
    //        return isValue;
    //    }
    }
}
