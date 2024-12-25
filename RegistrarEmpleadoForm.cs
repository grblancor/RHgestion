using System;
using System.Windows.Forms;
using Domain.Models;

namespace GestionRH
{
    public partial class RegistrarEmpleadoForm : Form
    {
        public RegistrarEmpleadoForm()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtCedula.Text;
                string nombre = txtNombre.Text;
                string rol = cmbRol.SelectedItem?.ToString();
                DateTime fechaIngreso = dtpFechaIngreso.Value;

                if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(rol))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Empleado nuevoEmpleado = new Empleado
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Rol = rol,
                    FechaIngreso = fechaIngreso
                };

                // Guardar empleado en la base de datos o lista
                MessageBox.Show("Empleado registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
