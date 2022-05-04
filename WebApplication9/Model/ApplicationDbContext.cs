using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication9.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("Data Source=CHETUIWK383\\SQLEXPRESS;Initial Catalog=EmpDb;Integrated Security=True;Pooling=False") { }

        public DbSet<Employee> Employees { get; set; }
    }
}