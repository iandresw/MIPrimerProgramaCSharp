using System;


namespace MIPrimerProgramaCSharp
{
    class _18_CadenaSubString
    {
        static void Main(string[] args)
        {
            string cadena = "1 de enero, 2 de febrero...";
            string fecha1 = cadena.Substring(0, 10);
            string fecha2 = cadena.Substring(12, 12);
            Console.WriteLine(cadena);
            Console.WriteLine(fecha1);
            Console.WriteLine(fecha2);
            Console.WriteLine();
            cadena = "   ¡San Fermin!    ";
            Console.WriteLine(cadena);
            Console.WriteLine(cadena.TrimStart());
            Console.WriteLine(cadena.TrimEnd());
            Console.WriteLine(cadena.Trim());
            Console.ReadLine();
        }
    }
}
