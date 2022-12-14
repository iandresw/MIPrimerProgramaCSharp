using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos8
{
    class _45_FuncionesAnidadas
    {
        static int SolicitarNumero()
        {
            Console.WriteLine("Introduzaca un numero");
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }

        static void Sumar()
        {
            int valor1 = SolicitarNumero();
            int valor2 = SolicitarNumero();
            int resultado = valor1 + valor2;
            Console.WriteLine("El resultado de sumar {0} y {1} es igual a: {2}",valor1, valor2 ,resultado);
        }

        static void Main(string[] args)
        {
            Sumar();
            Console.ReadLine();

        }
            
    }
}
