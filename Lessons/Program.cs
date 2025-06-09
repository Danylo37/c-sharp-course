using System;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string anotherOne;

            while (true)
            {
                Console.Clear();

                double a, b;
                string action;

                try
                {
                    Console.WriteLine("Enter the first number");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number");
                    Console.ReadLine();
                    continue;
                }


                Console.WriteLine("Enter an action: '+' '-' '*' '/'");

                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                        break;
                    case "/":
                        {
                            if (b == 0) Console.WriteLine("Impossible operation");
                            else Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid action");
                        break;
                }

                Console.WriteLine("Another one? (yes/no)");

                anotherOne = Console.ReadLine();

                if (anotherOne.ToLower() == "yes")
                {
                    continue;
                }
                else if (anotherOne.ToLower() == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I guess it's 'no'");
                    break;
                }
            }

            
        }
    }
}
