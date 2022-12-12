using System;


namespace MIPrimerProgramaCSharp
{
    class _11_OperadorLogicoAND
    {
        static void Main(string[] args)
        {
            bool valueTrue = true;
            bool valueFalse = false;

            Console.WriteLine("True AND True = "+(valueTrue && valueTrue));
            Console.WriteLine("True AND False = " + (valueTrue && valueFalse));
            Console.WriteLine("False AND False = " + (valueFalse && valueFalse));
            Console.ReadLine();

        }
    }
}
