using System;
using System.IO;

namespace MIPrimerProgramaCSharp.Objetivos12
{
    class FicherosEscribirEnTXT
    {
        static void Main(string[] args)
        {
            string path = "ficheros.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Linea 1 del fichero");
                sw.WriteLine("Linea 2 del fichero");
                sw.WriteLine("Linea 3 del fichero");
                sw.WriteLine("Linea 4 del fichero");
                sw.WriteLine("Linea 5 del fichero");
                sw.Close();
            }          
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
