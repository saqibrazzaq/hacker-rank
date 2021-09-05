package com.saqibrazzaq.Stack;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Stack;

public class MaximumElement {
    public static List<Integer> getMax(List<String> operations) {
        Stack<Integer> stack = new Stack<>();
        List<Integer> result = new ArrayList<>() {  };
        Stack<Integer> maxStack = new Stack<>();

        for (int i = 0; i < operations.size(); i++) {
            String cmd = operations.get(i);
            if (cmd.startsWith("1")) {
                // Push in stack if empty
                int num = Integer.parseInt(cmd.split(" ")[1]);
                if (stack.isEmpty())
                    stack.push(num);
                else
                    // if not empty, only push max element, so that max is always on top
                    stack.push(Math.max(num, stack.peek()));
            } else if (cmd.equals("2")) {
                // Pop from stack
                if (stack.isEmpty() == false)
                    stack.pop();
            } else if (cmd.equals("3")) {
                // Print the maximum element in the stack
                result.add(stack.peek());
            }
        }

        return result;
    }

    public static void main(String[] args) throws IOException {
        int n = 10;

        List<String> ops = new ArrayList<>();
        ops.add("1 97");
//        ops.add("2");
        ops.add("1 20");
//        ops.add("2");
        ops.add("1 26");
        ops.add("1 20");
//        ops.add("2");
        ops.add("3");
        ops.add("1 99");
        ops.add("3");

        List<Integer> res = getMax(ops);

        res.forEach(System.out::println);
    }
}
