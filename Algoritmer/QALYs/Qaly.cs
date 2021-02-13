using System.Globalization;

namespace Algoritmer.QALYs
{
    public static class Qaly
    {
        public static void Calculate(IConsole console)
        {
            double sum = 0.0;
            int numberOfInputs = int.Parse(console.ReadLine());
            for (int i = 1; i <= numberOfInputs; i++)
            {
                string[] split = console.ReadLine().Split(' ');
                double qualityOfLife = double.Parse(split[0], CultureInfo.InvariantCulture);
                double period = double.Parse(split[1], CultureInfo.InvariantCulture);

                sum += qualityOfLife * period;
            }

            console.WriteLine(sum.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
