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
    }
}