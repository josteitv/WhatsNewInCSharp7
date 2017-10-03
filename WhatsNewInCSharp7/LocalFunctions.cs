using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewInCSharp7
{
    // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#local-functions
    public class LocalFunctions
    {
        private static void Main(string[] args)
        {
            var resultSet = AlphabetSubset('f', 'a');
            Console.WriteLine("iterator created");
            foreach (var thing in resultSet)
                Console.Write($"{thing}, ");

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }


        public static IEnumerable<char> AlphabetSubset(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(nameof(start), "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(nameof(end), "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");
            for (var c = start; c < end; c++)
                yield return c;
        }







        public Task<string> PerformLongRunningWork(string address, int index, string name)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("An address is required", nameof(address));
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "The index must be non-negative");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("You must supply a name", nameof(name));

            return longRunningWorkImplementation();

            async Task<string> longRunningWorkImplementation()
            {
                // Do long running work
                return "";
            }
        }
    }




}
