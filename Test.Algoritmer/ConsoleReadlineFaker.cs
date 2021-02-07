using System.Collections.Generic;
using Algoritmer;

namespace Test.Algoritmer
{
    public class ConsoleFaker : IConsole
    {
        private readonly string[] m_input;

        private int m_inputIndex;

        public List<string> Output;
        
        public ConsoleFaker(string[] input)
        {
            m_input = input;
            Output = new List<string>();
        }

        public string ReadLine()
        {
            m_inputIndex++;
            return m_input[m_inputIndex - 1];
        }

        public void WriteLine(string value)
        {
            Output.Add(value);
        }
    }
}
