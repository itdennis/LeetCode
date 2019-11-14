using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LeetCode_Practice.Codes
{
    public class Lc88 : LeetCode
    {
        public override void Run()
        {
            Merge(new int[] { 1,2,3,0,0,0}, 3, new int[] { 2,5,6 }, 3);
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while (n > 0)
            {
                int j = 0;
                for (int i = 0; i < nums2.Length; i++)
                {
                    while (nums2[i] >= nums1[j] && j < m)
                    {
                        j++;
                    }
                    if (j < m)
                    {
                        var temp = nums1[j];
                        nums1[j] = nums2[i];
                        nums2[i] = temp;
                        j++;
                    }
                    else
                    {
                        nums1[j] = nums2[i];
                        j++;
                        n--;
                    }
                    m++;
                } 
            }
        }
    }
}
