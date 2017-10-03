using System;

namespace WhatsNewInCSharp7
{
    public class RefLocalsAndReturns
    {
        private static void Main(string[] args)
        {
            var matrix = new[,]
            {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 42, 0, 0 }
            };

            var indices = MatrixSearch.Find(matrix, val => val == 42);
            Console.WriteLine(indices);
            matrix[indices.i, indices.j] = 24;
            Console.WriteLine(matrix[4, 2]);

//            var valItem = MatrixSearch.Find2(matrix, (val) => val == 42);
//            Console.WriteLine(valItem);
//            valItem = 24;
//            Console.WriteLine(matrix[4, 2]);

//            ref var valItemRef = ref MatrixSearch.Find2(matrix, (val) => val == 42);
//            Console.WriteLine(valItemRef);
//            valItemRef = 24;
//            Console.WriteLine(matrix[4, 2]);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }

    public class MatrixSearch
    {
        public static (int i, int j) Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (predicate(matrix[i, j]))
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1); // Not found
        }

        public static ref int Find2(int[,] matrix, Func<int, bool> predicate)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (predicate(matrix[i, j]))
                    {
                        return ref matrix[i, j];
                    }
                }
            }
            throw new InvalidOperationException("Not found");
        }
    }
}
