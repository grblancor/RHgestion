using System;
using System.Windows.Forms;
using GestionRH.Managers;

namespace GestionRH
{
    public partial class GestionVacacionesForm : Form
    {
        private readonly VacacionesManager _vacacionesManager;

        public GestionVacacionesForm(VacacionesManager vacacionesManager)
        {
            _vacacionesManager = vacacionesManager ?? throw new ArgumentNullException(nameof(vacacionesManager));
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                _vacacionesManager.ProcesarSolicitudesVacaciones();
                MessageBox.Show("Procesamiento de vacaciones completado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante el procesamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
