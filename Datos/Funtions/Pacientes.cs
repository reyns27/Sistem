using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Pacientes
{
    public class DPacientes
    {
        private SqlServerConnection Conexion = new();
        SqlDataReader? Leer;
        DataTable Tabla = new();
        SqlCommand Comando = new();

        public DataTable Mostrar()
        {

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Select *from Expediente";
            Comando.CommandType = CommandType.Text;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Conexion.CerrarConexion();
            return Tabla;

        }

        public void CrearExpediente(string NExpediente,string Nombre, string Apellido,string Direccion, string Telefono, string Celular, string FechaNaciemiento, int Edad,string TipoSangre,int Documento, string NumeroDocumento, int Sexo, int EstadoCivil, string LugarNacimiento, string Email, string Ocupacion,int ParentescoFamiliar1,string NombreFamiliar1, string TelefonoFamiliar1, string DireccionFamiliar1, int ParentescoFamiliar2, string NombreFamiliar2, string TelefonoFamiliar2, string DireccionFamiliar2)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.Parameters.Clear();
            Comando.CommandText = "INSERT INTO [dbo].[Expediente]"+
           "([id],[NExpediente],[Nombre],[Apellido],[Direccion],[Telefono],[Celular]"+
           ",[FechaNacimiento],[Edad],[TipoSangre],[Documento],[NumeroDocumento],[Sexo]"+
           ",[EstadoCivil],[LugarNacimiento],[Email],[Ocupacion],[ParentescoFamiliar1]"+
           ",[NombreFamiliar1],[TelefonoFamiliar1],[DireccionFamiliar1],[ParentescoFamiliar2]"+
           ",[NombreFamiliar2]"+
           ",[TelefonoFamiliar2]"+
           ",[DireccionFamiliar2]) VALUES " +
           "(@NExpediente,"+
           "@Nombre,"+
           "@Apellido,"+
           "@Direccion,"+
           "@Telefono,"+
           "@Celular,"+
           "@FechaNacimiento,"+
           "@Edad,"+
           "@TipoSangre,"+
           "@Documento,"+
           "@NumeroDocumento,"+
           "@Sexo,"+
           "@EstadoCivil,"+
           "@LugarNacimiento,"+
           "@Email,"+
           "@Ocupacion,"+
           "@ParentescoFamiliar1,"+
           "@NombreFamiliar1,"+
           "@TelefonoFamiliar1,"+
           "@DireccionFamiliar1,"+
           "@ParentescoFamiliar2,"+
           "@NombreFamiliar2,"+
           "@TelefonoFamiliar2,"+
           "@DireccionFamiliar2)";

            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@NExpediente", NExpediente);
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Apellido", Apellido);
            Comando.Parameters.AddWithValue("@Direccion", Direccion);
            Comando.Parameters.AddWithValue("@Telefono", Telefono);
            Comando.Parameters.AddWithValue("@Celular", Celular);
            Comando.Parameters.AddWithValue("@FechaNacimiento", FechaNaciemiento);
            Comando.Parameters.AddWithValue("@Edad", Edad);
            Comando.Parameters.AddWithValue("@TipoSangre", TipoSangre);
            Comando.Parameters.AddWithValue("@Documento", Documento);
            Comando.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento);
            Comando.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
            Comando.Parameters.AddWithValue("@Sexo", Sexo);
            Comando.Parameters.AddWithValue("@LugarNacimiento", LugarNacimiento);
            Comando.Parameters.AddWithValue("@Email", Email);
            Comando.Parameters.AddWithValue("@Ocupacion", Ocupacion);
            Comando.Parameters.AddWithValue("@ParentescoFamiliar1", ParentescoFamiliar1);
            Comando.Parameters.AddWithValue("@NombreFamiliar1", NombreFamiliar1);
            Comando.Parameters.AddWithValue("@TelefomoFamiliar1", TelefonoFamiliar1);
            Comando.Parameters.AddWithValue("@DireccionFamiliar1", DireccionFamiliar1);
            Comando.Parameters.AddWithValue("@ParentescoFamiliar2", ParentescoFamiliar2);
            Comando.Parameters.AddWithValue("@NombreFamiliar2", NombreFamiliar2);
            Comando.Parameters.AddWithValue("@TelefomoFamiliar2", TelefonoFamiliar2);
            Comando.Parameters.AddWithValue("@DireccionFamiliar2", DireccionFamiliar2);
            Comando.ExecuteNonQuery();


        }
    }
}
