using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _32_BuclesWhile
    {
        static void Main(string [] args)
        {
            List<int> valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int i = 0;
            bool recorrido = false;
            while (!recorrido )
            {
                Console.Write(valores[i]+ " ");
                i = i + 1;
                if (i == valores.Count )
                {
                    recorrido = true;
                }
            }
            Console.ReadLine();
        }
    }
}
