using System;

namespace Algoritmer.HappyTelephones
{
    public static class HappyTelephone
    {
        public static void Calculate(IConsole Console)
        {
            while (true)
            {
                string firstLine = Console.ReadLine();
                int N = int.Parse(firstLine.Substring(0, firstLine.IndexOf(' ') + 1));
                int M = int.Parse(firstLine.Substring(firstLine.IndexOf(' ') + 1));
                if (N == 0 && M == 0)
                {
                    break;
                }

                var calls = new Interval[N];
                for (int i = 0; i < N; i++)
                {
                    string line = Console.ReadLine();
                    string[] lineSplit = line.Split(new[] { ' ' }, StringSplitOptions.None);
                    int callStart = int.Parse(lineSplit[2]);
                    int callDuration = int.Parse(lineSplit[3]);
                    calls[i] = new Interval(callStart, callDuration);
                }

                for (int i = 0; i < M; i++)
                {
                    string intervalLine = Console.ReadLine();
                    int intervalStart = int.Parse(intervalLine.Substring(0, intervalLine.IndexOf(' ') + 1));
                    int intervalDuration = int.Parse(intervalLine.Substring(intervalLine.IndexOf(' ') + 1));
                    var currentInterval = new Interval(intervalStart, intervalDuration);
                    long sum = 0;
                    for (int j = 0; j < N; j++)
                    {
                        if (currentInterval.AreActive(calls[j]))
                        {
                            sum++;
                        }
                    }
                    Console.WriteLine(sum.ToString());
                }
            }
        }

        public class Interval
        {
            public int Start { get; set; }
            public int End { get; set; }
            public Interval(int start, int duration)
            {
                Start = start;
                End = start + duration;
            }

            public bool AreActive(Interval other)
            {
                return ((Start <= (other.Start)) && (other.Start < End))
                       || ((Start < other.End) && (other.End <= End))
                       || ((other.Start < Start) && (other.End > End));
            }
        }
    }
}
