package com.saqibrazzaq.Stack;

import java.util.LinkedList;

public class MyStack<T> {
    // Internally it is a linked list
    LinkedList<T> list;
    // Constructor
    public MyStack() {
        list = new LinkedList<T>();
    }

    // Size of stack
    public int size() {
        return list.size();
    }

    // Check if empty
    public boolean isEmpty() {
        return list.isEmpty();
    }

    // Push an item in stack
    public void push(T item) {
        // Add item at last in the linked list
        list.addLast(item);
    }

    // Pop an item from the stack
    public T pop() throws Exception {
        // If list is empty, throw exception
        if (list.isEmpty() == true)
            throw new Exception("Cannot pop item from an empty stack");
        // Remove the last item from the linked list and return it
        return list.removeLast();
    }

    // Peek item from stack
    public T peek() throws Exception {
        // If list is empty, throw exception
        if (list.isEmpty() == true)
            throw new Exception("Cannot peek item from an empty stack");
        // Peek the last item from the linked list
        return list.peekLast();
    }
}
