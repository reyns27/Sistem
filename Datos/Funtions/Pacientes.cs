﻿using System;
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
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Conexion.CerrarConexion();
            return Tabla;

        }
    }
}