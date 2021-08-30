using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.LinkedList
{
    class Insertnodeheadlinkedlist
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
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
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

        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            if (llist == null)
            {
                llist = new SinglyLinkedListNode(data);
                return llist;
            }

            // create new node
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);
            node.next = llist;
            return node;

        }

        public static void Test()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = 5;

            //for (int i = 0; i < llistCount; i++)
            //{
            //    int llistItem = Convert.ToInt32(Console.ReadLine());
            //    SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
            //    llist.head = llist_head;
            //}

            SinglyLinkedListNode llist_head;
            llist_head = insertNodeAtHead(llist.head, 383);
            llist.head = llist_head;
            llist_head = insertNodeAtHead(llist.head, 484);
            llist.head = llist_head;
            llist_head = insertNodeAtHead(llist.head, 392);
            llist.head = llist_head;
            llist_head = insertNodeAtHead(llist.head, 975);
            llist.head = llist_head;
            llist_head = insertNodeAtHead(llist.head, 321);
            llist.head = llist_head;

            PrintSinglyLinkedList(llist.head, "\n");
            Console.WriteLine();
        }
    }
}
