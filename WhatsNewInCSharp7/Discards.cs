using System;

namespace WhatsNewInCSharp7
{
    public class Discards
    {
        public static void Main(string[] args)
        {
            var numbers = new [] {1, 2, 3, 4, 5};
            var (max, _) = Tuples.Range(numbers);
            Console.WriteLine(max);

            int.TryParse("1", out _);
        }
    }
}
