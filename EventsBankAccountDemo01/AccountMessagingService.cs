using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBankAccountDemo01
{
    class AccountMessagingService
    {
        public void OnAccountProcessed(object sender, AccountProcessingEventArgs e)
        {
            Console.WriteLine("Account: {0} \nStatus: {1} \nMessagingService: Sending message", e.Account.AccountName, e.msg);
        }
    }
}
