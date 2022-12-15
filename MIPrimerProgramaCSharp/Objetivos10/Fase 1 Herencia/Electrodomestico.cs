using System;


namespace MIPrimerProgramaCSharp.Objetivos10
{
    class Electrodomestico
    {
        bool Encendido;
        int Tension;
        public Electrodomestico()
        {
            Encendido = true;
            Tension = 220;
        }
        public void Encender()
        {
            Encendido = true;
        }
        public void Apagar()
        {
            Encendido = false;
        }
        public bool EstaEncendido()
        {
            return Encendido;
        }
        public void setTension(int tension)
        {
            Tension = tension; 
        } 
        public int GetTension()
        {
            return Tension;
        }
    }
}
