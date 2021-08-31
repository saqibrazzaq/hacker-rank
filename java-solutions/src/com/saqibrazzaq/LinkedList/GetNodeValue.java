package com.saqibrazzaq.LinkedList;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class GetNodeValue {
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

    public static int getNode(SinglyLinkedListNode llist, int positionFromTail) {
        // Write your code here
        int size = 0;
        // Store items in the array
        List<Integer> arr = new ArrayList<>();

        SinglyLinkedListNode current = llist;
        // Traverse the linked list till the end, to measure the size
        while (current != null)
        {
            arr.add(current.data);
            size++;
            current = current.next;
        }

        return arr.get(size - positionFromTail - 1);
    }

    public static void main(String[] args) throws IOException {
        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = 3;
//        llist.insertNode(3);
//        llist.insertNode(2);
        llist.insertNode(1);

        int position = 0;

        int result = getNode(llist.head, position);

        System.out.print(String.valueOf(result));
        System.out.println();
    }
}
