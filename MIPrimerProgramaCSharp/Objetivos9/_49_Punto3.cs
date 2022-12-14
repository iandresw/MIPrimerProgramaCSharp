using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos9
{
    class _49_Punto3
    {
        int X;
        int Y;

        public _49_Punto3(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void SetX(int x)
        {
            X = x;
        }
        public int GetX()
        {
            return X;
        }
        public void SetY(int y)
        {
            Y = y;
        }
        public int GetY()
        {
            return Y;
        }
        public void MostrarPunto()
        {
            Console.WriteLine("El Punto es {0} y {1}", X, Y);
        }
    }
}
