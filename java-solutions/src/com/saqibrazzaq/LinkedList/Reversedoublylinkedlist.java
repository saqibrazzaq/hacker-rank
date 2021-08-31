package com.saqibrazzaq.LinkedList;

import java.io.IOException;
import java.util.Stack;

public class Reversedoublylinkedlist {
    private static class DoublyLinkedListNode {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    private static class DoublyLinkedList {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void insertNode(int nodeData) {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    private class DoublyLinkedListPrintHelper {
        public static void printList(DoublyLinkedListNode node, String sep) throws IOException {
            while (node != null) {
                System.out.print(String.valueOf(node.data));

                node = node.next;

                if (node != null) {
                    System.out.print(sep);
                }
            }
        }
    }

    public static DoublyLinkedListNode reverse(DoublyLinkedListNode llist) {
        // Use stack to store items in linked list
        Stack<Integer> stack = new Stack<>();
        // Traverse all items in the list
        DoublyLinkedListNode current = llist;
        while (current != null) {
            stack.push(current.data);
            current = current.next;
        }

        DoublyLinkedList revList = new DoublyLinkedList();
        while (stack.size() > 0) {
            revList.insertNode(stack.pop());
        }
        return revList.head;
    }

    public static void main(String[] args) throws IOException {

        DoublyLinkedList llist = new DoublyLinkedList();
        llist.insertNode(1);
        llist.insertNode(2);
        llist.insertNode(3);
        llist.insertNode(4);

        DoublyLinkedListNode llist1 = reverse(llist.head);

        DoublyLinkedListPrintHelper.printList(llist1, " ");
        System.out.println();
    }
}
