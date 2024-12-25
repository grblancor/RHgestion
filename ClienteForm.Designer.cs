namespace GestionRH
{
    partial class ClienteForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblSaldoVacaciones;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Button btnSolicitarVacaciones;
        private System.Windows.Forms.Button btnReversionVacaciones;

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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblSaldoVacaciones = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.btnSolicitarVacaciones = new System.Windows.Forms.Button();
            this.btnReversionVacaciones = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.lblNombre.Location = new System.Drawing.Point(30, 30);
            this.lblNombre.Text = "Nombre:";

            this.lblCedula.Location = new System.Drawing.Point(30, 60);
            this.lblCedula.Text = "Cédula:";

            this.lblSaldoVacaciones.Location = new System.Drawing.Point(30, 90);
            this.lblSaldoVacaciones.Text = "Saldo Vacaciones:";

            this.lblFechaIngreso.Location = new System.Drawing.Point(30, 120);
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";

            this.btnSolicitarVacaciones.Location = new System.Drawing.Point(30, 160);
            this.btnSolicitarVacaciones.Text = "Solicitar Vacaciones";
            this.btnSolicitarVacaciones.Click += new System.EventHandler(this.btnSolicitarVacaciones_Click);

            this.btnReversionVacaciones.Location = new System.Drawing.Point(200, 160);
            this.btnReversionVacaciones.Text = "Reversión Vacaciones";
            this.btnReversionVacaciones.Click += new System.EventHandler(this.btnReversionVacaciones_Click);

            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblSaldoVacaciones);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.btnSolicitarVacaciones);
            this.Controls.Add(this.btnReversionVacaciones);

            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Text = "Cliente - Información";

            this.ResumeLayout(false);
        }
    }
}
