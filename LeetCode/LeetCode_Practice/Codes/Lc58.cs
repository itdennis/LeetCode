using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Practice.Codes
{
    public class Lc58 : LeetCode
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            var res = s.Length - s.LastIndexOf(' ') -1;
            return res;
        }

        public override void Run()
        {
            LengthOfLastWord("Hello ");
        }
    }
}
