namespace Presentation.Forms
{
    partial class EmpleadoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReversionVacaciones;
        private System.Windows.Forms.Button btnSolicitarVacaciones;

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
            this.btnReversionVacaciones = new System.Windows.Forms.Button();
            this.btnSolicitarVacaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnReversionVacaciones
            this.btnReversionVacaciones.Location = new System.Drawing.Point(50, 50);
            this.btnReversionVacaciones.Name = "btnReversionVacaciones";
            this.btnReversionVacaciones.Size = new System.Drawing.Size(200, 30);
            this.btnReversionVacaciones.TabIndex = 0;
            this.btnReversionVacaciones.Text = "Reversión Vacaciones";
            this.btnReversionVacaciones.UseVisualStyleBackColor = true;
            this.btnReversionVacaciones.Click += new System.EventHandler(this.btnReversionVacaciones_Click);

            // btnSolicitarVacaciones
            this.btnSolicitarVacaciones.Location = new System.Drawing.Point(50, 100);
            this.btnSolicitarVacaciones.Name = "btnSolicitarVacaciones";
            this.btnSolicitarVacaciones.Size = new System.Drawing.Size(200, 30);
            this.btnSolicitarVacaciones.TabIndex = 1;
            this.btnSolicitarVacaciones.Text = "Solicitar Vacaciones";
            this.btnSolicitarVacaciones.UseVisualStyleBackColor = true;
            this.btnSolicitarVacaciones.Click += new System.EventHandler(this.btnSolicitarVacaciones_Click);

            // EmpleadoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnReversionVacaciones);
            this.Controls.Add(this.btnSolicitarVacaciones);
            this.Name = "EmpleadoForm";
            this.Text = "Gestión de Empleado";
            this.ResumeLayout(false);
        }
    }
}
