using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace kadai8
{
    class Log
    {
        private static StreamWriter writer;
        private static DateTime dt = DateTime.Now;
        public static void Write(string text)
        {
            string path = "D:\\CsharpBeginnerBook\\kadai\\kadai8\\kadai8\\kadai8.txt";
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            writer = new StreamWriter(@path, true, enc);
            writer.WriteLine($"[{dt}:{dt.Millisecond}] {text}");
            writer.Close();
        }

    }
}
