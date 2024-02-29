using System.Runtime.ExceptionServices;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1

            Console.Write("Enter row width: ");
            int rowWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter number of rows: ");
            int rowAmount = int.Parse(Console.ReadLine());

            // Create nested for loop
            for (int i = 1; i < rowAmount; i++)
            {
                for (int j = 1; j < rowWidth; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}