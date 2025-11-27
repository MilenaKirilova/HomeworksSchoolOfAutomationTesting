namespace _11._PrimaryNumbers1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a positive number greater than 1: ");

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
            {
                Console.Write("Invalid input. Please enter a positive number greater than 1: ");
            }

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
