namespace Algoritmer.JoinStrings
{
    public static class JoinStringsCalculator 
    {
        public static void Calculate(IConsole Console)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            string[] strings = new string[numberOfStrings + 1];
            for (int i = 1; i <= numberOfStrings; i++)
            {
                strings[i] = Console.ReadLine();
            }

            string remainingString = "";
            while (true)
            {
                string line = Console.ReadLine();
                if (line == null)
                {
                    break;
                }
                string[] pair = line.Split(' ');
                int a = int.Parse(pair[0]);
                int b = int.Parse(pair[1]);
                strings[a] += strings[b];
                remainingString = strings[a];
                strings[b] = "";
            }

            if (remainingString == "")
            {
                remainingString = strings[1];
            }
            Console.WriteLine(remainingString);
        }
    }
}
