using System.Text;

namespace MultiplicationTable1To5WithNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder[] table = new StringBuilder[5];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new StringBuilder();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    table[j-1].Append($"{i} * {j} = {i * j}\t");
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(table[i].ToString());
            }
        }
    }
}
