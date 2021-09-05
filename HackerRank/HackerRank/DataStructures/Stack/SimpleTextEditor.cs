using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Stack
{
    class SimpleTextEditor
    {
        public static void Test()
        {
            List<String> list = new List<string>();
            //list.AddRange(new List<string>(){"1 abc", "3 3", "2 3", "1 xy", "3 2", "4", "4", "3 1"});
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine(editor(list));
        }

        private static string editor(List<string> operations)
        {
            StringBuilder result = new StringBuilder();
            // Save all output in string builder
            StringBuilder sb = new StringBuilder();
            string param = "";
            Stack<string> history = new Stack<string>();

            // Do each operation
            foreach(string op in operations)
            {
                switch(op[0])
                {
                    // Append
                    case '1':
                        param = op.Split(' ')[1];
                        history.Push("1 " + param.Length);
                        sb.Append(param);
                        break;
                    // Remove last k characters
                    case '2':
                        int len = int.Parse(op.Split(' ')[1]);
                        history.Push("2 " + sb.ToString().Substring(sb.Length - len, len));
                        sb.Remove(sb.Length - len, len);
                        break;
                    // Print char at index
                    case '3':
                        int index = int.Parse(op.Split(' ')[1]) - 1;
                        result.Append(sb[index]);
                        result.AppendLine();
                        break;
                    case '4':
                        string undoCmd = history.Pop();
                        if (undoCmd[0] == '1')
                        {
                            int undoLen = int.Parse(undoCmd.Split(' ')[1]);
                            // Remove last k characters
                            sb.Remove(sb.Length - undoLen, undoLen);
                        } else
                        {
                            // Append string
                            sb.Append(undoCmd.Split(' ')[1]);
                        }
                        break;
                }
            }

            return result.ToString();
        }
    }
}
