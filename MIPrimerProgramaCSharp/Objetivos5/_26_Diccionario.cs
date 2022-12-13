using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _26_Diccionario
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> diasIngles = new Dictionary<string, string>();
            diasIngles.Add("Lunes", "Monday");
            diasIngles.Add("Martes", "Tuesday");
            diasIngles.Add("Miercoles", "Wednesday");
            diasIngles.Add("Jueves", "Thursday");
            diasIngles.Add("Viernes", "Friday");
            diasIngles.Add("Sabado", "Saturday");
            diasIngles.Add("Domingo", "Sunday");
            Console.WriteLine("Numero de elementos del dicicionario: "+ diasIngles.Count );
            Console.WriteLine("Martes: " + diasIngles["Martes"]);
            Console.WriteLine("Sabado: " + diasIngles["Sabado"]);
            Console.WriteLine("¿Esta el viernes?: " + diasIngles.ContainsKey ("Viernes"));
            diasIngles.Remove("Viernes");
            Console.WriteLine("¿Esta el viernes?: " + diasIngles.ContainsKey("Viernes"));
            Console.WriteLine("¿Esta el Sunday?: " + diasIngles.ContainsValue ("Sunday"));
            Console.WriteLine("Numero de elementos en el diccionario: " + diasIngles.Count );
            diasIngles.Clear();
            Console.WriteLine("Numero de elementos del dicicionario: " + diasIngles.Count);
            Console.ReadLine();
        }
    }
}
