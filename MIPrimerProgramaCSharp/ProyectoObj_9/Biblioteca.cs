using System;
using System.Collections.Generic;


namespace MIPrimerProgramaCSharp.ProyectoObj_9
{
    class Biblioteca
    {
        List<Libro> Libros;

        public Biblioteca()
        {
            Libros = new List<Libro>();
        }

        public int NumeroLibros()
        {
            int valor = Libros.Count;
            return valor;
        }

        public void AnadirLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public void BorrarLibro(string nombreLibro)
        {
            bool encontrado = false;
            int PosicionBorrado = -1;
            foreach (Libro  libro in Libros )
            {
                PosicionBorrado++;
                if (libro.GetNombreLibro() == nombreLibro)
                {
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
            {
                Libros.RemoveAt(PosicionBorrado);
                Console.WriteLine("¡Libro Borrado Exitosamente!");
            }
            else
            {
                Console.WriteLine("¡Libro No Encontrado!");
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("**********B I B L I O T E C A **********");
            foreach (Libro libro in Libros)
            {
                libro.MostarLibro();
                Console.WriteLine("********************");
            }
        }
    }
}
