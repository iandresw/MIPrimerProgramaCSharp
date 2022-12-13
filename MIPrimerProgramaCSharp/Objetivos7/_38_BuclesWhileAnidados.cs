using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _38_BuclesWhileAnidados
    {
        static void Main(string args)
        {
            int i = 0;
            int j = 0;
            while(i<3)
            {
                j = 0;
                while(j<5)
                {
                    Console.WriteLine("item i = {0}, Item2 = {1}",i,j);
                    j++;
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
