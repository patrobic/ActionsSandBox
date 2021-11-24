using ActionsSandbox.Library;
using System.Collections.Generic;
using Xunit;

namespace ActionsSandbox.Test
{
    public class UnitTest2
    {
        [Fact]
        public void TestAdd()
        {
            var math = new Class2();
            var result = math.CountItems(new List<int> { 1, 2, 3 });
            Assert.Equal(3, result);
        }
    }
}