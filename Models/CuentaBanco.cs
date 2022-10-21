using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CuentaBanco
    {
        public int Cuenta_Banco_Id { get; set; }
        public string Banco { get; set; }
        public string Tipo_Cuenta { get; set; }
        public int Numero_Cuenta { get; set; }
        public int Empleado_Id { get; set; }
        public Empleado Empleado { get; set; }
    }
}
