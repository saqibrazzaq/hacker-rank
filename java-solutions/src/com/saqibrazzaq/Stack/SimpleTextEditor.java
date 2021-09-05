package com.saqibrazzaq.Stack;

import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Stack;
import java.util.stream.IntStream;
import java.util.stream.Stream;

import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

public class SimpleTextEditor {
    private static List<String> textEditor(List<String> operations) {
        List<String> result = new ArrayList<>();
        // String is initially empty
        String S = "";
        // Stack to store history of operations
        Stack<String> history = new Stack<>();

        // Process each operation
        for (String op: operations) {
            // op contains single operation e.g. "1 fg"
            // Get the command e.g. 1, 2, 3, 4
            char cmd = op.charAt(0);
            // Split the operation to separate the command and param
            String[] params = op.split(" ");
            // Do operation based on each command
            switch (cmd) {
                case '1':
                    // Append string
                    S = S.concat(params[1]);
                    history.push("1 " + params[1].length());
                    break;
                case '2':
                    // Size - last k characters - 1
                    history.push("2 " + S.substring(S.length() - Integer.parseInt(params[1])));
                    S = S.substring(0, S.length() - Integer.parseInt(params[1]));
                    break;
                case '3':
                    // Print kth character
                    result.add("" + S.charAt(Integer.parseInt(params[1]) - 1));
                    System.out.println(S.charAt(Integer.parseInt(params[1]) - 1)); break;
                case '4':
                    // Undo - Get last operation from stack
                    String undoOp = history.pop();
                    // Undo command e.g. 1, 2
                    char undoCmd = undoOp.charAt(0);
                    // Parameter of undo command
                    String undoParam = undoOp.split(" ")[1];
                    // Perform undo operation
                    if (undoCmd == '1') {
                        // Delete last k characters
                        S = S.substring(0, S.length() - Integer.parseInt(undoParam));
                    } else {
                        // Append string
                        S = S.concat(undoParam);
                    }
                     break;
            }
        }
        return result;
    }

    public static void main(String[] args) throws Exception{
        List<String> list = new ArrayList<>();
        list.add("1 abc");
        list.add("3 3");
        list.add("2 3");
        list.add("1 xy");
        list.add("3 2");
        list.add("4");
        list.add("4");
        list.add("3 1");

        textEditor(list);

        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        // number of operations
        int g = Integer.parseInt(bufferedReader.readLine().trim());

        IntStream.range(0, g).forEach(gItr -> {
            try {
                list.add(bufferedReader.readLine().replaceAll("\\s+$", ""));


            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        List<String> result = textEditor(list);
        String resultString = "";
        for (String s: result) {
            resultString.concat(s + "\n");
        }
        bufferedWriter.write(resultString);
        bufferedReader.close();
        bufferedWriter.close();
    }
}
