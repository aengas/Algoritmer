using System;

namespace Algoritmer.SpeedLimits
{
    public static class SpeedLimit
    {
        public static void Calculate(IConsole console)
        {
            int sum = 0;
            int previousTotalHoursElapsed = 0;
            string line;
            while ((line = console.ReadLine()) != null)
            {
                string[] split = line.Split(new[] { ' ' }, StringSplitOptions.None);

                if (split.Length == 1)
                {
                    if (sum > 0)
                    {
                        console.WriteLine($"{sum} miles");
                    }
                    if (split[0] == "-1")
                    {
                        break;
                    }

                    sum = 0;
                    previousTotalHoursElapsed = 0;
                }
                else
                {
                    int speed = int.Parse(split[0]);
                    int totalHoursElapsed = int.Parse(split[1]);
                    sum += speed * (totalHoursElapsed - previousTotalHoursElapsed);

                    previousTotalHoursElapsed = totalHoursElapsed;
                }
            }
        }
    }
}
