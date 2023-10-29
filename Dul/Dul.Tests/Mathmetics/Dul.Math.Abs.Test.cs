
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests.Mathmetics
{
    [TestClass]
    public class DulMathTest
    {
        public void AbsTest()
        {
            var expected = 1234;
            var actual = Dul.Math.Abs(-1234);
            Assert.AreEqual(expected, actual);
        }
    }
}
