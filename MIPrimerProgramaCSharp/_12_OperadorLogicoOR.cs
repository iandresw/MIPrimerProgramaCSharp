using System;


namespace MIPrimerProgramaCSharp
{
    class _12_OperadorLogicoOR
    {
        static void Main(string[] args)
        {
            bool valueTrue = true;
            bool valueFalse = false;

            Console.WriteLine("True OR True = " + (valueTrue || valueTrue));
            Console.WriteLine("True OR False = " + (valueTrue || valueFalse));
            Console.WriteLine("False OR False = " + (valueFalse || valueFalse));
            Console.ReadLine();

        }
    }
}
