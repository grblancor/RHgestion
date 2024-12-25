using System;
using System.Collections.Generic;
using Domain.Models;

namespace GestionRH.Managers
{
    public class VacacionesManager
    {
        private readonly List<SolicitudVacaciones> _solicitudes;

        public VacacionesManager()
        {
            _solicitudes = new List<SolicitudVacaciones>();
        }

        public List<SolicitudVacaciones> ObtenerSolicitudesPendientes()
        {
            return _solicitudes.FindAll(s => s.Estado == "Pendiente");
        }

        public void AprobarSolicitud(int solicitudId)
        {
            var solicitud = _solicitudes.Find(s => s.Id == solicitudId);
            if (solicitud == null) throw new ArgumentException("Solicitud no encontrada.");
            solicitud.Estado = "Aprobada";
        }

        public void RechazarSolicitud(int solicitudId)
        {
            var solicitud = _solicitudes.Find(s => s.Id == solicitudId);
            if (solicitud == null) throw new ArgumentException("Solicitud no encontrada.");
            solicitud.Estado = "Rechazada";
        }

        public void AgregarSolicitud(SolicitudVacaciones solicitud)
        {
            if (solicitud == null) throw new ArgumentNullException(nameof(solicitud));
            _solicitudes.Add(solicitud);
        }
    }
}
