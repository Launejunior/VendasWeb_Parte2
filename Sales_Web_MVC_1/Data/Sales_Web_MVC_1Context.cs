using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales_Web_MVC_1.Models;

namespace Sales_Web_MVC_1.Data
{
    public class Sales_Web_MVC_1Context : DbContext
    {
        public Sales_Web_MVC_1Context (DbContextOptions<Sales_Web_MVC_1Context> options)
            : base(options)
        {
        }

        public DbSet<Sales_Web_MVC_1.Models.Departamento> Departamento { get; set; } = default!;
    }
}
