using System;
using System.Collections.Generic;
using System.Linq;

namespace Thief
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            foreach (var permutation in Permute(input))
            {
                Console.WriteLine($"{permutation}");
            }
        }

        private static IEnumerable<string> Permute(string source)
        {
            if (source.Length == 1) return new List<string> { source };
            
            IEnumerable<string> Enumerable()
            {
                foreach (var c in source)
                {
                    foreach (var p in Permute(new string(source.Where(x => x != c).ToArray())))
                    {
                        yield return c + p;
                    }
                }
            }

            var permutations = Enumerable();

            return permutations;
        }
    }
}
