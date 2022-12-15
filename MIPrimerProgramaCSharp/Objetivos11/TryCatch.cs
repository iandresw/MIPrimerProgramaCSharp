using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos11
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------P R O G R A M A   I N I C I A D O-----------");
            try
            {
                int valor1 = 3;
                int valor2 = 0;
                int resultado = valor1 / valor2;
                Console.WriteLine(resultado);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Error: Divicion por cero ({0})", ex.Message);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR General {0}" , ex.Message);
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("----P R O G R A M A   F I N A L I Z A D O------");
            }
            Console.ReadLine();
        }

    }
}
