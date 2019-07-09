using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution_7_ReverseInt
    {
        public int Reverse(int x)
        {
            int result = 0;
            Stack<int> nodes = new Stack<int>();
            while (x > 0)
            {
                int a = 1;
                while (x % (Math.Pow(10, a)) > 10)
                {
                    a++;
                }
                int currentNum = x / (int)(Math.Pow(10, a));
                nodes.Push(currentNum);
                x = x - (currentNum * (int)Math.Pow(10, a));
            }
            return result;
        }
    }
}
