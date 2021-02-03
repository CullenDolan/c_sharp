using System;

namespace test_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cube_return = CubeNumber(3);
            Console.WriteLine(cube_return);
        }
        // method - performs a specific task w/ returns
        static int CubeNumber(int number)
        {
            int result = number * number * number;
            return result;
        }
    }
}