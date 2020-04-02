using System.Linq;
using System.Collections.Generic;
using OnlineHealthcareManagement.Entity;
namespace OnlineHealthcareManagementSystem.DAL
{
    public class UserRepositary
    {
        static DBContext context = new DBContext();
        public static IEnumerable<Account> GetUsers()
        {
            return context.UserDB.ToList();
        }
        public static void AddCustomer(Account account)
        {
            DBContext context = new DBContext();
            context.UserDB.Add(account);
            context.SaveChanges();
        }
        //public static void Getrole(Account account)
        //{
        //    using (DBContext context = new DBContext())
        //    {
        //         context.UserDB.Where(find => find.Role == account.Role).SingleOrDefault;
        //    }
        //}
        public static Account ValidateUser(Account account)
        {
            using (DBContext context = new DBContext())
            {
                return context.UserDB.Where(find => find.MailId == account.MailId && find.Password == account.Password).SingleOrDefault();
            }
            //bool Isvalue = false;
            //IEnumerable<Account> users = context.UserDB.ToList();
            //foreach (var value in users)
            //{
            //    if (value.MailId == userName && value.Password == password)
            //    {
            //        if (value.Role == "Admin")
            //        {
            //            Isvalue = true;
            //            break;
            //        }
            //    }
            //}
        }
    }
}
