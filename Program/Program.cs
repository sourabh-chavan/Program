namespace Program
{
    internal class Program
    {
        static void Main()
        {
            string input = "MY NAME IS SOURABH P C";

            double averageLength = CalculateAverageWordLength(input);
            double roundedAverage = Math.Round(averageLength, 3);

            Console.WriteLine($"Average word length: {roundedAverage}");
        }

        public static double CalculateAverageWordLength(string input)
        {
            string[] words = input.Split(' ');
            int totalLength = 0;

            foreach (string word in words)
            {
                totalLength += word.Length;
            }

            return (double)totalLength / words.Length;
        }
    }
}