using System;

namespace MIPrimerProgramaCSharp.Objetivos10.Fase_2_Polimorfismo
{
    class Hotel : Negocio 
    {
        int NumHabitaciones;
        int NumEstrellas;

        public Hotel()
        {
            NumHabitaciones = 0;
            NumEstrellas = 0;
        }

        public void SetNumHabitaciones(int numHabitaciones)
        {
            NumHabitaciones = numHabitaciones;
        }
        public int GetNumHabitacioneso()
        {
            return NumHabitaciones;
        }
        public void SetNumEstrellas(int numEstrellas)
        {
            NumEstrellas = numEstrellas;
        }
        public int GetNumEstrellas()
        {
            return NumEstrellas;
        }
        public override void Mostarar()
        {
            Console.WriteLine();
            Console.WriteLine("----- H O T E L ------");
            Console.WriteLine();
            Console.WriteLine("Propietario: {0}", GetPropietario());
            Console.WriteLine("Direecion: {0}", GetDireccion());
            Console.WriteLine("Telefono: {0}", GetTelefono());
            Console.WriteLine("Numero de Habitaciones: {0}",NumHabitaciones);
            Console.WriteLine("Numero de estrellas: {0}" ,NumEstrellas);
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

        }
    }
}
