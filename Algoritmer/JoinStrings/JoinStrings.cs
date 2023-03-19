namespace Algoritmer.JoinStrings
{
    public static class JoinStringsCalculator 
    {
        public static void Calculate(IConsole Console)
        {
            int numStrs = int.Parse(Console.ReadLine());
            StringNode[] array = new StringNode[numStrs];

            for (int i = 0; i < numStrs; i++)
            {
                array[i] = new StringNode(Console.ReadLine());
            }

            int idx = 0;
            for (int j = 0; j < numStrs -1; j++)
            {
                string[] aa = Console.ReadLine().Split(' ');
                int a = int.Parse(aa[0]) - 1;
                int b = int.Parse(aa[1]) - 1;
                array[a].Append(array[b]);
                idx = a;
            }

            for (StringNode n = array[idx]; n != null; n = n.next)
            {
                Console.Write(n.s);
            }
            
        }
    }

    public class StringNode
    {
        public readonly string s;
        public StringNode last;
        public StringNode next;

        public StringNode(string s)
        {
            this.s = s;
            last = this;
        }

        public void Append(StringNode s)
        {
            last.next = s;
            last = s.last;
        }
    }
}
