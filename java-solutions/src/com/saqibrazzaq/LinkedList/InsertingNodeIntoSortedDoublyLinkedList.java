package com.saqibrazzaq.LinkedList;

import java.io.IOException;

public class InsertingNodeIntoSortedDoublyLinkedList {
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

    public static void printDoublyLinkedList(DoublyLinkedListNode node, String sep) throws IOException {
        while (node != null) {
            System.out.print(String.valueOf(node.data));

            node = node.next;

            if (node != null) {
                System.out.print(sep);
            }
        }
    }

    public static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data) {
        DoublyLinkedListNode current = llist;
        DoublyLinkedListNode node = new DoublyLinkedListNode(data);;
        int index = 0;
        while (current != null) {

            // If data is less than the current node
            if (data < current.data) {
                // If it is first node
                if (index == 0) {
                    node.next = current;
                    node.prev = null;
                    return node;
                }
                // It is between head and tail
                else {
                    DoublyLinkedListNode prevNode = current.prev;
                    node.next = current;
                    node.prev = prevNode;
                    current.prev = node;
                    prevNode.next = node;
                    break;
                }
            }
            // If it is last node
            else if (current.next == null) {
                node.next = null;
                node.prev = current;
                current.next = node;
                break;
            }

            current = current.next;
            index++;
        }
        return llist;
    }

    public static void main(String[] args) throws IOException {
        DoublyLinkedList llist = new DoublyLinkedList();

        int llistCount = 4;
        llist.insertNode(2);
        llist.insertNode(3);
        llist.insertNode(4);
        llist.insertNode(10);

        int data = 5;

        DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);

        printDoublyLinkedList(llist1, " ");
        System.out.println();
    }
}
