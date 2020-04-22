using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demo = { 8, 4, 23, 42, 16, 15 };
            int[] ReverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] FewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] NearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine("[" + string.Join(",", MergeSorting(demo)) + "]");
            Console.WriteLine("[" + string.Join(",", MergeSorting(ReverseSorted)) + "]");
            Console.WriteLine("[" + string.Join(",", MergeSorting(FewUniques)) + "]");
            Console.WriteLine("[" + string.Join(",", MergeSorting(NearlySorted)) + "]");

            //Reverse-sorted: [20,18,12,8,5,-2]
            // Few uniques: [5,12,7,5,5,7]
            // Nearly-sorted: [2,3,5,7,13,11]
            Console.WriteLine("Hello World!");
        }
        public static void Merging(int[] left, int[] right, int[] original)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    original[k] = left[i];
                    i++;
                }
                else
                {
                    original[k] = right[j];
                    j++;
                }
                k++;
            }

            if (i == left.Length)
            {
                while (j < right.Length)
                {
                    original[k] = right[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < left.Length)
                {
                    original[k] = left[i];
                    i++;
                    k++;
                }
            }
        }

        public static int[] MergeSorting(int[] original)
        {
            int n = original.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < n; i++)
                {
                    if (i < mid)
                    {
                        left[i] = original[i];
                    }
                    else
                    {
                        right[i - mid] = original[i];
                    }
                }
                MergeSorting(left);
                MergeSorting(right);
                Merging(left, right, original);
            }
            return original;
        }
    }
}
