using System;
using System.Windows.Forms;
using GestionRH.Managers;

namespace GestionRH
{
    public partial class JefeForm : Form
    {
        private readonly VacacionesManager _vacacionesManager;

        public JefeForm(VacacionesManager manager)
        {
            InitializeComponent();
            _vacacionesManager = manager ?? throw new ArgumentNullException(nameof(manager));
            CargarSolicitudesPendientes();
        }

        private void CargarSolicitudesPendientes()
        {
            try
            {
                var solicitudes = _vacacionesManager.ObtenerSolicitudesPendientes();
                dgvSolicitudesPendientes.DataSource = solicitudes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las solicitudes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitudesPendientes.SelectedRows.Count > 0)
                {
                    int solicitudId = Convert.ToInt32(dgvSolicitudesPendientes.SelectedRows[0].Cells["Id"].Value);
                    _vacacionesManager.AprobarSolicitud(solicitudId);
                    MessageBox.Show("Solicitud aprobada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarSolicitudesPendientes();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una solicitud para aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aprobar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitudesPendientes.SelectedRows.Count > 0)
                {
                    int solicitudId = Convert.ToInt32(dgvSolicitudesPendientes.SelectedRows[0].Cells["Id"].Value);
                    _vacacionesManager.RechazarSolicitud(solicitudId);
                    MessageBox.Show("Solicitud rechazada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarSolicitudesPendientes();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una solicitud para rechazar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al rechazar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
