using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.LinkedList
{
    class Insertnodespecificpositionlinkedlist
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

        class SinglyLinkedList
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

        public static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
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

        public static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            if (head == null)
            {
                head = new SinglyLinkedListNode(data);
                return head;
            }

            SinglyLinkedListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            SinglyLinkedListNode n = new SinglyLinkedListNode(data);
            current.next = n;
            return head;
        }

        public static SinglyLinkedListNode InsertNodeAtPosition(
            SinglyLinkedListNode llist, int data, int position)
        {
            if (position == 0)
                return insertNodeAtHead(llist, data);

               

            // Reach at the index
            SinglyLinkedListNode current = llist;
            int i = 0;
            while(current != null)
            {
                if (i == position - 1)
                {
                    // Create new node
                    SinglyLinkedListNode node = new SinglyLinkedListNode(data);
                    // we are at previous node before index
                    SinglyLinkedListNode temp = current.next;
                    current.next = node;
                    // current's previous's next should be new node
                    node.next = temp;
                    return llist;
                }
                if (position == i)
                    return insertNodeAtTail(llist, data);

                current = current.next;
                i++;
            }
            return null;
        }

        public static void Test()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = 3;

            //for (int i = 0; i < llistCount; i++)
            //{
            //    int llistItem = Convert.ToInt32(Console.ReadLine());
            //    llist.InsertNode(llistItem);
            //}
            llist.InsertNode(16);
            llist.InsertNode(13);
            llist.InsertNode(7);


            int data = 1;

            int position = 2;

            SinglyLinkedListNode llist_head = InsertNodeAtPosition(llist.head, data, position);

            PrintSinglyLinkedList(llist_head, " ");
            Console.WriteLine();
        }
    }
}
