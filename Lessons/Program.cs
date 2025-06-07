using System;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5gfsdf";

            int a;

            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Conversion successful: " + a);
            }
            else
            {
                Console.WriteLine("Conversion failed. The string could not be parsed as an integer.");
            }
        }
    }
}
