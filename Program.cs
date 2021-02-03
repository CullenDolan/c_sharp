using System;

namespace test_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(5));

        }
        // SWITCH STATEMENTS
        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            return dayName; 
        }
    }
}