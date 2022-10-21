using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Proyecto
    {
        public int Proyecto_Id { get; set; }
        public string Compania { get; set; }
        public IEnumerable<Posicion> Posiciones { get; set; }
    }
}
