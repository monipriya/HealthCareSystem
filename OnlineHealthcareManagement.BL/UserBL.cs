using OnlineHealthcareManagement.Entity;
using OnlineHealthcareManagementSystem.DAL;
using System.Collections.Generic;

namespace OnlineHealthcareManagement.BL
{
    public class UserBL
    {
        public static void AddCustomer(Account account)
        {
             UserRepositary.AddCustomer(account);
        }
        public static IEnumerable<Account> GetUsers()
        {
            return UserRepositary.GetUsers();
        }
    }
}
