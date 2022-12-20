using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoFinal
{
    class Agenda
    {
        List<Contacto> ListaContactos;
        string Path;
        public Agenda (string path)
        {
            ListaContactos = new List<Contacto>();
            Path = path;
        }
        public bool CargarContactos()
        {
            if (File.Exists(Path))
            {
                ListaContactos.Clear();
                using (StreamReader  sr = new StreamReader (Path))
                {
                    while (!sr.EndOfStream )
                    {
                        string[] datos = sr.ReadLine().Split('#');
                        if(datos.Length == 11)
                        {
                            Contacto contacto = new Contacto();
                            contacto.SetNombre (datos[0]);
                            contacto.SetApellido(datos[1]);
                            contacto.SetFechaNacimiento (datos[2]);
                            contacto.SetTelefonoMovil (datos[3]);
                            contacto.SetTelefonoFijo (datos[4]);
                            contacto.SetTelefonoTrabajo (datos[5]);
                            contacto.SetCalle (datos[6]);
                            contacto.SetPiso (datos[7]);
                            contacto.SetCiudad (datos[8]);
                            contacto.SetCodigoPostal (datos[9]);
                            contacto.SetEmail (datos[10]);
                            ListaContactos.Add(contacto);
                        }
                    }
                    sr.Close();
                }
                Console.WriteLine("INFO: Se ha cargado un total de {0} contactos.", ListaContactos.Count);
                return true;
            }
            return false;
        }
        public void CrearNuevoContacto(Contacto contacto)
        {
            ListaContactos.Add(contacto);
        }
        public bool GuardarContacto()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path, false))
                {
                    foreach (Contacto contacto in ListaContactos)
                    {
                        sw.Write(contacto.GetNombre() + "#");
                        sw.Write(contacto.GetApellido() + "#");
                        sw.Write(contacto.GetFechaNacimiento () + "#");
                        sw.Write(contacto.GetTelefonoMovil () + "#");
                        sw.Write(contacto.GetTelefonoFijo () + "#");
                        sw.Write(contacto.GetTelefonoTrabajo () + "#");
                        sw.Write(contacto.GetCalle() + "#");
                        sw.Write(contacto.GetPiso () + "#");
                        sw.Write(contacto.GetCiudad () + "#");
                        sw.Write(contacto.GetCodigoPostal () + "#");
                        sw.Write(contacto.GetEmail() + "#");
                        
                    }
                    sw.Close();
                }
                Console.WriteLine("INFO: Contactos guardados correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex.Message);
            }
            return false;
        }
        public void MostarAgenda()
        {
            Console.WriteLine("--------A G E N D A ----------");
            Console.WriteLine();
            Console.WriteLine("Numero de contactos: {0} ", ListaContactos.Count);
            foreach (Contacto contacto in ListaContactos)
            {
                contacto.MostrarContacto();
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
            }
        }
        public List <Contacto> BuscarContactosPorNombre(string nombre)
        {
            List<Contacto> ListaEncontrados = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (contacto.GetNombre() == nombre)
                {
                    ListaEncontrados.Add(contacto);
                }
            }
            return ListaEncontrados;
        }
        public List<Contacto> BuscarContactosPorTelefono(string telefono)
        {
            List<Contacto> ListaEncontrados = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (contacto.GetTelefonoMovil() == telefono || contacto.GetTelefonoFijo()  == telefono || contacto.GetTelefonoTrabajo() == telefono)
                {
                    ListaEncontrados.Add(contacto);
                }
            }
            return ListaEncontrados;
        }




        public void BorrarContactoPorNombre(string nombre)
        {
            List<Contacto> ListaFinal = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (!(contacto.GetNombre() == nombre))
                {
                    ListaFinal.Add(contacto);

                }
                Console.WriteLine("INFO: se ha borrado {0} contactos " , ListaContactos.Count - ListaFinal.Count );
                ListaContactos = ListaFinal;
            }
            
        }

        public void BorrarContactoPorTelefono(string telefono)
        {
            List<Contacto> ListaFinal = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (!(contacto.GetTelefonoMovil() == telefono || contacto.GetTelefonoFijo() == telefono || contacto.GetTelefonoTrabajo() == telefono))
                {
                    ListaFinal.Add(contacto);

                }
                Console.WriteLine("INFO: se ha borrado {0} contactos ", ListaContactos.Count - ListaFinal.Count);
                ListaContactos = ListaFinal;
            }
        }
    }
}
