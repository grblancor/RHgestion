using System;
using System.Windows.Forms;
using GestionRH.Managers;

namespace GestionRH
{
    public partial class RHForm : Form
    {
        private readonly VacacionesManager _vacacionesManager;

        public RHForm(VacacionesManager vacacionesManager)
        {
            _vacacionesManager = vacacionesManager ?? throw new ArgumentNullException(nameof(vacacionesManager));
            InitializeComponent();
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            using (var registrarEmpleadoForm = new RegistrarEmpleadoForm())
            {
                registrarEmpleadoForm.ShowDialog();
            }
        }

        private void btnAjustarVacaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajustar Vacaciones - Funcionalidad en desarrollo.");
        }

        private void btnProcesarSolicitudes_Click(object sender, EventArgs e)
        {
            _vacacionesManager.ProcesarSolicitudesVacaciones();
            MessageBox.Show("Solicitudes de vacaciones procesadas con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
