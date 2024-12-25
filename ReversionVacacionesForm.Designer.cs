namespace Presentation.Forms
{
    partial class ReversionVacacionesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRevertir;

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
            this.btnRevertir = new System.Windows.Forms.Button();

            // btnRevertir
            this.btnRevertir.Location = new System.Drawing.Point(50, 50);
            this.btnRevertir.Name = "btnRevertir";
            this.btnRevertir.Size = new System.Drawing.Size(200, 30);
            this.btnRevertir.Text = "Revertir";
            this.btnRevertir.UseVisualStyleBackColor = true;
            this.btnRevertir.Click += new System.EventHandler(this.btnRevertir_Click);

            // ReversionVacacionesForm
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnRevertir);
            this.Name = "ReversionVacacionesForm";
            this.Text = "Reversión de Vacaciones";
        }
    }
}
