namespace LeetCodeNUnit.Questions.Q1
{
    /// <summary>
    /// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的 两个 整数。
    /// 你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
    /// 
    /// 示例:
    ///    给定 nums = [2, 7, 11, 15], target = 9
    ///    因为 nums[0] + nums[1] = 2 + 7 = 9
    ///    所以返回 [0, 1]
    /// </summary>
    public class Q1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length <= 1) return null;

            var length = nums.Length;
            for (int i = 1; i < length; i++)
            {
                var a = nums[i - 1];
                var index = IsContain(i, target - a, ref nums);
                if (index > 0)
                {
                    return new[] {i - 1, index};
                }
            }

            return null;
        }

        private int IsContain(int _sIndex, int _findNum, ref int[] _targetArray)
        {
            var length = _targetArray.Length;
            for (var i = _sIndex; i < length; i++)
            {
                if (_targetArray[i] == _findNum) return i;
            }

            return -1;
        }
    }
}