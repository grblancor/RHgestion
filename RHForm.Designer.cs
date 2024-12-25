namespace GestionRH
{
    partial class RHForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Button btnAjustarVacaciones;
        private System.Windows.Forms.Button btnProcesarSolicitudes;

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
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btnAjustarVacaciones = new System.Windows.Forms.Button();
            this.btnProcesarSolicitudes = new System.Windows.Forms.Button();

            // btnRegistrarEmpleado
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(30, 30);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(200, 30);
            this.btnRegistrarEmpleado.Text = "Registrar Empleado";
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnRegistrarEmpleado_Click);

            // btnAjustarVacaciones
            this.btnAjustarVacaciones.Location = new System.Drawing.Point(30, 80);
            this.btnAjustarVacaciones.Name = "btnAjustarVacaciones";
            this.btnAjustarVacaciones.Size = new System.Drawing.Size(200, 30);
            this.btnAjustarVacaciones.Text = "Ajustar Vacaciones";
            this.btnAjustarVacaciones.Click += new System.EventHandler(this.btnAjustarVacaciones_Click);

            // btnProcesarSolicitudes
            this.btnProcesarSolicitudes.Location = new System.Drawing.Point(30, 130);
            this.btnProcesarSolicitudes.Name = "btnProcesarSolicitudes";
            this.btnProcesarSolicitudes.Size = new System.Drawing.Size(200, 30);
            this.btnProcesarSolicitudes.Text = "Procesar Solicitudes";
            this.btnProcesarSolicitudes.Click += new System.EventHandler(this.btnProcesarSolicitudes_Click);

            // RHForm
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.btnAjustarVacaciones);
            this.Controls.Add(this.btnProcesarSolicitudes);
            this.Name = "RHForm";
            this.Text = "Gestión de Recursos Humanos";
        }
    }
}
