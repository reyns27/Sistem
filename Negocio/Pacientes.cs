using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Pacientes;
using System.Data;

namespace Negocio
{
    public class Pacientes
    {
        private readonly DPacientes ObjetoPaciente = new();
        public DataTable Mostrar()
        {
            DataTable Tabla = new();
            Tabla = ObjetoPaciente.Mostrar();
            return Tabla;
        }
    }
}
