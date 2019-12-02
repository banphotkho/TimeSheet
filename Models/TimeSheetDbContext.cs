using System;
using Microsoft.EntityFrameworkCore;

namespace TimeSheet.Models
{
    public class TimeSheetDbContext:DbContext
    {
        public TimeSheetDbContext(DbContextOptions<TimeSheetDbContext>options):base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DeptSection> DeptSections { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskEvent> TaskEvents { get; set; }
        public DbSet<Jobtype> Jobtypes { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Acitivity> Acitivities { get; set; }


    }

   // dotnet ef migrations add "Initail"
   // dotnet update database

}
