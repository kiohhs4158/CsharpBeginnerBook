using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace kadai9
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            Console.Write("文字列を入力してください：");
            string text = Console.ReadLine();

            log.Debug(text);
            log.Info(text);
            log.Warn(text);
            log.Error(text);
            log.Fatal(text);
        }
    }
}
