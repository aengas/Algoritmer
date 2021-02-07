using System;
using System.Collections.Generic;

namespace Algoritmer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line;
            var sets = new List<string[]>();
            int numberInSet = 0;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new[] { ' ' }, StringSplitOptions.None);

                bool isNumber = int.TryParse(split[0], out int setNumberInInput);
                if (!isNumber)
                {
                    string[] l = new string[numberInSet];
                    l[0] = line;
                    int firstIndex = 1;
                    int lastIndex = numberInSet - 1;
                    for (int i = 1; i < numberInSet; i++)
                    {
                        line = Console.ReadLine();
                        if (i % 2 == 0)
                        {
                            l[firstIndex++] = line;
                        }
                        else
                        {
                            l[lastIndex--] = line;
                        }
                    }
                    sets.Add(l);
                }
                else
                {
                    numberInSet = setNumberInInput;
                    if (numberInSet == 0)
                    {
                        break;
                    }
                }
            }

            int setIndex = 1;
            foreach (string[] names in sets)
            {
                Console.WriteLine($"SET {setIndex++}");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
