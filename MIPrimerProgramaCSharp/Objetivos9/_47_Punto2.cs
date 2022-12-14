using System;


namespace MIPrimerProgramaCSharp.Objetivos9
{
    class _47_Punto2
    {
        int X;
        int Y;

        public _47_Punto2 (int x , int y)
        {
            X = x;
            Y = y;
        }

        public void SetX(int x)
        {
            X = x;
        }
        public void SetY(int y)
        {
            Y = y;
        }
        public void MostrarPunto()
        {
            Console.WriteLine("El Punto es {0} y {1}", X, Y);
        }
    }
}
