
using System.Collections.Generic;

namespace WhatsNewInCSharp7
{
    public class Tuples
    {
        public static void Main(string[] args)
        {
            var letters = ("a", "b");
            var item1 = letters.Item1;
            var item2 = letters.Item2;

            (string Alpha, string Beta) namedLetters = ("a", "b");
            var alpha = namedLetters.Alpha;
            var beta = namedLetters.Beta;

            var alphabetStart = (Alpha: "a", Beta: "b");
            var a = alphabetStart.Alpha;
            var b = alphabetStart.Beta;

            (string First, string Second) firstLetters = (Alpha: "a", Beta: "b");
            var first = firstLetters.First;
            var second = firstLetters.Second;

        }

        public static (int Max, int Min) Range(IEnumerable<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min);
        }
    }
}
