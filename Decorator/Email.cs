using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Email:SenderNotifications
    {
        private readonly List<string> _emails;
        public Email(List<string> emails)
        {
            _emails = emails;
        }
        public override void Send(string msg)
        {
            foreach (var mail in _emails)
            {
                Console.WriteLine($"Сообщение {msg} отправленно почтой {mail}");
            }    
        }
    }
}
