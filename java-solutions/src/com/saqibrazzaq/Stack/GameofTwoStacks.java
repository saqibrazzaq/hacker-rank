package com.saqibrazzaq.Stack;

import java.io.IOException;
import java.util.List;
import java.util.Stack;
import java.util.stream.Stream;

import static java.util.stream.Collectors.toList;

public class GameofTwoStacks {
    public static int twoStacks(int maxSum, List<Integer> a, List<Integer> b) {
        int result = 0;
        int runningSum = 0;
        int moves1 = 0;

        // Consider only a
        for (int item: a) {
            // If running sum is less than max, keep adding from a
            if (runningSum + item <= maxSum) {
                runningSum += item;
                moves1++;
            } else {
                // Save moves from a in result

                break;
            }
        }
        result = moves1;
        // Now consider mixture of a and b
        int moves2 = 0;
        // Keep adding one item at a time from b
        for (int item: b) {
            runningSum += item;
            // Increment moves from 2
            moves2++;
            // Keep removing from 1, if running sum is greater
            while (runningSum > maxSum && moves1 > 0) {
                runningSum -= a.get(moves1 - 1);
                // Decrement moves from 1, as we are removing from 1
                moves1--;
            }
            // If running sum is in max range, save the greater moves in result
            // either moves1 + moves2 or result (saved from 1 only)
            if (runningSum <= maxSum)
                result = Math.max(moves1 + moves2, result);
        }

        return result;
    }

    private static Stack<Integer> listToStack(List<Integer> list) {
        Stack<Integer> stack = new Stack<>();

        // Read from last to first
        for (int i: list) {
            stack.push(i);
        }

        return stack;
    }

    public static void main(String[] args) throws IOException {
        int maxSum = 11;
        List<Integer> a = Stream.of("4 2 4 6 1".replaceAll("\\s+$", "").split(" "))
                .map(Integer::parseInt)
                .collect(toList());
        List<Integer> b = Stream.of("2 1 8 5".replaceAll("\\s+$", "").split(" "))
                .map(Integer::parseInt)
                .collect(toList());

        int result = twoStacks(maxSum, a, b);
        System.out.println(result);
    }
}
