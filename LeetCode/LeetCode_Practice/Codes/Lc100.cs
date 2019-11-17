using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Practice.Codes
{
    public class Lc100 : LeetCode
    {
        TreeNode a = new TreeNode(1);
        TreeNode aL = new TreeNode(2);
        TreeNode aR = new TreeNode(3);

        TreeNode b = new TreeNode(1);
        TreeNode bL = new TreeNode(2);
        TreeNode bR = new TreeNode(3);

        public override void Run()
        {
            a.left = aL;
            //a.right = aR;
            b.left = null;
            b.right = bR;

            IsSameTree(a, b);
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            var res = false;
            if (p == null && q != null)
                return res;

            if (q == null && p != null)
                return res;

            if (p == null && q == null)
                return true;

            List<int?> pArray = new List<int?>();
            ConvertTree2Array(p, ref pArray);
            List<int?> qArray = new List<int?>();
            ConvertTree2Array(q, ref qArray);

            if (pArray.Count == qArray.Count)
            {
                bool flag4Diff = false;
                for (int i = 0; i < pArray.Count; i++)
                {
                    if (pArray[i] != qArray[i])
                    {
                        flag4Diff = true;
                        break;
                    }
                }
                if (!flag4Diff)
                {
                    res = true;
                }
            }
            return res;
        }

        private void ConvertTree2Array(TreeNode p, ref List<int?> array)
        {
            if (p == null)
            {
                array.Add(null);
                return;
            }

            array.Add(p.val);
            ConvertTree2Array(p.left, ref array);
            ConvertTree2Array(p.right, ref array);

        }

        public bool isSameTreeOnline(TreeNode p, TreeNode q)
        {
            // p and q are both null
            if (p == null && q == null) return true;
            // one of p and q is null
            if (q == null || p == null) return false;
            if (p.val != q.val) return false;
            return isSameTreeOnline(p.right, q.right) &&
                    isSameTreeOnline(p.left, q.left);
        }
    }
}
