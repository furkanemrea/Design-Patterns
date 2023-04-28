using Strategy.Pattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern
{
    internal class Verification
    {
        private INotificationSenderStrategy _notificationSenderStrategy;
        public Verification()
        {

        }

        public Verification(INotificationSenderStrategy notificationSenderStrategy)
        {
            this._notificationSenderStrategy = notificationSenderStrategy;
        }


        public string SendNotification(INotificationSenderStrategy notificationSenderStrategy)
        {
            return notificationSenderStrategy.SendNotification();
        }
    }
}
