namespace Algoritmer.SpellingBees
{
    public static class SpellingBee
    {
        public static void Calculate(IConsole Console)
        {
            string letters = Console.ReadLine();
            char centerLetter = letters[0];

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                bool printWord = true;
                if (word.Length < 4)
                {
                    continue;
                }
                bool centerLetterFound = false;
                for (int j = 0; j < word.Length; j++)
                {
                    if (!letters.Contains(word[j]))
                    {
                        printWord = false;

                        break;
                    }
                    centerLetterFound = centerLetterFound || word[j] == centerLetter;
                }

                if (printWord && centerLetterFound)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
