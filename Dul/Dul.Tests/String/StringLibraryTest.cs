using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dul.Tests.String
{
    [TestClass]
    public class StringLibraryTest
    {
        [TestMethod]
        public void CutStringTest()
        {
            var expected = "안녕하...";
            var actual = "안녕하세요.".CutStringUnicode(6);

            Assert.AreEqual(expected,actual);
        }
    }

}


