namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input\nPlease enter integer Number: ");
            }

            Console.WriteLine($"\nMultiplication table {number}:");
            for (int j = 1; j <= 12; j++)
            {
                Console.WriteLine($"{number} x {j} = {number * j}");
            }
        }
    }
}
