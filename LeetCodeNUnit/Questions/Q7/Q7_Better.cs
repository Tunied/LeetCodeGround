using System;
using System.Text;
using NUnit.Framework;

namespace LeetCodeNUnit.Questions.Q2
{
    public class Q7_Better
    {
        [Test]
        public static void Test()
        {
            var q2 = new Q7_Better();
            Assert.AreEqual(1234, q2.Reverse(4321));
            Assert.AreEqual(5, q2.Reverse(5));
            Assert.AreEqual(-5, q2.Reverse(-5));
            Assert.AreEqual(1, q2.Reverse(10));
            Assert.AreEqual(-1, q2.Reverse(-10));
            Assert.AreEqual(-4578558, q2.Reverse(-8558754));
            Assert.AreEqual(0, q2.Reverse(1534236469));
        }


        public int Reverse(int x)
        {
            if (x < 10 && x > -10) return x;

            if (x == int.MinValue) return 0;

            var result = 0;
            while (x >= 10)
            {
                var num = x % 10;
                x /= 10;
                result = result * 10 + num;
            }

            return (int) result;
        }
    }
}