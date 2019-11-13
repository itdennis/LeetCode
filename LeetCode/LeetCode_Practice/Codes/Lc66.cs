using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Practice.Codes
{
    public class Lc66 : LeetCode
    {
        public override void Run()
        {
            PlusOne(new int[] { 9, 9 });
        }

        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0)
            {
                return new int[] { };
            }

            int[] res = new int[digits.Length + 1];
            bool isBreak = false;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var temp = digits[i] + 1;
                if (temp >= 10)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = temp;
                    isBreak = true;
                    break;
                }
            }
            if (isBreak)
            {
                return digits;
            }

            if (digits[0] == 0)
            {
                res[0] = 1;
                for (int i = 0; i < digits.Length; i++)
                {
                    res[i + 1] = digits[i];
                }
            }

            return res;
        }
    }
}
