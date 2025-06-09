using System;
using System.Linq;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Enumerable.Range(5, 10).ToArray();

            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            arr = Enumerable.Repeat(1, 10).ToArray();

            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
