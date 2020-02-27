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
         }
}
