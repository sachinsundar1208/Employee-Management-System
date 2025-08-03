using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeMaintain.Models;

namespace EmployeeMaintain.Data
{
    public class EmployeeMaintainContext : DbContext
    {
        public EmployeeMaintainContext (DbContextOptions<EmployeeMaintainContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeMaintain.Models.Employee> Employee { get; set; } = default!;
    }
}
