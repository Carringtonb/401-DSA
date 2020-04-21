using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] Reverse = { 20, 18, 12, 8, 5, -2 };
            int[] Uniques = { 5, 12, 7, 5, 5, 7 };
            int[] NearlySorted = { 2, 3, 5, 7, 13, 11 };
            int[] MyOwnArray = { 4, 20, 420, 69, 24 };

            Console.WriteLine("[" + string.Join(", ", InsertionSort(Reverse)) + " ]");
            Console.WriteLine("[" + string.Join(", ", InsertionSort(Uniques)) + " ]");
            Console.WriteLine("[" + string.Join(", ", InsertionSort(NearlySorted)) + " ]");
            Console.WriteLine("[" + string.Join(", ", InsertionSort(MyOwnArray)) + " ]");
        }

      public static int[] InsertionSort(int[] arr)
        {
        for (int i = 1; i<arr.Length; i++)
        {
                int j = i - 1;
                int temp = arr[i];

                while (j >=0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = temp;
        }

            return arr;

}
    }
}
