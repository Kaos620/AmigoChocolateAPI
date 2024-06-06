using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEFCore
{
    public class TestContext : DbContext
    {
        public DbSet<Usuario>  Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=10.107.176.41,1434;User ID=RA044321;Password=044321;database=BD044321;TrustServerCertificate=True;");
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
    }
}
