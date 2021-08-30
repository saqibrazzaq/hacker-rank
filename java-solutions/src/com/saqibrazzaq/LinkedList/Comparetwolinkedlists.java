package com.saqibrazzaq.LinkedList;

import java.io.IOException;

public class Comparetwolinkedlists {

    static class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    static class SinglyLinkedList {
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
            System.out.println(String.valueOf(node.data));

            node = node.next;

            if (node != null) {
                System.out.println(sep);
            }
        }
    }

    static boolean compareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        SinglyLinkedListNode current1 = head1;
        SinglyLinkedListNode current2 = head2;
        // Traverse the first list
        while(current1 != null) {
            if (current2 == null) return false;

            if (current1.data != current2.data)
                return false;

            current1 = current1.next;
            current2 = current2.next;
        }
        return true;
    }

    public static void main(String[] args) {
        SinglyLinkedList llist1 = new SinglyLinkedList();
        llist1.insertNode(1);
        llist1.insertNode(2);
        llist1.insertNode(3);
        llist1.insertNode(4);

        SinglyLinkedList llist2 = new SinglyLinkedList();
        llist2.insertNode(1);
        llist2.insertNode(2);
        llist2.insertNode(3);

        boolean result = compareLists(llist1.head, llist2.head);
        System.out.println(String.valueOf(result ? 1 : 0));
    }
}
