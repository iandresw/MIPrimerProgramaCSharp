using System;



namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _37_BuclesAnidadosWhileYFor
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<3)
            {
                for (int j = 0; j<5; j++)
                {
                    Console.WriteLine("Item 1  {0}, Item 2 {1} ",i,j);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
