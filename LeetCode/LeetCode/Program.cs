using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase2();
        }
        /// <summary>
        /// not pass
        /// </summary>
        private static void TestCase2()
        {
            //Console.WriteLine($"plz input list nodes 1, split with ,");
            //string listNodeFirst = Console.ReadLine();
            //string[] listNodeFirstCache = listNodeFirst.Split(',');
            //[1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1]
            ListNode node = new ListNode(5);
            ListNode nodea = new ListNode(6);
            ListNode nodeb = new ListNode(4);
            node.next = nodea;
            nodea.next = nodeb;

            ListNode node0 = new ListNode(1);
            ListNode node1 = new ListNode(0);
            ListNode node2 = new ListNode(0);
            ListNode node3 = new ListNode(0);
            ListNode node4 = new ListNode(0);
            ListNode node5 = new ListNode(0);
            ListNode node6 = new ListNode(0);
            ListNode node7 = new ListNode(0);
            ListNode node8 = new ListNode(0);
            ListNode node9 = new ListNode(0);
            ListNode node10 = new ListNode(0);
            ListNode node11 = new ListNode(0);
            ListNode node12 = new ListNode(0);
            ListNode node13 = new ListNode(0);
            ListNode node14 = new ListNode(0);
            ListNode node15 = new ListNode(0);
            ListNode node16 = new ListNode(0);
            ListNode node17 = new ListNode(0);
            ListNode node18 = new ListNode(0);
            ListNode node19 = new ListNode(0);
            ListNode node20 = new ListNode(0);
            ListNode node21 = new ListNode(0);
            ListNode node22 = new ListNode(0);
            ListNode node23 = new ListNode(0);
            ListNode node24 = new ListNode(0);
            ListNode node25 = new ListNode(0);
            ListNode node26 = new ListNode(0);
            ListNode node27 = new ListNode(0);
            ListNode node28 = new ListNode(0);
            ListNode node29 = new ListNode(0);
            ListNode node30 = new ListNode(1);
            node0.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;
            node7.next = node8;
            node8.next = node9;
            node9.next = node10;
            node10.next = node11;
            node11.next = node12;
            node12.next = node13;
            node13.next = node14;
            node14.next = node15;
            node15.next = node16;
            node16.next = node17;
            node17.next = node18;
            node18.next = node19;
            node19.next = node20;
            node20.next = node21;
            node21.next = node22;
            node22.next = node23;
            node23.next = node24;
            node24.next = node25;
            node25.next = node26;
            node26.next = node27;
            node27.next = node28;
            node28.next = node29;
            node29.next = node30;
            LeetCode.OthersAnswer.Solution_2_AddTwoNumbers solution_2_AddTwoNumbers = new LeetCode.OthersAnswer.Solution_2_AddTwoNumbers();
            solution_2_AddTwoNumbers.AddTwoNumbers(node, node0);
        }

        private static void TestCase3()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("plz input:");
                    var input = Console.ReadLine();
                    if (input.Equals("break"))
                    {
                        break;
                    }
                    Solution_7_ReverseInt solution_7_ReverseInt = new Solution_7_ReverseInt();
                    int inputNum = int.Parse(input);
                    Console.WriteLine("result is:");
                    Console.WriteLine(solution_7_ReverseInt.Reverse(inputNum)); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
