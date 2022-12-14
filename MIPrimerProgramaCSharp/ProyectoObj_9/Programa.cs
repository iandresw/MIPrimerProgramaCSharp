using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoObj_9
{
    class Programa
    {
        static void MostrarMenu()
        {
            Console.WriteLine("###### M E N U ######");
            Console.WriteLine("1.- Añadir libro a la biblioteca");
            Console.WriteLine("2.- Mostrar biblioteca");
            Console.WriteLine("3.- Borrar libro");
            Console.WriteLine("4.- ¿Numero de libros?");
            Console.WriteLine("Salir");
            Console.Write("Opcion: ");
        }

        static Biblioteca anadirLibroBiblioteca(Biblioteca biblioteca)
        {
            string nombreLibro;
            string isbn;
            string nombreAutor;
            string apellidoAutor;

            Console.WriteLine("Introduzca el nombre de libro: ");
            nombreLibro = Console.ReadLine();
            Console.WriteLine("Introduzca el ISBN: ");
            isbn  = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre de autor: ");
            nombreAutor  = Console.ReadLine();
            Console.WriteLine("Introduzca el apellido de autor: ");
            apellidoAutor  = Console.ReadLine();

            Autor autor = new Autor(nombreAutor, apellidoAutor);
            Libro libro = new Libro(nombreLibro, isbn);
            libro.AnadirAutor(autor);
            biblioteca.AnadirLibro(libro);
            return biblioteca;
        }

        static Biblioteca BorrarLibroBiblioteca(Biblioteca biblioteca)
        {
            Console.WriteLine("Introduzca el nombre de libro a borrar: ");
            biblioteca.BorrarLibro(Console.ReadLine());
            return biblioteca;
        }

        static void Main(string[] args)
        {
            bool fin = false;
            Biblioteca biblioteca = new Biblioteca();
            int opcion = 0;
            while (!fin)
            {
                MostrarMenu();
                opcion = Convert.ToInt32(Console.ReadLine ());
                switch (opcion )
                {
                    case 1:
                        anadirLibroBiblioteca(biblioteca);
                        break;
                    case 2:
                        biblioteca.Mostrar();
                        break;
                    case 3:
                        BorrarLibroBiblioteca(biblioteca);
                        break;
                    case 4:
                        Console.WriteLine ("Numero de libros en la biblioteca: " + biblioteca.NumeroLibros());
                        break;
                    case 5:
                        fin = true;
                        break;
                }
            }
            Console.WriteLine("******  F I N   D E L   P R O G R A M A  *******");
        }
    }
}
