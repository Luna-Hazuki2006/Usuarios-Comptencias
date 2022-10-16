using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Usuarios_Competencias.Modelo
{
    public class EmpledoContext : DbContext
    {
        public virtual DbSet<Empleado>? Empleados { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.EnableSensitiveDataLogging().IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=UsuariosCompetencia;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(t =>
            {
                t.HasKey(t => t.Cedula);
                t.Property(t => t.Estado).IsRequired(true);
            });
        }
    }
}
