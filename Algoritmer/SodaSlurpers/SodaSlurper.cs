namespace Algoritmer.SodaSlurpers
{
    public static class SodaSlurper
    {
        public static void Calculate(IConsole console)
        {
            string line = console.ReadLine();
            string[] split = line.Split(" ");
            int emptyBottlesStart = int.Parse(split[0]);
            int emptyBottlesFound = int.Parse(split[1]);
            int numberOfEmptyRequiredToBuyANew = int.Parse(split[2]);

            int totalDrinks = 0;
            if (numberOfEmptyRequiredToBuyANew <= emptyBottlesStart)
            {
                totalDrinks = emptyBottlesStart / numberOfEmptyRequiredToBuyANew;
            }

            emptyBottlesStart -= (totalDrinks * numberOfEmptyRequiredToBuyANew);

            emptyBottlesStart += emptyBottlesFound;

            int safe = 0;
            int drunkedEmptyBottles = totalDrinks;
            int totalLeft = drunkedEmptyBottles + emptyBottlesStart;
            while (totalLeft > 0 && safe < 1000)
            {
                int drinkedThisRound = 0;

                if (numberOfEmptyRequiredToBuyANew <= totalLeft)
                {
                    drinkedThisRound += totalLeft / numberOfEmptyRequiredToBuyANew;
                    totalDrinks += drinkedThisRound;
                }

                drunkedEmptyBottles = drinkedThisRound;

                totalLeft = drunkedEmptyBottles + (totalLeft - (drinkedThisRound * numberOfEmptyRequiredToBuyANew));
                safe++;
            }

            console.WriteLine(totalDrinks.ToString());
        }
    }
}
