using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorConsole_App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Since first lecture we are not covering exception handeling.

            Console.WriteLine("Simple Calculator App");
            Console.WriteLine("Enter large number:");
            Double input_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter small number:");
            Double input_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add or Subtract");
            string operation = Console.ReadLine();
            Double retval = 0;

            if (operation == "add")
            {
                retval = input_one + input_two;
            }
            if (operation == "subtract")
            {
                retval = input_one - input_two;
            }
        
            Console.WriteLine("Calculated amount:" + Convert.ToString(retval));
            Console.ReadKey();
        }

    }
}
