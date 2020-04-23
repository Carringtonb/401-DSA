using System;

namespace QuickSort
{
   public class Program
    {
        static void Main(string[] args)
        {
            //          In your blog article, visually show the output of processing this input array:

            //          [8,4,23,42,16,15]

            //          For your own understanding, consider also stepping through these inputs:

            //          Reverse-sorted: [20,18,12,8,5,-2]
            //          Few uniques: [5,12,7,5,5,7]
            //          Nearly-sorted: [2,3,5,7,13,11]

            int[] original = { 8, 4, 23, 42, 16, 15 };
            int[] ReverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] FewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] NearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine("[" + string.Join(",", QuickSort(original, 0, original.Length - 1)) + "]");
            Console.WriteLine("[" + string.Join(",", QuickSort(ReverseSorted, 0, ReverseSorted.Length - 1)) + "]");
            Console.WriteLine("[" + string.Join(",", QuickSort(FewUniques, 0, FewUniques.Length - 1)) + "]");
            Console.WriteLine("[" + string.Join(",", QuickSort(FewUniques, 0, FewUniques.Length - 1)) + "]");

            Console.WriteLine("Hello World!");
        }

        public static int[] QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(array, left, right);

                QuickSort(array, left, position - 1);
                QuickSort(array, position + 1, right);
            }
            return array;
        }

        public static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (array[i] <= pivot)
                {
                    low = low + 1;
                    Swap(array, i, low);
                }
            }
            Swap(array, right, low + 1);

            return low + 1;
        }

        public static void Swap(int[] array, int i, int low)
        {
            int temporary = array[i];
            array[i] = array[low];
            array[low] = temporary;
        }
    }
}
