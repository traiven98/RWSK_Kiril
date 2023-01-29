using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWSpr
{
    internal class FindSequence
    {
        int[] numbers = { };
        public void SetNumbers(int[] inputNumbers)
        {
            this.numbers = inputNumbers;
        }

        List<int> bestSequence = new List<int>();
        int bestSum = 10000000;
        int shortestLength = 999999999;

        public List<int> FindBestSequence()
        {
            List<int> bestSequence = new List<int>();
            int bestSum = 10000000;
            int shortestLength = 10000 + numbers.Length;
            //Find the sequence
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i; j < numbers.Length; j++)
                    {
                        int sum = 0;
                        List<int> sequence = new List<int>();
                        for (int k = i; k <= j; k++)
                        {
                            sum += numbers[k];
                            sequence.Add(numbers[k]);
                        }
                        if (sum % 4 == 0 && sequence.Count <= shortestLength && sequence.Count >= 2)
                        {
                            if (sequence.Count == shortestLength && sum < bestSum || sequence.Count < shortestLength)
                            {
                                bestSum = sum;
                                bestSequence = sequence;
                                shortestLength = sequence.Count;
                            }

                        }
                    }
                }

            }
            catch
            {; }

            return bestSequence;

        }
    }
}
