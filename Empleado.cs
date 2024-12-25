using System;

namespace Domain.Models
{
    public class Empleado
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int SaldoVacaciones { get; set; }
        public string Usuario { get; set; } // Propiedad añadida
    }
}
