using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
 /*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */
    public class Solution_1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
