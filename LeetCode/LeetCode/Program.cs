using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(9);
            //ListNode node2 = new ListNode(9);
            //ListNode node3 = new ListNode(9);
            //node1.next = node2;
            //node2.next = node3;

            ListNode nodeA = new ListNode(1);
            ListNode nodeB = new ListNode(9);
            ListNode nodeC = new ListNode(9);
            ListNode nodeD = new ListNode(9);
            ListNode nodeE = new ListNode(9);
            ListNode nodeF = new ListNode(9);
            ListNode nodeG = new ListNode(9);
            ListNode nodeH = new ListNode(9);
            ListNode nodeI = new ListNode(9);
            nodeA.next = nodeB;
            nodeB.next = nodeC;
            nodeC.next = nodeD;
            nodeD.next = nodeE;
            nodeE.next = nodeF;
            nodeF.next = nodeG;
            nodeG.next = nodeH;
            nodeH.next = nodeI;

            Solution_2_AddTwoNumbers solution_2_AddTwoNumbers = new Solution_2_AddTwoNumbers();
            solution_2_AddTwoNumbers.AddTwoNumbers(node1, nodeA);
        }
    }
}
