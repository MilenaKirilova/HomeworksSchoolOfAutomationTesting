namespace Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number between (-1000 and 999): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < -1000 || n > 999)
            {
                Console.Write("Invalid input. Please enter a number between (-1000 and 999): ");
            }

            for (int i = n; i <= 999; i++)
            {
                if (i <= 0)
                {
                    continue;
                }
                else if (i % 2 == 0) 
                {
                    Console.Write($"{i}, ");
                }
                    
            }
        }
    }
}
