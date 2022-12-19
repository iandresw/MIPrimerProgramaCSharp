using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos12
{
    class Fichero2
    {
        static void Main(string[] args)
        {
            string path = "prueba.txt";
            if (File.Exists (path ))
            {
                Console.WriteLine("----Fichero encontrado---\n");
                try
                {
                    using (StreamReader  sr = new StreamReader (path ))
                        
                    {
                        while (!sr.EndOfStream)
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: "+ ex.Message);
                }
            }
            else
                Console.WriteLine("ERROR: El fichero no existe en la ruta especificada");
            Console.ReadLine();
        }
    }
}
