using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _41_BuclesForEachDiccionario
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> numeros = new Dictionary<int, string>();
            numeros.Add(1, "Uno");
            numeros.Add(2, "Dos");
            numeros.Add(3, "Tres");
            numeros.Add(4, "Cuatro");
            numeros.Add(5, "Cinco");
            foreach (KeyValuePair<int, string> valor in numeros)
            {
                Console.WriteLine("{0} -->> {1}", valor.Key, valor.Value );
            }
            Console.ReadLine();
        }
    }
}
