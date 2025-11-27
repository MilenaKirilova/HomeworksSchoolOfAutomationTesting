namespace NumbersFrom1toNWithWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a positive number greater than 100: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 100)
            {
                Console.Write("Invalid input. Please enter a positive number greater than 100: ");
            }
            int counter = 1;
            while (counter <= number)
            {
                Console.Write(counter);
                if (counter < number)
                {
                    Console.Write(", ");
                }
                counter++;
            }
        }
    }
}
