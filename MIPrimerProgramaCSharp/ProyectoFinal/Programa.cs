using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoFinal
{
    class Programa
    {
        static Agenda AgendaContactos;
        static int obtenerOpcion(string texto)
        {
            bool leido = false;
            int valorLeido = 0;
            while(!leido)
            {
                try
                {
                    Console.Write(texto);
                    valorLeido = Convert.ToInt32(Console.ReadLine ());
                    leido = true;
                }
                catch (Exception)
                {
                    Console.Write("ERROR: Tienes que introducir un numero.");
                    throw;
                }
            }
            return valorLeido;
        }
        static void MostrarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------- M E N U ----------");
            Console.WriteLine("1.- MOSTRAR CONTACTO");
            Console.WriteLine("2.- BUSCAR CONTACTO");
            Console.WriteLine("3.- CREAR CONTACTO NUEVO");
            Console.WriteLine("4.- BORRAR CONTACTOS");
            Console.WriteLine("5.- GUARDAR CONTACTOS");
            Console.WriteLine("6.- SALIR");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
        static void BuscarContacto()
        {
            Console.WriteLine("-----Buscar Contacto-----");
            Console.WriteLine("1.- Por Nombre");
            Console.WriteLine("2.- Por Telefono");
            Console.WriteLine("2.- Volver");
            bool finBuscar = false;
            while (!finBuscar)
            {
                int opcion = obtenerOpcion("Opcion: ");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca el nombre a buscar: ");
                        List<Contacto> encontradosNombre = AgendaContactos.BuscarContactosPorNombre(Console.ReadLine());
                        if (encontradosNombre.Count > 0 )
                        {
                            Console.WriteLine("***** CONTACTOS ENCONTRADOS *****");
                            foreach (Contacto  contacto in encontradosNombre )
                            {
                                contacto.MostrarContacto();
                                Console.WriteLine("**********************************");
                            }
                        } 
                        else
                        {
                            Console.WriteLine("INFO: No se han encontrado contactos con ese nombre.");
                        }
                        finBuscar = true;
                        break;
                    case 2:
                        Console.WriteLine("Introduzca el telefono a buscar: ");
                        List<Contacto> encontradosTelefono = AgendaContactos.BuscarContactosPorTelefono(Console.ReadLine());
                        if (encontradosTelefono.Count > 0)
                        {
                            Console.WriteLine("***** CONTACTOS ENCONTRADOS *****");
                            foreach (Contacto contacto in encontradosTelefono)
                            {
                                contacto.MostrarContacto();
                                Console.WriteLine("**********************************");
                            }
                        }
                        else
                        {
                            Console.WriteLine("INFO: No se han encontrado contactos con ese telefono.");
                        }
                        finBuscar = true;
                        break;
                    case 3:
                        finBuscar = true;
                        break;
                }
            }
        }
        static void ProcesoCrearContacto()
        {
            Contacto contacto = new Contacto();
            Console.WriteLine("Introduzca el Nombre: ");
            contacto.SetNombre(Console.ReadLine());
            Console.WriteLine("Introduzca el Apellido: ");
            contacto.SetApellido(Console.ReadLine());
            Console.WriteLine("Introduzca la Fecha de Nacimiento");
            contacto.SetFechaNacimiento(Console.ReadLine ());
            Console.WriteLine("Introduzca el Numero de Telefono Fijo: ");
            contacto.SetTelefonoFijo(Console.ReadLine());
            Console.WriteLine("Introduzca el Numero de Teledono Movil: ");
            contacto.SetTelefonoMovil(Console.ReadLine());
            Console.WriteLine("Introduzca el Numero de Telefono del Trabajo: ");
            contacto.SetTelefonoTrabajo(Console.ReadLine());
            Console.WriteLine("Introduzca la Calle: ");
            contacto.SetCalle(Console.ReadLine ());
            Console.WriteLine("Introduzca el Piso: ");
            contacto.SetPiso(Console.ReadLine ());
            Console.WriteLine("Introduzca la Ciudad: ");
            contacto.SetCiudad(Console.ReadLine());
            Console.WriteLine("Introduzca el Codigo Postal: ");
            contacto.SetCodigoPostal(Console.ReadLine());
            Console.WriteLine("Introduzca el  E-mail: ");
            contacto.SetEmail(Console.ReadLine());
            AgendaContactos.CrearNuevoContacto(contacto);
        }
        static void BorrarContacto()
        {
            Console.WriteLine("----- Buscar Contacto para borrar -----");
            Console.WriteLine("1.- Por Nombre");
            Console.WriteLine("2.- Por Telefono");
            Console.WriteLine("3.- volver");
            bool finBuscar = false;
            while (!finBuscar )
            {
                int opcion = obtenerOpcion("Opcion: ");
                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca el Nombre: ");
                        AgendaContactos.BorrarContactoPorNombre(Console.ReadLine());
                        finBuscar = true;
                        break;
                    case 2:
                        Console.Write("Introduzca el Numero de Telefono: ");
                        AgendaContactos.BorrarContactoPorTelefono(Console.ReadLine());
                        finBuscar = true;
                        break;
                    case 3:
                        finBuscar = true;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            AgendaContactos = new Agenda("Agenda1.txt");
            if(!AgendaContactos.CargarContactos())
            {
                Console.WriteLine("ERROR: No se pueden cargar los contactos del fichero.");
                bool fin = false;
                while (!fin)
                {
                    MostrarMenu();
                    switch (obtenerOpcion ("Opcion: "))
                    {
                        case 1:
                            AgendaContactos.MostarAgenda();
                            break;
                        case 2:
                            BuscarContacto();
                            break;
                        case 3:
                            ProcesoCrearContacto();
                            break;
                        case 4:
                            BorrarContacto();
                            break;
                        case 5:
                            AgendaContactos.GuardarContacto();
                            break;
                        case 6:
                            fin = true;
                            break;
                    }
                }
            }
            Console.WriteLine("---------- F I N  D E L  P R O G R A M A ----------");
            Console.ReadLine();
        }
    }
}
