using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.LinkedList
{
    class DeleteNode
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

        public static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
        {
            // Delete head
            if (position == 0)
            {
                SinglyLinkedListNode node = llist;
                llist = llist.next;
                node = null;
                return llist;
            }

            // Reach at position
            SinglyLinkedListNode current = llist;
            int i = 0;
            while(current.next != null)
            {
                SinglyLinkedListNode node;
                // If it is last node
                if (i == position - 1)
                {
                    // get next node, which is to be deleted
                    node = current.next;
                    // If node is not null, get it's next
                    if (node != null)
                    {
                        current.next = node.next;
                    }
                    else
                    {
                        // It must be the last node
                        current.next = null;
                    }
                    return llist;
                }
                current = current.next;
                i++;
            }
            return llist;
        }

        public static void Test()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = 8;

            //for (int i = 0; i < llistCount; i++)
            //{
            //    int llistItem = Convert.ToInt32(Console.ReadLine());
            //    llist.InsertNode(llistItem);
            //}
            llist.InsertNode(20);
            llist.InsertNode(6);
            llist.InsertNode(2);
            llist.InsertNode(19);
            llist.InsertNode(7);
            llist.InsertNode(4);
            llist.InsertNode(15);
            llist.InsertNode(9);

            int position = 3;

            SinglyLinkedListNode llist1 = deleteNode(llist.head, position);

            PrintSinglyLinkedList(llist1, " ");
            Console.WriteLine();
        }
    }
}
