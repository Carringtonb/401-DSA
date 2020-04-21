using System;
using InsertionSort;
using Xunit;

namespace InsertSortTest1
{
    public class UnitTest1
    {
        [Fact]
        public void TestToMakeSureArraysAreBeingSorted()
        {
            int[] Reverse = { 20, 18, 12, 8, 5, -2 };

            int[] test = Program.InsertionSort(Reverse);

            int[] result = { -2, 5, 8, 12, 18, 20 };

            Assert.Equal(result, test)
        }
    }
}
