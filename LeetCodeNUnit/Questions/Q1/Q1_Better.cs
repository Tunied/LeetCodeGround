using System.Collections;
using NUnit.Framework;

namespace LeetCodeNUnit.Questions.Q1
{
    /// <summary>
    /// 使用HashtableCache结果,减少两遍For循环
    /// </summary>
    public class Q1_Better
    {
        [Test]
        public static void TestQ1()
        {
            var q1 = new Q1_Better();
            var array = new[] {3, 2, 3};
            var result = q1.TwoSum(array, 6);
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
            Assert.AreEqual(array[result[0]] + array[result[1]], 6);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length <= 1) return null;

            var cache = new Hashtable();
            var length = nums.Length;
            for (var i = 0; i < length; i++)
            {
                var need = target - nums[i];
                if (cache.ContainsKey(need))
                {
                    return new[] {i, (int) cache[need]};
                }

                if (!cache.ContainsKey(nums[i]))
                {
                    cache.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}