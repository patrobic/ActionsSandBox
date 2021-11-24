using ActionsSandbox.Library;
using Xunit;

namespace ActionsSandbox.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            var math = new Class1();
            var result = math.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestSubtract()
        {
            var math = new Class1();
            var result = math.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestMultiply()
        {
            var math = new Class1();
            var result = math.Multiply(2, 3);
            Assert.Equal(6, result);
        }
    }
}