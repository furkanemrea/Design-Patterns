using Strategy.Pattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Concrete
{
    public class SmsNotificationSender : INotificationSenderStrategy
    {
        public string SendNotification()
        {
            return "Sms sent";
        }
    }
    public class EmailNotificationSender : INotificationSenderStrategy
    {
        public string SendNotification()
        {
            return "Email sent";
        }
    }
}
