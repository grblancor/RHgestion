using System;
using System.Data.SqlClient;

namespace DataAccess
{
    /// <summary>
    /// Clase para gestionar la conexión con la base de datos utilizando un patrón Singleton.
    /// </summary>
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> _instance = new(() => new DatabaseConnection());
        private readonly SqlConnection _connection;

        private DatabaseConnection()
        {
            var connectionString = @"Server=HOMEPC\MSSQLSERVER_Q3;Database=GestionVacaciones;Trusted_Connection=True;";
            _connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance => _instance.Value;

        public SqlConnection GetConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
                {
                    _connection.Open();
                }
                return _connection;
            }
            catch (SqlException ex)
            {
                // Registra el error en un sistema de logs o lanza una excepción personalizada
                throw new Exception($"Error al conectar con la base de datos: {ex.Message}", ex);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al cerrar la conexión: {ex.Message}", ex);
            }
        }
    }
}
