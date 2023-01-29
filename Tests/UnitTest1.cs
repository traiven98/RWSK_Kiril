using RWSpr;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void FindNumbersFromFile1()
        {      
            ReadFile readFile = new ReadFile();
            readFile.SetFilepath("D:\\Chillzone\\Job\\RWS\\Project1\\Project1\\inputs\\mytest.txt");
            int[] expectedPrompt = { 1, 2, 3 };

            var outputLines = readFile.GetNumbers();
            Assert.AreEqual(expectedPrompt, outputLines);


        }
        public void FindTrueSequence1()
        {
            int[] numbers = { 1, 3, 3, 4 };
            List<int> expectedPrompt = new List<int> { 1, 3 };
            FindSequence findSequence = new FindSequence();
            findSequence.SetNumbers(numbers);

            List<int> outputLines = findSequence.FindBestSequence();

            Assert.AreEqual(expectedPrompt, outputLines);
        }
    }
}