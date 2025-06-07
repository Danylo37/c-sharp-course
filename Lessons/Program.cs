using System;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;

            Console.WriteLine("Enter the first number: ");

            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("Enter the second number: ");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Sum is " + result);
        }
    }
}
