using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Util
    {
        public static ListNode CreateListNode(string[] nodesCache)
        {
            ListNode targetNode = new ListNode(int.Parse(nodesCache[0]));
            for (int i = 1; i < nodesCache.Length; i++)
            {
                ListNode subNode = new ListNode(int.Parse(nodesCache[i]));
                targetNode.next = subNode;

            }
            return targetNode;
        }
    }
}

