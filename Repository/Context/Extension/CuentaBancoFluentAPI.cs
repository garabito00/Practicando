using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context.Extension
{
    public static class CuentaBancoFluentAPI
    {
        public static void CuentaBancoFluentApi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuentaBanco>().ToTable("CuentaBanco");
            modelBuilder.Entity<CuentaBanco>().HasKey(c => c.Cuenta_Banco_Id);
            modelBuilder.Entity<CuentaBanco>().Property(c => c.Banco).HasColumnName("banco").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<CuentaBanco>().Property(c => c.Numero_Cuenta).HasColumnName("numero_cuenta").HasColumnType("int").IsRequired();
            modelBuilder.Entity<CuentaBanco>().Property(c => c.Tipo_Cuenta).HasColumnName("tipo_cuenta").HasColumnType("VARCHAR(50)").HasMaxLength(50);

        }
    }
}
