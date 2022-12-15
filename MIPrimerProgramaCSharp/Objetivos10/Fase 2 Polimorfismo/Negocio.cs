using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos10.Fase_2_Polimorfismo
{
    class Negocio
    {
        string Propietario;
        string Direccion;
        string Telefono;
        
        public Negocio()
        {
            Propietario = "";
            Direccion = "";
            Telefono = "";
        }
        public void SetPropietario(string propietario)
        {
            Propietario = propietario;
        }
        public void SetDireccion(string direccion)
        {
            Direccion = direccion;
        }
        public void SetTelefono(string telefono)
        {
            Telefono = telefono;
        }
        public string GetPropietario()
        {
            return Propietario;
        }
        public string GetDireccion()
        {
            return Direccion;
        }
        public string GetTelefono()
        {
            return Telefono;
        }
        public virtual void Mostarar()
        {
            Console.WriteLine();
            Console.WriteLine("----- N E G O C I O ------");
            Console.WriteLine();
            Console.WriteLine("Propietario: {0}", Propietario );
            Console.WriteLine("Direecion: {0}", Direccion );
            Console.WriteLine("Telefono: {0}", Telefono );
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

        }
    }
}
