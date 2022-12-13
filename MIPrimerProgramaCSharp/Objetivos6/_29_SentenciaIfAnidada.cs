using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos6
{
    class _29_SentenciaIfAnidada
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un numero entero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca otro numero entero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("Resultado compracion: el primer numero es mayor que el segundo numero");
            }
            else
            {
                if (numero2 > numero1)
                {
                    Console.WriteLine("Resultado compracion: el segundo numero es mayor que el primer numero");
                }
                else
                {
                    Console.WriteLine("Resultado compracion: ambos numeros son iguales");
                }
            }
            Console.ReadLine();
        }
    }
}
