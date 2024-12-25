using System;
using System.Windows.Forms;
using Business.Managers;
using GestionRH.Managers;
using GestionRH;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        try
        {
            // Inicializar el gestor de vacaciones
            VacacionesManager vacacionesManager = new VacacionesManager();

            // Iniciar la aplicación con el formulario de inicio de sesión
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error crítico al iniciar la aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}