namespace GestionRH
{
    partial class RegistrarEmpleadoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;

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
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            // lblCedula
            this.lblCedula.Location = new System.Drawing.Point(30, 30);
            this.lblCedula.Text = "Cédula:";
            this.txtCedula.Location = new System.Drawing.Point(150, 30);

            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(30, 70);
            this.lblNombre.Text = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(150, 70);

            // lblRol
            this.lblRol.Location = new System.Drawing.Point(30, 110);
            this.lblRol.Text = "Rol:";
            this.cmbRol.Location = new System.Drawing.Point(150, 110);
            this.cmbRol.Items.AddRange(new string[] { "Administrador", "Empleado" });

            // lblFechaIngreso
            this.lblFechaIngreso.Location = new System.Drawing.Point(30, 150);
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            this.dtpFechaIngreso.Location = new System.Drawing.Point(150, 150);

            // btnRegistrar
            this.btnRegistrar.Location = new System.Drawing.Point(70, 200);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(200, 200);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Text = "Registrar Empleado";
        }
    }
}
