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
            Console.WriteLine(myName.Length); //examples of attribute
            Console.WriteLine(myName.ToUpper()); // method
            Console.WriteLine(myName[5]); // string index
            Console.WriteLine(myName.IndexOf("u")); // find where something starts
            Console.WriteLine(Math.Floor(-4.55)); //another method that has math operations


        }
    }
}