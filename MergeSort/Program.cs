using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 6, 20, 8, 19, 56, 23, 87, 41, 49, 53};

            MergeSort(data);

            Console.WriteLine(string.Join(", ", data));
        }

        private static void MergeSort(int[] data) {
            if (data.Length > 1)
            {
                var left = data.Take(data.Length / 2).ToArray();
                var right = data.Skip(data.Length / 2).ToArray();

                //Recursively break down the array
                MergeSort(left);
                MergeSort(right);

                //Perform Merge
                var leftIndex = 0;
                var rightIndex = 0;
                var mergedIndex = 0;

                //While left and right have values 
                while (leftIndex < left.Length && rightIndex < right.Length)
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        data[mergedIndex] = left[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        data[mergedIndex] = right[rightIndex];
                        rightIndex++;
                    }
                    mergedIndex++;

                    Console.WriteLine(string.Join(", ", data));
                }

                //If left has value remaining
                while (leftIndex < left.Length)
                {
                    data[mergedIndex] = left[leftIndex];
                    leftIndex++;
                    mergedIndex++;
                }

                //If right has value remaining
                while (rightIndex < right.Length)
                {
                    data[mergedIndex] = right[rightIndex];
                    rightIndex++;
                    mergedIndex++;
                }
            }
        }
    }
}
