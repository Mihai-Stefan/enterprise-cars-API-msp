using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardata_api_v3.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
    : base(options)
        {
        }

        public DbSet<CarItem> CarItems { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
