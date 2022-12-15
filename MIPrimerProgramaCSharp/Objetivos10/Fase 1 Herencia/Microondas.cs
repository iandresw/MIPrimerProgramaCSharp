using System;


namespace MIPrimerProgramaCSharp.Objetivos10
{
    class Microondas : Electrodomestico 
    {
        int PotenciaMax;
        bool Grill;
        public Microondas()
        {
            PotenciaMax = 0;
            Grill = false;
        }
        public void SetPotenciaMax(int potenciaMax)
        {
            PotenciaMax = potenciaMax;
        }
        public int GetPotenciaMax()
        {
            return PotenciaMax;
        }
        public void SetGrill(bool grill)
        {
            Grill = grill;
        }
        public bool GetGrill()
        {
            return Grill;
        }
        public void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("----- M I C R O O N D A S ------");
            Console.WriteLine();
            Console.WriteLine("Potencia Maxima {0}", PotenciaMax );
            Console.WriteLine("Tiene Grill: {0}", Grill );
            Console.WriteLine("Tension: {0}", GetTension());
            if (EstaEncendido())
            {
                Console.WriteLine("El Microondas esta encendid0");
            }
            else
            {
                Console.WriteLine("El Microondas esta apagad0");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

        }
    }
}
