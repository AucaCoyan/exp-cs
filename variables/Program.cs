using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            Console.WriteLine(num1 + num2);
            // or
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + num1 + num2);
            // prints The sum of13 and 5 is 135
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1 + num2));
            // prints The sum of13 and 5 is 18

            // floats (doubles)

            double d1 = 3;
            // cast is done by:
            int d2_result = (int)(d1 / num2);

            Console.WriteLine(d1 + " divided by " + num2 + " is " + (d1 / num2));
            // this writes ok 0.6
        }
    }
}