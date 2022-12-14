using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos9
{
    class _50_Triangulo
    {
        _46_Punto P1;
        _46_Punto P2;
        _46_Punto P3;

        public _50_Triangulo(_46_Punto p1, _46_Punto p2, _46_Punto p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;

        }
        public void MostrarTriangulo()
        {
            Console.WriteLine("El traingulo esta compuesto por los siguientes puntos");
            P1.MostrarPunto();
            P2.MostrarPunto();
            P3.MostrarPunto();
        }
    }
}
