using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class SenderNotifications
    {
        public abstract void Send(string msg);
    }
}
