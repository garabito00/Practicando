using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository.Context.Extension
{
    public static class PosicionFluentAPI
    {
        public static void PosicionFluentApi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posicion>().ToTable("Posicion");
            modelBuilder.Entity<Posicion>().HasKey(p => p.Posicion_Id);
            modelBuilder.Entity<Posicion>().Property(p => p.Titulo).HasColumnName("titulo").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Posicion>().Property(p => p.Proyecto_Id).HasColumnName("proyecto_id").HasColumnType("int").IsRequired();
        }
    }
}
