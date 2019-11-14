using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Practice.Codes
{
    public class Lc83 : LeetCode
    {
        public override void Run()
        {
            ListNode node1 = new ListNode(1);
            
            ListNode node11 = new ListNode(1);

            ListNode node111 = new ListNode(1);

            node1.next = node11;
            node11.next = node111;
            
            ListNode node2 = new ListNode(2);

            ListNode node3 = new ListNode(3);

            ListNode node33 = new ListNode(3);

            node111.next = node2;
            node2.next = node3;
            node3.next = node33;


            var res = DeleteDuplicates(node1);
        }
        /// <summary>
        /// current和head指向的是同一个地址，current用来操作列表，去除重复的。最后返回列表的最开始的地址，即头部head
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }

    }
}
