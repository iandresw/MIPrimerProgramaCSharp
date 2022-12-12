using System;


namespace MIPrimerProgramaCSharp
{
    class _2_AnadirTextVaria
    {
        static void Main(string[] args)
        {
            int edadUsuario = 35;
            string nombreUsuario = "Alfredo";
            Console.WriteLine("Hola me llamo " + nombreUsuario + " y tengo " + edadUsuario + " años ");
            Console.WriteLine("Hola Me llamo {0} y tengo {1} años", nombreUsuario,  edadUsuario );
            Console.WriteLine("Hola me llamo " + nombreUsuario + ".\nTengo "+ edadUsuario + " años ");
            Console.WriteLine("Hola me llamo \"{0}\" y tengo \"{1}\" años", nombreUsuario, edadUsuario);
            Console.ReadLine();
        }
    }
}
