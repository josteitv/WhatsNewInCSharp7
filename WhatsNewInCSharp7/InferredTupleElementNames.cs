
namespace WhatsNewInCSharp7
{
    public class InferredTupleElementNames
    {
        public static void Main(string[] args)
        {
            var a = "a";
            var b = "b";

            var letters = (a, b);
            var item1 = letters.Item1;
            var item2 = letters.Item2;

            var letterA = letters.a;
            var letterB = letters.b;
        }

    }
}
