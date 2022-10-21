using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context.Extension
{
    public static class RelacionesFluentAPI
    {
        public static void RelacionesFluentApi(this ModelBuilder modelBuilder)
        {
            //uno a muchos Empleado a Posicion
            modelBuilder.Entity<Empleado>().HasOne<Posicion>(e => e.Posicion).WithMany(p => p.Empleados).HasForeignKey(e => e.Posicion_id);

            //uno a muchos Empleados a Ubicacion
            modelBuilder.Entity<Empleado>().HasOne<Ubicacion>(e => e.Ubicacion).WithMany(u => u.Empleados).HasForeignKey(e => e.Ubicacion_Id);

            //uno a muchos Cuenta de Banco a Empleados
            modelBuilder.Entity<CuentaBanco>().HasOne<Empleado>(c => c.Empleado).WithMany(e => e.CuentaBancos).HasForeignKey(c => c.Empleado_Id);

            //uno a muchos Bolante de pago a Empleado
            modelBuilder.Entity<BolantePago>().HasOne<Empleado>(b => b.Empleado).WithMany(e => e.BolantePagos).HasForeignKey(b => b.Empleado_Id);

            //uno a muchos Posicion a Proyectos
            modelBuilder.Entity<Posicion>().HasOne<Proyecto>(po => po.Proyecto).WithMany(pr => pr.Posiciones).HasForeignKey(po => po.Posicion_Id);
        }
    }
}
