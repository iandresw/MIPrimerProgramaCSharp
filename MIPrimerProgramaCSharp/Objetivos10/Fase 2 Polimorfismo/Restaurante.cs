using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos10.Fase_2_Polimorfismo
{
    class Restaurante : Negocio
    {
        int Tenedores;
        int HoraApertura;
        public Restaurante()
        {
            Tenedores = 0;
            HoraApertura = 0;
        }
        public void SetTenedores(int tenedores)
        {
            Tenedores = tenedores;
        }
        public int GetTenedores()
        {
            return Tenedores;
        }
        public void SetHoraApertura(int horaApertura)
        {
            HoraApertura = horaApertura;
        }
        public int GetHoraApertura()
        {
            return HoraApertura;
        }
        public override void Mostarar()
        {
            Console.WriteLine();
            Console.WriteLine("----- R E S T A U R A N T E ------");
            Console.WriteLine();
            Console.WriteLine("Propietario: {0}", GetPropietario());
            Console.WriteLine("Direecion: {0}", GetDireccion());
            Console.WriteLine("Telefono: {0}", GetTelefono());
            Console.WriteLine("Numero de Tenedores: {0}", Tenedores );
            Console.WriteLine("Hora de apertura: {0}", HoraApertura );
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

        }
    }
}
