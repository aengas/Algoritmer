using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritmer.CardTradings
{
    public static class CardTrading
    {
        public static void Calculate(IConsole Console)
        {
            string[] firstSplit = Console.ReadLine().Split(new[] { ' ' });
            int N = int.Parse(firstSplit[0]);
            int T = int.Parse(firstSplit[1]);
            int K = int.Parse(firstSplit[2]);

            var deckSplit = Console.ReadLine().Split(new[] { ' ' });

            var cards = new int[N];
            for (int i = 0; i < N; i++)
            {
                cards[int.Parse(deckSplit[i]) - 1]++;
            }


            long costOfGettingEveryCombo = 0;
            var sellAndBuy = new List<int>();
            for (int i = 0; i < T; i++)
            {
                string line = Console.ReadLine();
                string[] lineSplit = line.Split(new[] { ' ' });
                int ai = int.Parse(lineSplit[0]);
                int bi = int.Parse(lineSplit[1]);
                int buy = 0;
                int sell = 0;
                int count = cards[i];
                if (count == 2)
                {
                    buy = 0;
                    sell = bi + bi;
                }
                else if (count == 1)
                {
                    buy = ai;
                    sell = bi;
                }
                else if (count == 0)
                {
                    buy = ai + ai;
                    sell = 0;
                }

                costOfGettingEveryCombo -= buy;
                sellAndBuy.Add(sell + buy);
            }

            sellAndBuy.Sort();

            for (int i = K; i <= sellAndBuy.Count - 1; i++)
            {
                costOfGettingEveryCombo += sellAndBuy[i];
            }

            Console.WriteLine(costOfGettingEveryCombo.ToString());
        }
    }
}
