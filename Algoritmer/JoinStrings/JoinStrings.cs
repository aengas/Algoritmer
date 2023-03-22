using System.Text;

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
                string input = Console.ReadLine();
                int spaceIndex = input.IndexOf(' ');
                int a = int.Parse(input.Substring(0, spaceIndex)) - 1;
                int b = int.Parse(input.Substring(spaceIndex + 1)) - 1;
                array[a].Append(array[b]);
                idx = a;
            }

            StringBuilder strb = new StringBuilder();
            for (StringNode n = array[idx]; n != null; n = n.Next)
            {
                strb.Append(n.S);
             
            }
            Console.WriteLine(strb.ToString());
        }
    }

    public class StringNode
    {
        public readonly string S;
        public StringNode Last;
        public StringNode Next;

        public StringNode(string s)
        {
            S = s;
            Last = this;
        }

        public void Append(StringNode sn)
        {
            Last.Next = sn;
            Last = sn.Last;
        }
    }
}
