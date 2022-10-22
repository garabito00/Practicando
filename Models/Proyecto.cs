using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Proyecto
    {
        public int Proyecto_Id { get; set; }
        [Required]
        [Display(Name = "Compañia")]
        public string Compania { get; set; }
        public IEnumerable<Posicion> Posiciones { get; set; }
    }
}
