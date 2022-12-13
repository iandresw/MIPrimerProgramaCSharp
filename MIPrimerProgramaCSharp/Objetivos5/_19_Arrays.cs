using System;


namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _19_Arrays
    {
        static void Main(string [] args)
        {
            string cadenaEspacios = "En un luga de la mancha";
            string[] arrayCadenas = cadenaEspacios.Split(' ');
            Console.WriteLine("Cadena original: "+ cadenaEspacios);
            Console.WriteLine(arrayCadenas[0]);
            Console.WriteLine(arrayCadenas[1]);
            Console.WriteLine(arrayCadenas[2]);
            Console.WriteLine(arrayCadenas[3]);
            Console.WriteLine(arrayCadenas[4]);
            Console.WriteLine(arrayCadenas[5]);
            Console.WriteLine();
            string cadenaSeparadores = "casa,perro.gato.pajaro,balon";
            char[] separadores = { ',', '.' };
            arrayCadenas = cadenaSeparadores.Split(separadores);
            Console.WriteLine("cadena original: " + cadenaSeparadores );
            Console.WriteLine(arrayCadenas[0]);
            Console.WriteLine(arrayCadenas[1]);
            Console.WriteLine(arrayCadenas[2]);
            Console.WriteLine(arrayCadenas[3]);
            Console.WriteLine(arrayCadenas[4]);
            Console.ReadLine();
        }
    }
}
