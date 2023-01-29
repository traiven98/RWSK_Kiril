using RWSpr;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace MyConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filename = "D:\\Chillzone\\Job\\RWS\\Project1\\Project1\\inputs\\example1.txt";
            ReadFile readFile = new ReadFile();
            readFile.SetFilepath(filename);
            int[] numbers = { };
            try
            {
                numbers = readFile.GetNumbers();
            }
            catch
            {
                Console.WriteLine("texfile is empty");
            }
            FindSequence findSequence = new FindSequence();
            findSequence.SetNumbers(numbers);
            List<int> bestSequence = findSequence.FindBestSequence();

            if (bestSequence.Count > 0)
            {
                foreach (int number in bestSequence)
                {
                    Console.Write(number + " ");
                }
            }
            else
            {
                Console.WriteLine("No sequence found.");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}