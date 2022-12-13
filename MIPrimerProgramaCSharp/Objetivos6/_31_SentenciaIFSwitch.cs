using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos6
{
    class _31_SentenciaIFSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigos Promocionales: ORO, PLATA, BRONCE ó PLATINO");
            Console.WriteLine("Introduzca su codigo promocional para saber su descuento: ");
            string codigo = Console.ReadLine();
            if (codigo == "ORO")
            {
                Console.WriteLine("El descuentoaplicado es del 25% ");
            }
            else
            {
                if (codigo == "PLATA")
                {
                    Console.WriteLine("El descuentoaplicado es del 15% ");
                }
                else
                {
                    if (codigo == "BRONCE")
                    {
                        Console.WriteLine("El descuentoaplicado es del 5% ");
                    }
                    else
                    {
                        if (codigo == "PLATINO")
                        {
                            Console.WriteLine("El descuentoaplicado es del 45% ");
                        }
                        else
                        {
                            Console.WriteLine("CODIGO PROMOCIONAL NO VALIDO ");
                        }
                    }
                }
            }
        }
    }
}
