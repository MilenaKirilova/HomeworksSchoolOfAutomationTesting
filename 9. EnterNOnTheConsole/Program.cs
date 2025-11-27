namespace _9._EnterNOnTheConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            do
            {
                Console.Write("Enter 'N' to exit: ");
                input = Console.ReadLine();
            }
            while (input != "N");
        }
    }
}
