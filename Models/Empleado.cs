using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Empleado
    {
        public int Empleado_Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int Posicion_id { get; set; }
        public Posicion Posicion { get; set; }
        public double Salario_x_hora { get; set; }
        public int Ubicacion_Id { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public string Tipo_Empleado { get; set; }
        public IEnumerable<CuentaBanco> CuentaBancos { get; set; }
        public IEnumerable<BolantePago> BolantePagos { get; set; }
    }
}
