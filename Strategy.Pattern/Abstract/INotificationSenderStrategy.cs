using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Abstract
{
    public interface INotificationSenderStrategy
    {
        string SendNotification();
    }
}
