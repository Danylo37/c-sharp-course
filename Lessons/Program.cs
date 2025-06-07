using System;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("You entered one.");
                    break;
                case 2:
                    Console.WriteLine("You entered two.");
                    break;
                case 3:
                    Console.WriteLine("You entered three.");
                    break;
                default:
                    Console.WriteLine("You entered a number other than one, two, or three.");
                    break;
            }
        }
    }
}
