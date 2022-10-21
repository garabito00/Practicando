using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context.Extension
{
    public static class EmpleadoFluentAPI
    {
        public static void EmpleadoFluentApi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().ToTable("empelados");
            modelBuilder.Entity<Empleado>().HasKey(e => e.Empleado_Id);
            modelBuilder.Entity<Empleado>().Property(e => e.Apellido).HasColumnName("apellido").HasColumnType("VARCHAR(25)").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Cedula).HasColumnName("cedula").HasColumnType("VARCHAR(25)").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasColumnName("nombre").HasColumnType("VARCHAR(25)").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Posicion_id).HasColumnName("posicion_id").HasColumnType("int").IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Salario_x_hora).HasColumnName("salario_hora").HasColumnType("double").IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Tipo_Empleado).HasColumnName("tipo_empleado").HasColumnType("VARCHAR(25)").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Ubicacion_Id).HasColumnName("ubicacion_id").HasColumnType("int").IsRequired();
        }
    }
}
