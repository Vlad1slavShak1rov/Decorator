using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FaceBookSender: DecoratorNotify
    {
        private readonly List<string> _nickNames;
        public FaceBookSender(List<string> nickName)
        {
            _nickNames = nickName;
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            foreach (string nickName in _nickNames)
            {
                Console.WriteLine($"Сообщение {msg} отправлено в личные сообщение FaceBook, получатель {nickName}");
            }
        }
    }
}
