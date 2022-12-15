using System;


namespace MIPrimerProgramaCSharp.Objetivos10
{
    class Lavadora : Electrodomestico 
    {
        int RPM;
        int Kilos;
        public Lavadora()
        {
            RPM = 0;
            Kilos = 0;
        }

        public void SetRPM(int rpm)
        {
            RPM = rpm;
        }
        public int GetRPM()
        {
            return RPM;
        }
        public void SetKilos(int kilos)
        {
            Kilos = kilos;
        }
        public int GetKilos()
        {
            return Kilos;
        }
        public void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("----- L A V A D O R A ------");
            Console.WriteLine();
            Console.WriteLine("RPM: {0}",RPM);
            Console.WriteLine("Kilos: {0}", Kilos);
            Console.WriteLine("Tension: {0}", GetTension ());
            if (EstaEncendido())
            {
                Console.WriteLine("La lavadora esta encendida");
            }
            else
            {
                Console.WriteLine("La lavadora esta apagada"); 
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

        }
    }
}
