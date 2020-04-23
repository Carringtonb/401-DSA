using System;
using Xunit;
using QuickSort;

namespace QuickSortUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckToSeeIfOriginalArrayIsSorted()
        {
            int[] original = { 8, 4, 23, 42, 16, 15 };

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, Program.QuickSort(original, 0, original.Length - 1));
        }
        [Fact]
        public void CheckToSeeIfReverseArrayIsSorted()
        {
            int[] reverse = {20, 18, 12, 8, 5, -2};

            Assert.Equal(new int[] { -2, 5, 8, 12, 18, 20 }, Program.QuickSort(reverse, 0, reverse.Length - 1));
        }
        [Fact]
        public void CheckToSeeIfUniqueArrayIsSorted()
        {
            int[] unique = { 5, 12, 7, 5, 5, 7 };

            Assert.Equal(new int[] { 5, 5, 5, 7, 7, 12 }, Program.QuickSort(unique, 0, unique.Length - 1));
        }
        [Fact]
        public void CheckToSeeIfAlmostSortedArrayIsSorted()
        {
            int[] almostSorted = { 2, 3, 5, 7, 13, 11 };

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13 }, Program.QuickSort(almostSorted, 0, almostSorted.Length - 1));
        }
    }
}
