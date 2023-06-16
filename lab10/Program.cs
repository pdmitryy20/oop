using System;
using System.Collections.Generic;

namespace lab10
{
    public class CharSet
    {
        private HashSet<char> set;
        public CharSet()
        {
            set = new HashSet<char>();
        }
        public CharSet(string str)
        {
            set = new HashSet<char>(str);
        }
        public static CharSet operator +(CharSet set1, CharSet set2)
        {
            CharSet unionSet = new CharSet();
            unionSet.set = new HashSet<char>(set1.set);
            unionSet.set.UnionWith(set2.set);
            return unionSet;
        }
        public override string ToString()
        {
            return string.Join(", ", set);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CharSet set1 = new CharSet("abc");
            CharSet set2 = new CharSet("def");
            CharSet set3 = new CharSet("abc");
            CharSet unionSet = set1 + set2;
            Console.WriteLine("Union: " + unionSet);
        }
    }
}
