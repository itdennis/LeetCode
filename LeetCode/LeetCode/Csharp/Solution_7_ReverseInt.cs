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

            while (x != 0)
            {
                int tail = x % 10;
                int newResult = result * 10 + tail;
                if ((newResult - tail) / 10 != result)
                { return 0; }
                result = newResult;
                x = x / 10;
            }

            return result;
        }
    }
}
