using System;


namespace MIPrimerProgramaCSharp.Objetivos3
{
    class _14_OperadoresRelacionales
    {
        static void Main(string[] arg) {
            int numero1 = 0;
            int numero2 = 0;

            Console.Write("Introduce un numero entero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un numero entero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero1 + ">" + numero2 + ":" + (numero1 > numero2));
            Console.WriteLine(numero1 + "=>" + numero2 + ":" +  (numero1 >= numero2));
            Console.WriteLine(numero1 + "<" + numero2 + ":" + (numero1 < numero2));
            Console.WriteLine(numero1 + "<=" + numero2 + ":" + (numero1 <= numero2));
            Console.WriteLine(numero1 + "==" + numero2 + ":" + (numero1 == numero2));
            Console.WriteLine(numero1 + "!=" + numero2 + ":" + (numero1 != numero2));
            Console.ReadLine();
        }
    }
}
