namespace Algoritmer.Tarifas
{
    public static class Tarifa
    {
        public static void Calculate(IConsole console)
        {
            int X = int.Parse(console.ReadLine());
            int N = int.Parse(console.ReadLine());

            int notUsed = 0;
            for (int i = 1; i <= N; i++)
            {
                notUsed += X - int.Parse(console.ReadLine());
            }
            
            console.WriteLine((notUsed + X).ToString());
        }
    }
}
