using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample510
{
    class CellPhone : IPhone, IEmail
    {
        private string mailAddress;
        private string number;
        public CellPhone(string mailAddress, string number)
        {
            this.mailAddress = mailAddress;
            this.number = number;
        }
        public void SendMail(string address)
        {
            Console.WriteLine(address + "に" + this.mailAddress + "からメールを送信します");
        }
        public void Call(string number)
        {
            Console.WriteLine(number + "から" + this.number + "に電話をかけます");
        }
    }
}
