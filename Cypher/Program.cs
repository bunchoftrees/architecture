using System;
using System.Linq;

namespace Cypher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            char[] alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();

            foreach (char c in alphabet)
            {
                Console.WriteLine(c);
            }
        }
    }
}