using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context.Extension
{
    public static class ProyectoFluentAPI
    {
        public static void ProyectoFluentApi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proyecto>().ToTable("Proyecto");
            modelBuilder.Entity<Proyecto>().HasKey(p => p.Proyecto_Id);
            modelBuilder.Entity<Proyecto>().Property(p => p.Compania).HasColumnName("compania").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
        }
    }
}
