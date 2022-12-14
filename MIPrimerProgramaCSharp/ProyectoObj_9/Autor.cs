using System;


namespace MIPrimerProgramaCSharp.ProyectoObj_9
{
    class Autor
    {
        string Nombre;
        string Apellido;
        public Autor(string nombre,string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public void MostrarAutor()
        {
            Console.WriteLine("Autor {0} {1}",Nombre,Apellido );
        }

        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public string GetNombre()
        {
           return  Nombre;
        }
        public void SetApellido(string apellido)
        {
            Apellido  = apellido ;
        }
        public string GetApellido()
        {
            return Apellido;
        }
    }
}
