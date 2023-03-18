using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Algoritmer.CastingSpells
{
    public static class CastingSpell
    {
        public static void Calculate(IConsole Console)
        {
            string s = Console.ReadLine();
            HashSet<long> lengths = new HashSet<long>();
            for (int ii = 0; ii < s.Length; ii++)
            {
                var p = CalculateSpell(s.Substring(ii, s.Length - ii));
                lengths.Add(p);
            }
            //long length = CalculateSpell(s);
            Console.WriteLine(lengths.Max().ToString());
        }

        private static long CalculateSpell(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 4)
            {
                return 0;
            }
            
            Tuple<long, long> indexes = Manacher(s);
            long length = indexes.Item2 - indexes.Item1;

            if ((length % 4 != 0))
            {
                //length = 0;
                //var s1 = s.Substring((int)indexes.Item1, (int)length);
                //return CalculateSpell(s.Replace(s1, string.Empty));
            }

            var r = s.Substring((int)indexes.Item1, (int)length);
            var x = r.Substring(0, r.Length / 2);
            var y = r.Substring(r.Length / 2, r.Length / 2);
            if (x != y)
            {
                return 0;
                //return CalculateSpell(s.Replace(s2, string.Empty));
            }
            //else
            //{
            //    //string w1 = x.Substring(0, x.Length / 2);
            //    //string w2 = y.Substring(0, y.Length / 2);
            //    //if (w1 != w2)
            //    //{
            //    //    //length = 0;
            //    //    var s3 = s.Substring((int)indexes.Item1, (int)length);
            //    //    return CalculateSpell(s.Replace(s3, string.Empty)); 
            //    //}
            //    return 0;
            //}

            return length;
        }

        public static Tuple<long, long> Manacher(string s)
        {
            if (s == String.Empty)
            {
                return new Tuple<long, long>(0, 1);
            }

            string t = "^#" + string.Join('#', s.ToCharArray()) + "#$";
            var c = 1;
            var d = 1;
            var p = new int[t.Length];
            for (int i = 2; i < t.Length - 1; i++)
            {
                // -- reflekter indeks i med hensyn på c
                var mirror = 2 * c - i;         // # = c - (i-c)
                p[i] = Math.Max(0, Math.Min(d - i, p[mirror]));
                // -- la palindrom med senter i i vokse
                while (t[i + 1 + p[i]] == t[i - 1 - p[i]])
                {
                    p[i] += 1;
                }
                // -- juster senter hvis nødvendig
                if (i + p[i] > d)
                {
                    c = i;
                    d = i + p[i];
                }
            }

            long k = 0;
            long maxi = 0;
            for (int i = 1; i < t.Length - 1; i++)
            {
                if (p[i] > k)
                {
                    k = p[i];
                    maxi = i;
                }
            }
            
            return new Tuple<long, long>((maxi - k) / 2, (maxi + k) / 2);  // trekk ut løsning
        }
    }
}
