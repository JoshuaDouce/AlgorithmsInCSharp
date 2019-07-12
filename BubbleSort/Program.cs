using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 6, 20, 8, 19, 56, 23, 87, 41, 49, 53 };
            BubbleSort(list);

            Console.WriteLine(string.Join(", ", list));
        }

        private static void BubbleSort(int[] data) {
            for (int i = data.Length -1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++) // 2 for loops big O(n2)
                {
                    if (data[j] > data[j+1])
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }

                Console.WriteLine(string.Join(", ", data));
            }
        }
    }
}
