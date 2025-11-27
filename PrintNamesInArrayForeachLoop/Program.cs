namespace PrintNamesInArrayForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alice", "Bob", "Charlie", "Diana", "Rachel", "Ross", "Monica", "Raphael" };
            foreach (string name in names)
            {
                Console.Write($"{name}, ");
            }
        }
    }
}
