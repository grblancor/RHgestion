namespace Domain.Models
{
    public class SolicitudVacaciones
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Estado { get; set; } // Pendiente, Aprobada, Rechazada
    }
}
