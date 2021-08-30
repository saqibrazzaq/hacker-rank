using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.LinkedList
{
    
    class PrintReverse
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        public class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        public class SinglyLinkedListPrintHelper
        {
            public static void printList(SinglyLinkedListNode node, String sep)
            {
                while (node != null)
                {
                    Console.WriteLine(node.data);

                    node = node.next;

                    if (node != null)
                    {
                        Console.WriteLine(sep);
                    }
                }
            }
        }
        public static void reversePrint(SinglyLinkedListNode llist)
        {
            // Write your code here
            // Keep adding in stack
            Stack<int> s = new Stack<int>();
            while(llist != null)
            {
                s.Push(llist.data);
                llist = llist.next;
            }
            while(s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }
        }

        public static void Test()
        {
            int tests = 3;

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                //int llistCount = Convert.ToInt32(Console.ReadLine());

                //for (int i = 0; i < llistCount; i++)
                //{
                //    int llistItem = Convert.ToInt32(Console.ReadLine());
                //    llist.InsertNode(llistItem);
                //}
                llist.InsertNode(5);
                llist.InsertNode(16);
                llist.InsertNode(12);
                llist.InsertNode(4);
                llist.InsertNode(2);
                reversePrint(llist.head);
            }
        }
    }
}
