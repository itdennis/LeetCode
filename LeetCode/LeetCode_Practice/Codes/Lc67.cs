using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Practice.Codes
{
    public class Lc67 : LeetCode
    {
        public override void Run()
        {
            String a = "1010";
            String b = "1011";
            AddBinary(a, b);
        }

        public string AddBinary(string a, string b)
        {
            int aLen = a.Length;
            int bLen = b.Length;
            int maxLen = Math.Max(aLen, bLen);

            var reversedA = new string(a.ToString().Reverse().ToArray());
            var reversedB = new string(b.ToString().Reverse().ToArray());

            StringBuilder sbA = new StringBuilder(reversedA);
            StringBuilder sbB = new StringBuilder(reversedB);

            // 让两个字符补齐成一样的长度
            while (sbA.Length < maxLen)
            {
                sbA.Append("0");
            }
            while (sbB.Length < maxLen)
            {
                sbB.Append("0");
            }

            StringBuilder res = new StringBuilder();

            int carry = 0;
            int num1;
            int num2;
            for (int i = 0; i < maxLen; i++)
            {
                num1 = sbA[i] - '0';
                num2 = sbB[i] - '0';
                if (carry + num1 + num2 > 1)
                {

                }

            }

            return res.ToString().Reverse().ToString();

        }
    }
}
