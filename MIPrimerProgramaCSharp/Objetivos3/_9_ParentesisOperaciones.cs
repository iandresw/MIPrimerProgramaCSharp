using System;


namespace MIPrimerProgramaCSharp.Objetivos3
{
    class _9_ParentesisOperaciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########## USO DE PARENTESIS ###########");

            Console.WriteLine("Primer Numero (Entero): ");
            int numero1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Segundo numero (Entero): ");
            int numero2 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Tercer numero (Entero): ");
            int numero3 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Cuarto numero (Entero): ");
            int numero4 = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine();

            int resultado1 = (numero1 * numero2) + numero3 / numero4;
            int resultado2 = numero1 * (numero2 + numero3 / numero4);
            int resultado3 = numero1 * (numero2 + numero3) / numero4;

            Console.WriteLine("Resultado " + "("+numero1+"*"+numero2+")"+"+"+numero3+"/"+numero4+"="+resultado1);
            Console.WriteLine("Resultado " + numero1+"*"+"("+numero2+"+"+numero3+"/"+numero4+")"+"="+resultado2);
            Console.WriteLine("Resultado " + numero1 +"*"+"("+numero2+"+"+numero3+")/"+numero4 +"="+resultado3);

            
            Console.ReadLine();
        }
    }
}
