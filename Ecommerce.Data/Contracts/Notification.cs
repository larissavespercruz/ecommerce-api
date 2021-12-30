using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Contracts
{
    public class Notification
    {
        public HashSet<string> Notifications { get; }

        public Notification()
        {
            Notifications = new HashSet<string>();
        }

        public void AddNotification(string message)
        {
            this.Notifications.Add(message);
        }

        public bool HasNotification() => this.Notifications.Any();
    }
}
