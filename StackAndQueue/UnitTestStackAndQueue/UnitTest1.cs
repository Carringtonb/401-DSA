using System;
using Xunit;
using StackAndQueue.Classes
using System.Collections;

namespace UnitTestStackAndQueue
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateANewStack()
        {
            Stack stack = new Stack();
            string expected = stack.ToString();
            string input = "Top of stack -> Null";
            Assert.Equal(expected, input);
        }
    }
}
