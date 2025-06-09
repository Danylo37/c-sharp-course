using System;
using System.Linq;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10 };

            Console.WriteLine(arr.Length);

            Console.WriteLine(arr.Min());

            Console.WriteLine(arr.Where(x => x % 2 == 0).Sum());

            int[] arr_distinct = arr.Distinct().ToArray();

            foreach (int x in arr_distinct) Console.Write(x + ", ");
        }
    }
}
