package com.saqibrazzaq.Stack;

import java.io.IOException;
import java.util.Stack;

public class BalancedBrackets {
    public static String isBalanced(String s) {
        // Use stack for storing brackets
        Stack<Character> stack = new Stack<>();
        // Parse string and store opening brackets in stack
        for (int i = 0; i < s.length(); i++) {
            char bracket = s.charAt(i);
            // Opening bracket - store
            if (bracket == '(' || bracket == '{' || bracket == '[') {
                stack.push(bracket);
            } else if (bracket == ')' || bracket == '}' || bracket == ']') {
                // If stack is empty, invalid brackets
                if (stack.isEmpty() == true) return "NO";
                // Compare with Match
                char openingBracket = stack.pop();
                if (bracket == ')' && openingBracket != '(') return "NO";
                else if (bracket == '}' && openingBracket != '{') return "NO";
                else if (bracket == ']' && openingBracket != '[') return "NO";
            }
        }
        if (stack.isEmpty() == false) return "NO";
        return "YES";
    }

    public static void main(String[] args) throws IOException {
        int t = 3;

        System.out.println(isBalanced("{[()]}"));
        System.out.println(isBalanced("{[(])}"));
        System.out.println(isBalanced("}"));

    }
}
