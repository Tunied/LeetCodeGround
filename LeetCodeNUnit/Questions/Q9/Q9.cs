using NUnit.Framework;

namespace LeetCodeNUnit.Questions.Q9
{
    public class Q9
    {
        [Test]
        public static void Test()
        {
            var q = new Q9();
            Assert.IsTrue(q.IsPalindrome(121));
            Assert.IsTrue(q.IsPalindrome(11211));
            Assert.IsFalse(q.IsPalindrome(10));
            Assert.IsFalse(q.IsPalindrome(-121));
        }


        //Int.Max 最大10位数
        private static int[] cache = new int[10];

        public bool IsPalindrome(int x)
        {
            if (x <= 0) return false;
            var length = FillCache(x);
            var maxLoop = length / 2;
            for (var i = 0; i < maxLoop; i++)
            {
                if (cache[i] != cache[length - i - 1]) return false;
            }

            return true;
        }

        /// <summary>
        /// 填满Cache,返回int的length
        /// </summary>
        /// <param name="_num"></param>
        /// <returns></returns>
        private int FillCache(int _num)
        {
            var index = 0;
            while (_num > 0)
            {
                cache[index] = _num % 10;
                _num /= 10;
                index++;
            }

            return index;
        }
    }
}