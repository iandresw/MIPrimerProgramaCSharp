using System;


namespace MIPrimerProgramaCSharp.Objetivos9
{
    class _46_Punto
    {
        int X;
        int Y;
        public _46_Punto(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MostrarPunto()
        {
            Console.WriteLine("El punto es {0},{1}",X,Y);
        }
    }
}
