using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModel
{
    public class ProyectoVM
    {
        public IEnumerable<Proyecto> ProyectosLista { get; set; }
        public Proyecto Proyecto { get; set; }

    }
}
