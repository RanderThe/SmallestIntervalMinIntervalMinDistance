using System;
using System.Linq;

namespace SmallestIntervalMinIntervalMinDistance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { -1, 2, 5, 10, 20, 25 };
            int result = minDist(array);

            Console.WriteLine(result);

        }

        static int minDist(int[] arr)
        {
            int MinDistance = arr.SelectMany(
                (a, i) => arr.Skip(i + 1).Select((b) => Math.Abs(a - b))).Min();

            return MinDistance;
        }
    }
}
