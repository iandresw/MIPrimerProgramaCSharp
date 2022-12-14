using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos8
{
    class _44_FuncionSuma
    {
        static int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---Sumar---");
            Console.WriteLine("Ingrese el primer sumando");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo sumando");
            int sum2 = Convert.ToInt32(Console.ReadLine());
            int resultado = Sumar(sum1 , sum2);
            Console.WriteLine("El resultado de sumar {0} y {1} es {2}",sum1,sum2,resultado);
            Console.ReadLine();
        }
    }
}
