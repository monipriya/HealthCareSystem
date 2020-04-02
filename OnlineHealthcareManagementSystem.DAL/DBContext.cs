using System;
using System.Data.Entity; 
using OnlineHealthcareManagement.Entity;

namespace OnlineHealthcareManagementSystem.DAL
{
   public class DBContext:DbContext
    {
public DBContext() : base("DBConnection")
        {

        }
        public DbSet<Account> UserDB { get; set; }
        public DbSet<DoctorDetails> DoctorDB { get; set; }
    }
   

}
