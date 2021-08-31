package com.saqibrazzaq.LinkedList;

import java.io.IOException;

public class Mergetwosortedlinkedlists {
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

    public static void printSinglyLinkedList(SinglyLinkedListNode node, String sep) throws IOException {
        while (node != null) {
            System.out.print(String.valueOf(node.data));

            node = node.next;

            if (node != null) {
                System.out.print(sep);
            }
        }
    }

    // Complete the mergeLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        SinglyLinkedList merged = new SinglyLinkedList();

        SinglyLinkedListNode current1 = head1;
        SinglyLinkedListNode current2 = head2;

        while (true)
        {
            // If list 1 is empty, list 2 has items, keep adding list 2
            if (current1 == null && current2 != null)
            {
                merged.insertNode(current2.data);
                current2 = current2.next;
            }
            // If list 2 is empty, list 1 has items, keep adding list 1
            else if (current1 != null && current2 == null)
            {
                merged.insertNode(current1.data);
                current1 = current1.next;
            }
            // If both list have items
            // List 1 item is less or equal
            else if (current1.data <= current2.data)
            {
                merged.insertNode(current1.data);
                // traverse next of list 1
                if (current1 != null) current1 = current1.next;
            }
            else
            {
                // list 1 item is bigger, add from list 2
                merged.insertNode(current2.data);
                // process next in list 2
                if (current2 != null) current2 = current2.next;
            }
            // Break the loop if both lists are processed
            if (current1 == null && current2 == null) break;
        }

        return merged.head;
    }

    public static void main(String[] args) throws IOException {
        int tests = 1;

        for (int testsItr = 0; testsItr < tests; testsItr++) {
            SinglyLinkedList llist1 = new SinglyLinkedList();

            int llist1Count = 3;
            llist1.insertNode(1);
            llist1.insertNode(2);
            llist1.insertNode(3);

            SinglyLinkedList llist2 = new SinglyLinkedList();

            int llist2Count = 2;
            llist2.insertNode(3);
            llist2.insertNode(4);

            SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

            printSinglyLinkedList(llist3, " ");
            System.out.println();
        }


    }
}
