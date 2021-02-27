using System.Collections.Generic;

namespace Algoritmer.SpellingBees
{
    public static class SpellingBee
    {
        public static void Calculate(IConsole console)
        {
            string letters = console.ReadLine();
            char centerLetter = letters[0];
            var letterHash = new HashSet<char>();
            for (int i = 0; i < letters.Length; i++)
            {
                letterHash.Add(letters[i]);
            }
            int n = int.Parse(console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = console.ReadLine();
                
                bool printWord = true;
                if (word.Length < 4 || !word.Contains(centerLetter))
                {
                    continue;
                }
                for (int j = 0; j < word.Length; j++)
                {
                    if (!letterHash.Contains(word[j]))
                    {
                        printWord = false;
                        break;
                    }
                }

                if (printWord)
                {
                    console.WriteLine(word);
                }
                
            }
        }
    }
}
