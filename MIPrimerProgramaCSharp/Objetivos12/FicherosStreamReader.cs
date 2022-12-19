using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos12
{
    class FicherosStreamReader
    {
        static void Main(string[] args)
        {
            string path = "Prueba.txt";
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
