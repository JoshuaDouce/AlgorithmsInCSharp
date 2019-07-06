using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 7, 7, 9, 10 };

            var index = BinarySearch(array, 3);

            Console.WriteLine($"3 found at position {index}");

            var index2 = BinarySearch(array, 11);

            if (index2 == -1)
            {
                Console.WriteLine($"11 Not found in given array");
            }

            var index3 = BinarySearch(array, 8);

            if (index2 == -1)
            {
                Console.WriteLine($"8 Not found in given array");
            }
        }

        public static int BinarySearch(int[] array, int x) {
            var start = 0;
            var end = array.Length - 1;

            while (start <= end)
            {
                var midpoint = (start + end) / 2;
                if (x < array[midpoint])
                {
                    end = midpoint - 1;
                }
                else if(x > array[midpoint])
                {
                    start = midpoint + 1;
                }
                else
                {
                    return midpoint;
                }
            }

            return -1;
        }
    }
}
