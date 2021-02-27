﻿using System;
using System.Collections.Generic;

namespace Algoritmer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            char centerLetter = letters[0];
            var letterHash = new HashSet<char>();
            for (int i = 0; i < letters.Length; i++)
            {
                letterHash.Add(letters[i]);
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                bool printWord = true;
                if (!word.Contains(centerLetter) || word.Length < 4)
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
                    Console.WriteLine(word);
                }
            }
        }
    }
}
