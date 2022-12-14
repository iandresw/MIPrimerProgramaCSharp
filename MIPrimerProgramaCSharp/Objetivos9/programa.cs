using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos9
{
    class programa
    {
        static void Main(string[] args)
        {

            _4_Punto();


        }
        static void _0_Punto()
        {
            Console.WriteLine("clase _46_Punto");
            _46_Punto p1 = new _46_Punto(4, 16);
            _46_Punto p2 = new _46_Punto(5, 12);
            _46_Punto p3 = new _46_Punto(6, 11);
            _46_Punto p4 = new _46_Punto(7, 10);
            _46_Punto p5 = new _46_Punto(8, 9);
            Console.WriteLine(" Fin clase _46_Punto");
            Console.WriteLine();
            Console.WriteLine();
            p5.MostrarPunto();
            Console.ReadLine();
        }

        static void _1_Punto()
        {
            Console.WriteLine("clase _47_Punto2");
            _47_Punto2 p1 = new _47_Punto2(4,4);
            p1.MostrarPunto();
            p1.SetX(9);
            p1.SetY(4);
            p1.MostrarPunto();
            
            Console.WriteLine(" Fin clase _47_Punto2");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
        static void _2_Punto()
        {
            _48_AtributosPublicos p1 = new _48_AtributosPublicos();
            p1.MostrarPunto();
            //Se puede acceder a X y Y desde aqui como esta definida por una variable publica, 
            //si no se define como publica por defecto sera privada
            p1.X = 9;
            p1.Y = 4;
            p1.MostrarPunto();
            Console.ReadLine();
        }
        static void _3_Punto()
        {
            _49_Punto3  p1 = new _49_Punto3(0,0);
            p1.MostrarPunto();
         
            p1.SetX (9);
            p1.SetY (4);
            Console.WriteLine("el valor de X es :" + p1.GetX());
            Console.WriteLine("el valor de Y es :" + p1.GetY());
            Console.ReadLine();
        }
        static void _4_Punto()
        {
            _46_Punto p1 = new _46_Punto(0, 5);
            _46_Punto p2 = new _46_Punto(1, 4);
            _46_Punto p3 = new _46_Punto(2, 3);
            _50_Triangulo triangulo = new Objetivos9._50_Triangulo(p1, p2, p3);
            triangulo.MostrarTriangulo();
            Console.ReadLine();
        }
    }
}
