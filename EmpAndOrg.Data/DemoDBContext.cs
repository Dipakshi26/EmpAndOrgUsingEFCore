using EmpAndOrg.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndOrg.Data
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organisation> Organizations { get; set; }
        public DemoDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P3O2VMI\SQLEXPRESS;Database=EntityFrameworkDB;Trusted_Connection=True;");
        }
    }
}
