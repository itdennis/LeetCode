﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    
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
        private long ListNodeConvert2Num(ListNode node)
        {
            long result = 0;
            Stack nodes = new Stack();
            while (node != null)
            {
                nodes.Push(node.val);
                node = node.next;
            }
            while (nodes.Count > 0)
            {
                int a = nodes.Count;
                result += ((int)nodes.Pop() * (long)Math.Pow(10, a - 1));
            }

            return result;
        }

        //num = 111;
        private ListNode NumConvert2ListNode(long num)
        {
            Queue queue = QueueCacheCreator(num);
            ListNode headNode = null;
            if (queue.Count > 0)
            {
                var tempValue = queue.Dequeue();
                headNode = new ListNode(Convert.ToInt32(tempValue));
            }
            ListNode listNode = ListNodeCreator(headNode, queue);
            return listNode;
        }
        private Queue QueueCacheCreator(long num)
        {
            Queue queue = new Queue();
            if (num == 0)
            {
                queue.Enqueue(num % 10);
            }
            while (num > 0)
            {
                queue.Enqueue(num % 10);
                num = num / 10;
            }
            return queue;
        }
        private ListNode ListNodeCreator(ListNode node, Queue queue)
        {
            if (queue.Count > 0)
            {
                node.next = new ListNode(Convert.ToInt32(queue.Dequeue()));
                ListNodeCreator(node.next, queue);
            }
            return node;
        }
    }
}