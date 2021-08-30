using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.LinkedList
{
    class InsertNodeTailLinkedList
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;

            public SinglyLinkedList()
            {
                this.head = null;
            }

        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
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
        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            if (head == null)
            {
                head = new SinglyLinkedListNode(data);
                return head;
            }

            SinglyLinkedListNode current = head;
            while(current.next != null)
            {
                current = current.next;
            }
            SinglyLinkedListNode n = new SinglyLinkedListNode(data);
            current.next = n;
            return head;
        }
        public static void Test()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = 5;

            //for (int i = 0; i < llistCount; i++)
            //{
            //    int llistItem = Convert.ToInt32(Console.ReadLine());
            //    SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
            //    llist.head = llist_head;

            //}
            SinglyLinkedListNode llist_head;

            llist_head = insertNodeAtTail(llist.head, 141);
            llist.head = llist_head;
            llist_head = insertNodeAtTail(llist.head, 302);
            llist.head = llist_head;
            llist_head = insertNodeAtTail(llist.head, 164);
            llist.head = llist_head;
            llist_head = insertNodeAtTail(llist.head, 530);
            llist.head = llist_head;
            llist_head = insertNodeAtTail(llist.head, 474);
            llist.head = llist_head;


            PrintSinglyLinkedList(llist.head, "\n");
            Console.WriteLine();
        }
    }
}
