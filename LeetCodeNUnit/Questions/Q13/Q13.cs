using NUnit.Framework;

namespace LeetCodeNUnit.Questions.Q13
{
    public class Q13
    {
        [Test]
        public static void Test()
        {
            var q = new Q13();
            Assert.AreEqual(q.RomanToInt("III"), 3);
            Assert.AreEqual(q.RomanToInt("IV"), 4);
            Assert.AreEqual(q.RomanToInt("IX"), 9);
            Assert.AreEqual(q.RomanToInt("LVIII"), 58);
            Assert.AreEqual(q.RomanToInt("MCMXCIV"), 1994);
        }


        public int RomanToInt(string s)
        {
            var result = 0;
            var prev = default(char);
            var cArray = s.ToCharArray();
            for (var i = cArray.Length - 1; i >= 0; i--)
            {
                result += GetRomanCharValue(cArray[i], prev);
                prev = cArray[i];
            }

            return result;
        }

        /// <summary>
        /// I             1
        /// V             5
        /// X             10
        /// L             50
        /// C             100
        /// D             500
        /// M             1000
        /// </summary>
        /// <param name="_now"></param>
        /// <param name="_prev"></param>
        /// <returns></returns>
        private int GetRomanCharValue(char _now, char _prev)
        {
            switch (_now)
            {
                case 'I':
                    return _prev == 'V' || _prev == 'X' ? -1 : 1;
                case 'V':
                    return 5;
                case 'X':
                    return _prev == 'L' || _prev == 'C' ? -10 : 10;
                case 'L':
                    return 50;
                case 'C':
                    return _prev == 'D' || _prev == 'M' ? -100 : 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }

            return 0;
        }
    }
}