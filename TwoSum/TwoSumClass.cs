using System;

namespace TwoSum
{
    public class TwoSumClass
    {
        public static void Main()
        {

        }

        public int[] CalculateTwoSum(int[] nums, int target)
        {
            int[] answer = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
            }
            return answer;
        }
    }
}
