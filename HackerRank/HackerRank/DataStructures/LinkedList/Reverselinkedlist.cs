using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.LinkedList
{
    class Reverselinkedlist
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

        public static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }

        

        public static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
        {
            Stack<int> s = new Stack<int>();
            SinglyLinkedListNode current = llist;
            while(current != null)
            {
                s.Push(current.data);
                current = current.next;
            }
            SinglyLinkedList lst = new SinglyLinkedList();
            while(s.Count > 0)
            {
                lst.InsertNode(s.Pop());
            }
            return lst.head;
        }

        public static void Test()
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            llist.InsertNode(1);
            llist.InsertNode(2);
            llist.InsertNode(3);
            llist.InsertNode(4);
            llist.InsertNode(5);
            SinglyLinkedListNode llist1 = reverse(llist.head);

            PrintSinglyLinkedList(llist1, " ");
        }
    }
}
