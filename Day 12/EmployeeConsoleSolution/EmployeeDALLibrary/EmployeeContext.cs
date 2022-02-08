using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmployeeModelLibrary;
using System.Runtime.Remoting.Contexts;

namespace EmployeeDALLibrary
{
     class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("conn")
        { 
        
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}
