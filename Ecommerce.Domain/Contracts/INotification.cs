using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Contracts
{
    public interface INotification
    {
        HashSet<string> Notifications { get; }
        void AddNotification(string message);
        bool HasNotification();
    }
}
