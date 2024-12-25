using System;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class EmpleadoForm : Form
    {
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        private void btnReversionVacaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reversión de vacaciones en proceso.");
        }

        private void btnSolicitarVacaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitud de vacaciones enviada.");
        }
    }
}
