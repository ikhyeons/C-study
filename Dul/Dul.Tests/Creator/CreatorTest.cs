using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class CreatorTest
    {
        public void GetNameTest()
        {
            const string expected = "RedPlus";
            var actual = Creator.GetName();
            Assert.AreEqual(expected, actual);
        }
    }
}
