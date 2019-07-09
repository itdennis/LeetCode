using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase3();
        }
        /// <summary>
        /// not pass
        /// </summary>
        private static void TestCase2()
        {
            ListNode node1 = new ListNode(2);
            ListNode node2 = new ListNode(4);
            ListNode node3 = new ListNode(3);
            node1.next = node2;
            node2.next = node3;

            ListNode nodeA = new ListNode(5);
            ListNode nodeB = new ListNode(6);
            ListNode nodeC = new ListNode(4);
            nodeA.next = nodeB;
            nodeB.next = nodeC;

            Solution_2_AddTwoNumbers solution_2_AddTwoNumbers = new Solution_2_AddTwoNumbers();
            solution_2_AddTwoNumbers.AddTwoNumbers(node1, nodeA);
        }

        private static void TestCase3()
        {
            Solution_7_ReverseInt solution_7_ReverseInt = new Solution_7_ReverseInt();
            solution_7_ReverseInt.Reverse(100);
        }
    }
}
