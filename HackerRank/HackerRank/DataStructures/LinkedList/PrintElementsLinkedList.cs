using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.LinkedList
{
    class PrintElementsLinkedList
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
        static void printLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode current = head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

        }
        public static void Test()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = 2;

            //for (int i = 0; i < llistCount; i++)
            //{
            //    int llistItem = Convert.ToInt32(Console.ReadLine());
            //    llist.InsertNode(llistItem);
            //}
            llist.InsertNode(16);
            llist.InsertNode(13);

            printLinkedList(llist.head);
        }
    }
}
