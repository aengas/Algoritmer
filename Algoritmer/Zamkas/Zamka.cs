namespace Algoritmer.Zamkas
{
    public static class Zamka
    {
        public static void Calculate(IConsole console)
        {
            int L = int.Parse(console.ReadLine());
            int D = int.Parse(console.ReadLine());
            int X = int.Parse(console.ReadLine());

            int N = 0;
            for (int i = L; i <= D; i++)
            {
                if (Across(i) == X)
                {
                    N = i;
                    break;
                }
            }

            int M = 0;
            for (int j = D; j >= L; j--)
            {
                if (Across(j) == X)
                {
                    M = j;
                    break;
                }
            }
            
            console.WriteLine(N.ToString());
            console.WriteLine(M.ToString());
        }

        private static int Across(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
    }
}
