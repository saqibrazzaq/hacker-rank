package com.saqibrazzaq.LinkedList;


import java.io.IOException;

public class Deleteduplicatevaluenodesfromsortedlinkedlist {
    private static class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    private static class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void insertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    private static class SinglyLinkedListPrintHelper {
        public static void printList(SinglyLinkedListNode node, String sep) throws IOException {
            while (node != null) {
                System.out.print(String.valueOf(node.data));

                node = node.next;

                if (node != null) {
                    System.out.print(sep);
                }
            }
        }
    }

    public static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode llist) {
        SinglyLinkedList list = new SinglyLinkedList();
        SinglyLinkedListNode current = llist;

        // Traverse the whole list
        while (current.next != null)
        {
            // If current and next are same, delete current
            if (current.data != current.next.data)
            {
                list.insertNode(current.data);
            }
            current = current.next;
        }
        if (current != null)
            list.insertNode(current.data);

        return list.head;
    }

    public static void main(String[] args) throws IOException {
        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = 5;

        llist.insertNode(1);
        llist.insertNode(2);
        llist.insertNode(2);
        llist.insertNode(3);
        llist.insertNode(3);
        llist.insertNode(4);
        llist.insertNode(4);
        llist.insertNode(4);
        llist.insertNode(5);

        SinglyLinkedListNode llist1 = removeDuplicates(llist.head);

        SinglyLinkedListPrintHelper.printList(llist1, " ");
        System.out.println();
    }
}
