using System;

namespace Linares_Tarea4.Models
{
    public class Perro
    {
        public string Nombre { get; set; }
        public string Tamano { get; set; } // Pequeño, Mediano, Grande
        public string Peso { get; set; } // kg promedio
        public string Edad{ get; set; } // años promedio de vida
        public string ImagenUrl { get; set; }
    }
}
