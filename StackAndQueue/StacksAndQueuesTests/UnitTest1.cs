using System;
using Xunit;
using StackAndQueue.Classes;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateANewStack()
        {
            Stack stack = new Stack();
            string expected = stack.ToString();
            string input = "Top of Stack ->Null";
            Assert.Equal(expected, input);
        }
    }
}
