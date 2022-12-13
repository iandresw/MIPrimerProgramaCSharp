using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _34_BucleFor
    {
        static void Main(string[] args)
        {
            List<string> valores = new List<string> {"Perro", "Gato", "Pajaro", "Caballo" };
            for (int i = 0; i < valores.Count; i++)
            {
                Console.WriteLine(valores[i]);

            }
            Console.ReadLine();
        }
    }
}
