using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution_7_ReverseInt
    {
        public int Reverse(int input)
        {
            int originNum = input;
            Int32 x = Math.Abs(input);
            int result = 0;
            bool isZhengInt = true;
            if (originNum < 0)
            {
                isZhengInt = false;
            }
            Queue<int> nodes = new Queue<int>();
            while (x > 0)
            {
                bool needBreakIntoNext = false;
                int a = 0;
                while (!needBreakIntoNext)
                {
                    if (x / (Math.Pow(10, a)) < 10)
                    {
                        int currentNum = x / (int)(Math.Pow(10, a));
                        nodes.Enqueue(currentNum);
                        x = x - (currentNum * (int)Math.Pow(10, a));
                        needBreakIntoNext = true;
                    }
                    else
                    {
                        a++;
                    }
                }
            }

            if (nodes.Count > 0)
            {
                int a = 0;
                while (nodes.Count > 0)
                {
                    result += nodes.Dequeue() * (int)Math.Pow(10, a);
                    a++;
                }
                if (!isZhengInt)
                {
                    result = 0 - result;
                }
            }
            return result;
        }
    }
}
