namespace Algoritmer.PowerStrings
{
    public class PowerStringCalculator
    {
        public static void Calculate(IConsole console)
        {
            string line;
            while ((line = console.ReadLine()) != ".")
            {
                 console.WriteLine(PowerstringByBorder(line).ToString());
            }
        }

        public static int PowerstringByBorder(string u)
        {
            int n = u.Length;

            int f = MaximumBorderLength(u, n);

            int divisor = n - f;
            if (n % divisor == 0)                   // deler justeringsforskyvningen seg i n ?
            {
                return n / divisor;                 // vi har funnet en potens-dekomposisjon
            }

            return 1;
        }

        public static int MaximumBorderLength(string w, int n)
        {
            var f = new int[n];                         // init f[0] = 0
            int k = 0;                                  // nåværende lengste grenselengde
            for (int i = 1; i < n; i++)                 // beregn f[i]
            {
                while (w[k] != w[i] && k > 0)
                {
                    k = f[k - 1];                       // mismatch: prøv neste grense
                }

                if (w[k] == w[i])                       // siste bokstaver matcher
                {
                    k++;                                // vi kan inkrementere grenselengden
                }

                f[i] = k;                               // vi har funnet den maksimale grensen til w[:i + 1]    
               
            }

            return k;
        }


    }
}
