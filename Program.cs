using System;

namespace test_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            string myName = "Cullen" ;
            char grade = 'A'; // can only be one character
            float float_val = 3.1415F; // least precise
            double doub_val = 3.1415;
            decimal dec_val = 3.1415M; // most precise
            bool isMale = true;
            Console.WriteLine("My name is " + myName + " I am " + age + " years old.");
            Console.WriteLine(grade);
            Console.WriteLine(float_val);
            Console.WriteLine(doub_val);
            Console.WriteLine(dec_val);
            Console.WriteLine(isMale);

        }
    }
}