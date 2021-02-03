using System;

namespace test_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            Double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);

        }
    }
}