using System;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class ReversionVacacionesForm : Form
    {
        public ReversionVacacionesForm()
        {
            InitializeComponent();
        }

        private void btnRevertir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reversión completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
