using System;


namespace MIPrimerProgramaCSharp.Objetivos11
{
    class ControlandoExcepcionescs
    {
        static void Main(string[] args)
        {
            try
            {
                int valor1 = 3;
                int valor2 = 0;
                int resultado = valor1 / valor2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Divicion por cero");
            }
            Console.ReadLine();
        }
    }
}
