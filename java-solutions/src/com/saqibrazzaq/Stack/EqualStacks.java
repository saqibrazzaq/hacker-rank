package com.saqibrazzaq.Stack;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Stack;

public class EqualStacks {
    public static int equalStacks(List<Integer> h1, List<Integer> h2, List<Integer> h3) {
        int height = 0;

        // Find sum of all numbers in each list
        int sum1 = h1.stream().mapToInt(Integer::intValue).sum();
        int sum2 = h2.stream().mapToInt(Integer::intValue).sum();
        int sum3 = h3.stream().mapToInt(Integer::intValue).sum();

        // Find out whose sum is minimum
        int min = sum3;
        if (min > sum2) min = sum2;
        if (min > sum1) min = sum1;

        Stack<Integer> stack1 = addInStack(h1, min);
        Stack<Integer> stack2 = addInStack(h2, min);
        Stack<Integer> stack3 = addInStack(h3, min);

        sum1 = stack1.stream().mapToInt(Integer::intValue).sum();
        sum2 = stack2.stream().mapToInt(Integer::intValue).sum();
        sum3 = stack3.stream().mapToInt(Integer::intValue).sum();

        height = min;

        while (true)
        {
            // Pop from the stacks as long as sums are larger than min
            if (sum1 > min) {
                sum1 -= stack1.peek();
                stack1.pop();
            }
            if (sum2 > min) {
                sum2 -= stack2.peek();
                stack2.pop();
            }
            if (sum3 > min) {
                sum3 -= stack3.peek();
                stack3.pop();
            }

            // Sum again
//            sum1 = stack1.stream().mapToInt(Integer::intValue).sum();
//            sum2 = stack2.stream().mapToInt(Integer::intValue).sum();
//            sum3 = stack3.stream().mapToInt(Integer::intValue).sum();

            if (min > sum3) min = sum3;
            if (min > sum2) min = sum2;
            if (min > sum1) min = sum1;

            // Exit when sum of all are equal
            if (sum1 == sum2 && sum1 == sum3) {
                height = sum1;
                break;
            }

        }

        return height;
    }

    private static Stack<Integer> addInStack(List<Integer> h1, int min) {
        Stack<Integer> stack = new Stack<>();
        int sum = 0;
        for (int i = h1.size() - 1; i >= 0; i--) {
            stack.push(h1.get(i));
            sum += stack.peek();
            // break loop if sum exceeds min
            if (sum >= min) break;
        }
        return stack;
    }

    public static void main(String[] args) {
        List<Integer> h1 = new ArrayList<>(Arrays.asList(100, 100, 100, 100, 100, 3, 2, 1, 1, 1));

        List<Integer> h2 = new ArrayList<>(Arrays.asList(100, 100, 100, 100, 100, 4, 3, 2));

        List<Integer> h3 = new ArrayList<>(Arrays.asList(1, 1, 4, 1));

        int result = equalStacks(h1, h2, h3);

        System.out.println(result);
    }
}
