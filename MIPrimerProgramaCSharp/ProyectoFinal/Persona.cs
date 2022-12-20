using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoFinal
{
    class Persona
    {
        string Nombre;
        string Apellido;
        string FechaNacimiento;

        public Persona()
        {
            Nombre = "";
            Apellido = "";
            FechaNacimiento = "";
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetApellido(string apellido)
        {
            Apellido = apellido;
        }
        public string GetApellido()
        {
            return Apellido;
        }
        public void SetFechaNacimiento(string fechaNacimiento)
        {
            Nombre = fechaNacimiento;
        }
        public string GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
    }
}
