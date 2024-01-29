using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp.net_exam.Models;

namespace asp.net_exam.Data
{
    public class aspnet_examContext : DbContext
    {
        public aspnet_examContext (DbContextOptions<aspnet_examContext> options)
            : base(options)
        {
        }

        public DbSet<asp.net_exam.Models.Employee> Employee { get; set; } = default!;

        public DbSet<asp.net_exam.Models.Department> Department { get; set; } = default!;
    }
}
