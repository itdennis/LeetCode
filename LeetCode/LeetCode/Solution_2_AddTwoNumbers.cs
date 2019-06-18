using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Solution_2_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //input validation
            if (l1 == null || l2 == null)
            {
                return null;
            }
            var l1Result = ListNodeConvert2Num(l1);
            var l2Result = ListNodeConvert2Num(l2);
            var output = l1Result + l2Result;
            return NumConvert2ListNode(output);
        }
        private int ListNodeConvert2Num(ListNode node)
        {
            int result = 0;
            Stack nodes = new Stack();
            while (node != null)
            {
                nodes.Push(node.val);
                node = node.next;
            }
            while (nodes.Count > 0)
            {
                int a = nodes.Count;
                result += ((int)nodes.Pop() * (int)Math.Pow(10, a -1));
            }

            return result;
        }

        //num = 111;
        private ListNode NumConvert2ListNode(int num)
        {
            Stack nodes = new Stack();
            while (num > 0)
            {
                int a = 1;
                while (num % (Math.Pow(10, a)) > 10)
                {
                    a++;
                }
                int currentNum = num / (int)(Math.Pow(10, a));
                nodes.Push(currentNum);
                num = num - (currentNum * (int)Math.Pow(10, a));
            }
            ListNode node = null;
            if (nodes.Count > 0)
            {
                node = new ListNode((int)nodes.Pop());
                while (nodes.Count > 0)
                {
                    node.val = (int)nodes.Pop();
                    node = node.next;
                }
            }
            return node;
        }
    }
}
