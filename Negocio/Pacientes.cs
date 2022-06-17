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

        public void CrearPaciente(string NExpediente, string Nombre, string Apellido, string Direccion, string Telefono, string Celular, string FechaNaciemiento, int Edad, string TipoSangre, int Documento, string NumeroDocumento, int Sexo, int EstadoCivil, string LugarNacimiento, string Email, string Ocupacion, int ParentescoFamiliar1, string NombreFamiliar1, string TelefonoFamiliar1, string DireccionFamiliar1, int ParentescoFamiliar2, string NombreFamiliar2, string TelefonoFamiliar2, string DireccionFamiliar2)
        {
            ObjetoPaciente.CrearExpediente(NExpediente,Nombre,Apellido,
                Direccion,Telefono,Celular,FechaNaciemiento,Edad,TipoSangre,Documento,
                NumeroDocumento,Sexo,EstadoCivil,LugarNacimiento,Email,Ocupacion,ParentescoFamiliar1,
                NombreFamiliar1,TelefonoFamiliar1,DireccionFamiliar1,ParentescoFamiliar2,
                NombreFamiliar2,TelefonoFamiliar2,DireccionFamiliar2);
        }
    }
}
