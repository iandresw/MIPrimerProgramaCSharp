using System;


namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _20_ArraysMetodos
    {
        static void Main(string[] agrs)
        {
            int[] ArrayEnteros = { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine("Array Original: " + ArrayEnteros[0] + " " + ArrayEnteros[1] + " " + ArrayEnteros[2] + " " + ArrayEnteros[3] + " " + ArrayEnteros[4] + " " + ArrayEnteros[5]);
            ArrayEnteros[1] = 43;
            ArrayEnteros[4] = ArrayEnteros[0] - 3;
            Console.WriteLine("Numero de elementos: " + ArrayEnteros.Length);
            Console.WriteLine("Array actual operando: " + ArrayEnteros[0] +  ArrayEnteros[1] + " " + ArrayEnteros[2] + " " + ArrayEnteros[3] + " " + ArrayEnteros[4] + " " + ArrayEnteros[5]);
            Array.Sort(ArrayEnteros);
            Console.WriteLine("Ordenado " + ArrayEnteros[0] + " " + ArrayEnteros[1] +" " + ArrayEnteros[2] + " " + ArrayEnteros[3] + " " + ArrayEnteros[4] + " " + ArrayEnteros[5]);
            Array.Reverse(ArrayEnteros);
            Console.WriteLine("Reversa: " + ArrayEnteros[0] + " " + ArrayEnteros[1] + " " + ArrayEnteros[2] + " " + ArrayEnteros[3] + " " + ArrayEnteros[4] + " " + ArrayEnteros[5]);
            Console.WriteLine("¿Existe el elemento 90?: " + Array.IndexOf(ArrayEnteros, 90));
            Console.WriteLine("¿Existe el elemento 5?: " + Array.IndexOf(ArrayEnteros, 5));
            Console.ReadLine();
        }
    }   
}
