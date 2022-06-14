using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class SqlServerConnection
    {
        private SqlConnection Conexion = new SqlConnection("Server=localhost;DataBase=ExpedienteClinicoDB;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}