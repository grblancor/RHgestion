using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace Business.Managers
{
    public class ArchivoManager
    {
        private List<Empleado> _empleados;

        public ArchivoManager()
        {
            _empleados = new List<Empleado>();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            if (empleado == null) throw new ArgumentNullException(nameof(empleado));
            _empleados.Add(empleado);
        }

        public Empleado ObtenerEmpleadoPorUsuario(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario)) throw new ArgumentNullException("El usuario no puede ser vacío");
            return _empleados.Find(e => e.Usuario.Equals(usuario, StringComparison.OrdinalIgnoreCase));
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return new List<Empleado>(_empleados);
        }
    }
}
