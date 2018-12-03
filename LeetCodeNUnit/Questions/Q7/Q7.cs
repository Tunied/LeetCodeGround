using System;
using System.Text;
using NUnit.Framework;
using static System.Int32;

namespace LeetCodeNUnit.Questions.Q2
{
    public class Q7
    {
        [Test]
        public static void Test()
        {
            var q2 = new Q7();
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

            var s = new StringBuilder();
            if (x < 0) s.Append("-");
            if (x == int.MinValue) return 0;
            x = Math.Abs(x);
            while (x >= 10)
            {
                s.Append(x % 10);
                x /= 10;
            }

            s.Append(x);
            var v = long.Parse(s.ToString());
            if (v >= int.MaxValue || v <= int.MinValue) return 0;
            return (int) v;
        }
    }
}