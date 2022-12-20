using System;


namespace MIPrimerProgramaCSharp.ProyectoFinal
{
    class Direccion
    {
        string Calle;
        string Piso;
        string Ciudad;
        string CodigoPostal;

        public Direccion()
        {
            Calle = "";
            Piso = "";
            Ciudad = "";
            CodigoPostal = "";
        }

        public void SetCalle(string calle)
        {
            Calle = calle;
        }
        public string GetCalle()
        {
            return Calle;
        }
        public void SetPiso(string piso)
        {
            Piso = piso;
        }
        public string GetPiso()
        {
            return Piso;
        }
        public void SetCiudad(string ciudad)
        {
            Ciudad = ciudad;
        }
        public string GetCiudad()
        {
            return Ciudad;
        }
        public void SetCodigoPostal(string codigoPostal)
        {
            CodigoPostal = codigoPostal;
        }
        public string GetCodigoPostal()
        {
            return CodigoPostal;
        }
    }
}
