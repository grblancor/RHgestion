namespace GestionRH
{
    partial class SolicitarVacacionesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnSolicitar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnSolicitar = new System.Windows.Forms.Button();

            this.txtCedula.Location = new System.Drawing.Point(100, 30);
            this.dtpInicio.Location = new System.Drawing.Point(100, 70);
            this.dtpFin.Location = new System.Drawing.Point(100, 110);
            this.btnSolicitar.Location = new System.Drawing.Point(150, 150);

            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.Click += new System.EventHandler(this.btnProcesar_Click);

            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.btnSolicitar);

            this.Text = "Solicitar Vacaciones";
        }
    }
}
