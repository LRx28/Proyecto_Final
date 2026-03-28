using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    internal class AppAgenciaTContext : DbContext
    {
        public DbSet<Pais> Pais{ get; set; }  
        public DbSet<Destino> Destinos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LR;Database=Agencia_Tours;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
