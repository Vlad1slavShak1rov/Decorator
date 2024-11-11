using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SMSSender : DecoratorNotify
    {
        private readonly List<string> _phoneNumbers;

        public SMSSender(List<string> PhoneNumber)
        {
            _phoneNumbers = PhoneNumber;
        }
        public override void Send(string msg)
        {
            base.Send(msg);
            foreach (var number in _phoneNumbers)
            {
                Console.WriteLine($"СМС с сообщением {msg} отправлен на номер {number}");
            }
        }

    }
}
