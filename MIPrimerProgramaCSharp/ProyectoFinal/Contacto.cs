using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoFinal
{
    class Contacto
    {
        Persona persona;
        Telefono telefono;
        Direccion direccion;
        string Email;

        public Contacto()
        {
            persona = new Persona() ;
            telefono = new Telefono() ;
            direccion = new Direccion() ;
            Email = "";
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetNombre(string nombre)
        {
            persona.SetNombre(nombre);
        }
        public void SetApellido(string apellido)
        {
            persona.SetApellido(apellido);
        }
        public void SetFechaNacimiento(string fechaNacimiento)
        {
            persona.SetFechaNacimiento (fechaNacimiento);
        }
        public void SetTelefonoMovil(string telefonoMovil)
        {
            telefono.SetTelefonoMovil (telefonoMovil);
        }
        public void SetTelefonoTrabajo(string telefonoTrabajo)
        {
            telefono.SetTelefonoTrabajo(telefonoTrabajo);
        }
        public void SetTelefonoFijo(string telefonoFijo)
        {
            telefono.SetTelefonoFijo(telefonoFijo);
        }
        public void SetPiso(string piso)
        {
            direccion.SetPiso(piso);
        }
        public void SetCalle(string calle)
        {
            direccion.SetCalle(calle);
        }
        public void SetCiudad(string ciudad)
        {
            direccion.SetCiudad(ciudad);
        }
        public void SetCodigoPostal(string codigoPostal)
        {
            direccion.SetCodigoPostal(codigoPostal);
        }


        public string GetNombre()
        {
            return persona.GetNombre();
        }


        public string GetApellido( )
        {
            return persona.GetApellido();
        }
        public string GetFechaNacimiento( )
        {
            return persona.GetFechaNacimiento();
        }
        public string GetTelefonoMovil( )
        {
            return telefono.GetTelefonoMovil();
        }
        public string GetTelefonoTrabajo( )
        {
            return telefono.GetTelefonoTrabajo();
        }
        public string GetTelefonoFijo( )
        {
            return telefono.GetTelefonoFijo();
        }
        public string GetPiso( )
        {
            return direccion.GetPiso();
        }
        public string GetCalle( )
        {
            return direccion.GetCalle();
        }
        public string GetCiudad( )
        {
            return direccion.GetCiudad();
        }
        public string GetCodigoPostal( )
        {
            return  direccion.GetCodigoPostal();
        }



        public void MostrarContacto()
        {
            Console.WriteLine();
            Console.WriteLine("----INFORMACION DE CONTACTO-----");
            Console.WriteLine("Nombre: " + persona.GetNombre () +persona.GetApellido ());
            Console.WriteLine("Fecha de nacimiento: " + persona.GetFechaNacimiento());
            Console.WriteLine("Direccion:  {0} {1} {2} {3}", direccion.GetPiso(), direccion.GetCalle(),direccion.GetCiudad(), direccion.GetCodigoPostal());
            Console.WriteLine("Telefono Fijo: {0}", telefono.GetTelefonoFijo());
            Console.WriteLine("Telefono Movil: {0}", telefono.GetTelefonoMovil());
            Console.WriteLine("Telefono Trabajo: {0}", telefono.GetTelefonoTrabajo());
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine();
        }
    }
}
