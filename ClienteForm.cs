using System;
using System.Windows.Forms;
using Presentation.Forms; // Asegúrate de tener el namespace correcto

namespace GestionRH
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void btnSolicitarVacaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitud de vacaciones enviada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReversionVacaciones_Click(object sender, EventArgs e)
        {
            using (var form = new ReversionVacacionesForm())
            {
                form.ShowDialog();
            }
        }
    }
}
