using System;
using System.Collections.Generic;

namespace Algoritmer.SymmetricOrders
{
    public static class SymmetricOrder
    {
        public static void Calculate(IConsole console)
        {
            string line;
            var sets = new List<string[]>();
            int numberInSet = 0;
            while ((line = console.ReadLine()) != null)
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
                        line = console.ReadLine();
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
                console.WriteLine($"SET {setIndex++}");
                foreach (string name in names)
                {
                    console.WriteLine(name);
                }
            }
        }
    }
}
