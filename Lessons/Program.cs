using System;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5.9fsddgw";

            try
            {
                double a = double.Parse(str);
                Console.WriteLine(a);
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException: " + e.Message);
            }
        }
    }
}
