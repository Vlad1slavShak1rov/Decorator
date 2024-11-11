using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public  class DecoratorNotify : SenderNotifications
    {
        public SenderNotifications sender { protected get; set; }
        public override void Send(string msg)
        {
            if(sender != null) sender.Send(msg);
        }
    }
}
