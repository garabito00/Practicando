using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context.Extension
{
    public static class BolantePagoFluentAPI
    {
        public static void BolantePagoFluentApi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BolantePago>().ToTable("bolantePago");
            modelBuilder.Entity<BolantePago>().HasKey(b => b.Bolante_Id);
            modelBuilder.Entity<BolantePago>().Property(b => b.AFP).HasColumnName("afp").HasColumnType("double").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Bonificacion_Asistencia).HasColumnName("bonificacion_asistencia").HasColumnType("boolean").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Bono_Extra).HasColumnName("bono_extra").HasColumnType("double").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Empleado_Id).HasColumnName("empleado_id").HasColumnType("int").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Fecha).HasColumnName("Fecha").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Horas_Extra).HasColumnName("horas_extra").HasColumnType("double");
            modelBuilder.Entity<BolantePago>().Property(b => b.Horas_Normales).HasColumnName("horas_normales").HasColumnType("double").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Pagos_Horas_Extras).HasColumnName("pagos_horas_extra").HasColumnType("double");
            modelBuilder.Entity<BolantePago>().Property(b => b.Pagos_Horas_Normales).HasColumnName("pagos_horas_normales").HasColumnType("double").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Seguro_Salud).HasColumnName("seguro_salud").HasColumnType("double").IsRequired();
            modelBuilder.Entity<BolantePago>().Property(b => b.Total_Periodo).HasColumnName("total_periodo").HasColumnType("double").IsRequired();

        }
    }
}
