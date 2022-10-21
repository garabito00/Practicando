using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class BolantePago
    {
        public int Bolante_Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Bonificacion_Asistencia { get; set; }
        public double Bono_Extra { get; set; }
        public double Horas_Normales { get; set; }
        public double Horas_Extra { get; set; }
        public double AFP { get; set; }
        public double Seguro_Salud { get; set; }
        public double Pagos_Horas_Normales { get; set; }
        public double Pagos_Horas_Extras { get; set; }
        public double Total_Periodo { get; set; }
        public int Empleado_Id { get; set; }
        public Empleado Empleado { get; set; }
    }
}
