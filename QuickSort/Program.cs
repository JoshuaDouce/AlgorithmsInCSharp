using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 6, 20, 8, 19, 56, 23, 87, 41, 49, 53 };

            QuickSort(data, 0, data.Length - 1);

            Console.WriteLine(string.Join(", ", data));
        }

        private static void QuickSort(int[] data, int first, int last) {
            if (first < last)
            {
                //Calculate splt spoint
                var pivotIdx = Partition(data, first, last);

                //Sort Partitions
                QuickSort(data, first, pivotIdx - 1);
                QuickSort(data, pivotIdx + 1, last);
            }
        }

        private static int Partition(int[] data, int first, int last)
        {
            //Choose first vlaue as pivot
            var pivotValue = data[first];

            //estacblish upper and lower indexes
            var lower = first + 1;
            var upper = last;

            //search for cross point
            var done = false;

            while (!done)
            {
                //Advance Lower
                while (lower <= upper && data[lower] <= pivotValue)
                {
                    lower++;
                }

                //Advance Upper
                while (data[upper] >= pivotValue && upper >= lower)
                {
                    upper--;
                }

                //If Crossed found split
                if (upper < lower)
                {
                    done = true;
                }
                else {
                    var x = data[lower];
                    data[lower] = data[upper];
                    data[upper] = x;
                }
            }

            //when split point found exchange pivot value
            var temp = data[first];
            data[first] = data[upper];
            data[upper] = temp;

            //return split index
            return upper;
        }
    }
}
