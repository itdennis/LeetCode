using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Practice.Codes
{
    public class Lc70 : LeetCode
    {
        public override void Run()
        {
            ClimbStairs(46);
        }

        /// <summary>
        /// 此题属于动态规划问题,也可以说是菲波那切数列.
        /// 达到dp(n)的方式是达到dp(n-1)+dp(n-2)的方式和, 所以有dp(n) = dp(n-1) + dp(n-2):
        ///     n: 0,1,2,3,4,5....
        /// count: 1,1,2,3,5,8....
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
            //var count = Climb_Stairs(0, n);
            //return count;
        }
        /// <summary>
        /// current and target is the key point for this requirment.
        /// the edge is current > target and current = target
        /// if current > target, count = 0, prove this path is invalid path.
        /// if current = target, count = 1, prove this path is valid path.
        /// pass i+1 and i+2 as the current for every iteration, because every current has two choice for the future step.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Climb_Stairs(int current, int target) 
        {
            if (current > target)
            {
                return 0;
            }
            if (current == target)
            {
                return 1;
            }

            return Climb_Stairs(current + 1, target) + Climb_Stairs(current + 2, target);
        }
    }
}
