using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos10
{
    class Programa1
    {
        static void Main(string[] args)
        {
            Lavadora lavadora = new Lavadora();
            lavadora.SetRPM(1200);
            lavadora.SetKilos(7);
            lavadora.setTension(220);
            lavadora.Encender();
            lavadora.Mostrar();


            Microondas microondas = new Microondas();
            microondas.SetPotenciaMax(800);
            microondas.setTension(220);
            microondas.SetGrill(true);
            microondas.Apagar();
            microondas.Mostrar();




            Console.ReadLine();


        }
    }
}
