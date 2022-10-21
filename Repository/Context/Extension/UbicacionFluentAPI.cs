using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context.Extension
{
    public static class UbicacionFluentAPI
    {
        public static void UbicacionFluentApi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ubicacion>().ToTable("Ubicacion");
            modelBuilder.Entity<Ubicacion>().HasKey(u => u.Ubicacion_Id);
            modelBuilder.Entity<Ubicacion>().Property(u => u.Lugar).HasColumnName("lugar").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
        }
    }
}
