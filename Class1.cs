using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUNITLab
{
    public class DivisibleNb
    {
        public static bool isDivisible(long n, long x, long y)
        {
            if (n % x == 0 && n % y == 0)
                return true;
            else
                return false;
        }
    }

    [TestFixture]
    public class DivisibleNbTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, DivisibleNb.isDivisible(12, 4, 3));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, DivisibleNb.isDivisible(3, 3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, DivisibleNb.isDivisible(8, 3, 4));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, DivisibleNb.isDivisible(100, 5, 3));
        }

    }

}
