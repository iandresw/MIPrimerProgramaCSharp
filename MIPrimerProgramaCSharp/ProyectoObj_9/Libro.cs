using System;


namespace MIPrimerProgramaCSharp.ProyectoObj_9
{
    class Libro
    {
        string NombreLibro;
        string ISBN;
        Autor NombreAutor;

        public Libro (string nombre, string isbn)
        {
            NombreLibro = nombre;
            ISBN = isbn;
        }

        public void AnadirAutor(Autor autor)
        {
            NombreAutor = autor;
        }
        public void MostarLibro()
        {
            Console.WriteLine("Detalles del Libro");
            Console.WriteLine("Nombre: {0}",NombreLibro );
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Autor: {0} {1}", NombreAutor.GetNombre (), NombreAutor.GetApellido () );
        }

        public string GetNombreLibro()
        {
            return NombreLibro;
        }
        public string GetISBN()
        {
            return ISBN;
        }

    }
}
