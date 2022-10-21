using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context.Extension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Empleado> empleados { get; set; }
        public DbSet<BolantePago> bolantePagos { get; set; }
        public DbSet<CuentaBanco> cuentaBancos { get; set; }
        public DbSet<Posicion> posiciones { get; set; }
        public DbSet<Proyecto> proyectos { get; set; }
        public DbSet<Ubicacion> ubicaciones { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.BolantePagoFluentApi();
            modelBuilder.CuentaBancoFluentApi();
            modelBuilder.EmpleadoFluentApi();
            modelBuilder.PosicionFluentApi();
            modelBuilder.ProyectoFluentApi();
            modelBuilder.UbicacionFluentApi();
            modelBuilder.RelacionesFluentApi();
         }
    }
}
