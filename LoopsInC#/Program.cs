namespace LoopsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}");
                if (i < 10)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
