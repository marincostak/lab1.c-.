using System;

namespace ConsoleApp1
{
    public class Program
    {
        static public int Example(int x)
        {
            int c = Convert.ToInt32(Math.Pow(x, 3)) - 4 * Convert.ToInt32(Math.Pow(x, 2)) + 5 * x + 9 + Convert.ToInt32(Math.Cos(x));
            Console.WriteLine(Math.Pow(x, 3) + " - " + 4 * Math.Pow(x, 2) + " + " + 5 * x + 9 + Math.Cos(x) + " = " +
            c.ToString());
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть ціле число");
            string S1 = Console.ReadLine();
            int x = int.Parse(S1);
            Example(x);
            Console.ReadLine();
        }
    }
}
