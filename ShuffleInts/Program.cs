using System;

namespace ShuffleInts
{
    internal class Program
    {
        private const int NUM_ELEMENTS = 1000;
        
        public static void Main(string[] args)
        {
            var data = new int[NUM_ELEMENTS];
            for (var i = 0; i < data.Length; i++)
            {
                data[i] = i + 1;
            }
            Console.Out.WriteLine(string.Join(",", data));
            var rng = new Random();
            for (var dest = data.Length - 1; dest > 0; dest--)
            {
                var src = rng.Next(dest + 1); // Random int from 0 to dest, inclusive.
                var temp = data[src];
                data[src] = data[dest];
                data[dest] = temp;
            }
            Console.Out.WriteLine(string.Join(",", data));
        }
    }
}