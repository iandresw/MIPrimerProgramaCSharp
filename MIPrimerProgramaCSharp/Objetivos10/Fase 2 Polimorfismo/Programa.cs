using System;
using System.Collections.Generic;

namespace MIPrimerProgramaCSharp.Objetivos10.Fase_2_Polimorfismo
{
    class Programa
    {
        static void Main(string[] args)
        {
            List<Negocio> negocios = new List<Negocio>();
            Restaurante restaurante = new Restaurante();
            restaurante.SetPropietario("Alfredo Moreno");
            restaurante.SetDireccion("Calle falsa 123");
            restaurante.SetTelefono("32321996");
            restaurante.SetTenedores(4);
            restaurante.SetHoraApertura(12);
            negocios.Add(restaurante);
            Negocio  negocio = new Negocio();
            negocio.SetPropietario("Sheila Contreras");
            negocio.SetDireccion("Calle Broma 123");
            negocio.SetTelefono("666555444");
            negocios.Add(negocio);
            Hotel hotel = new Hotel();
            hotel.SetPropietario("Andres Domitorios");
            hotel.SetDireccion("Calle Camas 123");
            hotel.SetTelefono("898989898");
            hotel.SetNumEstrellas(4);
            hotel.SetNumHabitaciones(100);
            negocios.Add(hotel);
            foreach (Negocio elemento in negocios)
            {
                elemento.Mostarar();
            }
            Console.ReadLine();
        }
    }
}
