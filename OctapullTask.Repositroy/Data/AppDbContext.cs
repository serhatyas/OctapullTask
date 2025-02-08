using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OctapullTask.Repositroy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctapullTask.Repositroy.Data
{
    public class AppDbContext : DbContext
    {
        // Normal constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Parametresiz constructor (EF Core migration için)
        public AppDbContext() { }

        public DbSet<User> Users { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
    }
}
