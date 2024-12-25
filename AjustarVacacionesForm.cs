using System;
using System.Windows.Forms;
using GestionRH.Managers;

namespace GestionRH
{
    public partial class AjustarVacacionesForm : Form
    {
        private VacacionesManager vacacionesManager;

        public AjustarVacacionesForm(VacacionesManager manager)
        {
            InitializeComponent();
            vacacionesManager = manager;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string empleadoCedula = txtCedula.Text;

                if (string.IsNullOrWhiteSpace(empleadoCedula))
                {
                    MessageBox.Show("La cédula del empleado es obligatoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Vacaciones ajustadas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar ajustes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear caracteres no numéricos.
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
