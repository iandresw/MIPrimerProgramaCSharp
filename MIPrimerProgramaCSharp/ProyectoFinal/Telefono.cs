using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoFinal
{
    class Telefono
    {
        string TelefonoFijo;
        string TelefonoMovil;
        string TelfonoTrabajo;

        public Telefono()
        {
            TelefonoFijo = "";
            TelefonoMovil = "";
            TelfonoTrabajo = "";
        }

        public void SetTelefonoFijo(string telefonoFijo)
        {
            TelefonoFijo = telefonoFijo;
        }
        public string GetTelefonoFijo()
        {
            return TelefonoFijo;
        }
        public void SetTelefonoMovil(string telefonoMovil)
        {
            TelefonoMovil = telefonoMovil;
        }
        public string GetTelefonoMovil()
        {
            return TelefonoMovil;
        }
        public void SetTelefonoTrabajo(string telefonoTrabajo)
        {
            TelfonoTrabajo = telefonoTrabajo;
        }
        public string GetTelefonoTrabajo()
        {
            return TelfonoTrabajo;
        }
    }

}
