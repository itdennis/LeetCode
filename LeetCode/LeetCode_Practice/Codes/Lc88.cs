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
            Merge(new int[] {2,0}, 1, new int[] { 1 },1);
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums2.Length == 0)
            {
                return;
            }

            int[] temp = new int[m];

            for (int i = 0; i < m; i++)
            {
                temp[i] = nums1[i];
            }

            int indexOfTemp= 0, indexOfNum2 = 0;
            for (int i = 0; i < m+n; i++)
            {
                if (indexOfTemp >= m)
                {
                    nums1[i] = nums2[indexOfNum2];
                    indexOfNum2++;
                    continue;
                }
                if (indexOfNum2 >= n)
                {
                    nums1[i] = temp[indexOfTemp];
                    indexOfTemp++;
                    continue;
                }

                if (temp[indexOfTemp] >= nums2[indexOfNum2])
                {
                    nums1[i] = nums2[indexOfNum2];
                    indexOfNum2++;
                    continue;
                }

                if (temp[indexOfTemp] < nums2[indexOfNum2])
                {
                    nums1[i] = temp[indexOfTemp];
                    indexOfTemp++;
                    continue;
                }
            }
        }
    }
}
