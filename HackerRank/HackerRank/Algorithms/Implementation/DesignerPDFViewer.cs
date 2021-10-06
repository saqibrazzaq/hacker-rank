using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class DesignerPDFViewer
    {
        public static void Test()
        {
            List<int> h = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7"
                .Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();
            string word = "zaba";

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
        }

        private static int designerPdfViewer(List<int> h, string word)
        {
            int max = 1;
            foreach (char c in word)
            {
                int i = (int)c - 97;
                if (h[i] > max) max = h[i];
            }
            return max * word.Length;
        }
    }
}
