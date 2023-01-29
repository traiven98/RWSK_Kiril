using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSpr
{
    internal class ReadFile
    {
        string filepath = "";
        List<int> numbers = new List<int>();

        public void SetFilepath(string path)
        {
            filepath = path;
        }

        public int[] GetNumbers()
        {
            using (StreamReader sr = new StreamReader(filepath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // Split the line into words
                    string[] words = line.Split();
                    // Iterate through each word
                    foreach (string word in words)
                    {
                        // Check if the word is a number
                        if (int.TryParse(word, out int number))
                        {
                            // If it is, add it to the list of numbers
                            numbers.Add(number);
                        }
                    }
                }
            }
            return numbers.ToArray();
        }

    }
}
