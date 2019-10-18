using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBankAccountDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("rramos", 100);
            AccountProcessing processing = new AccountProcessing();
            AccountMessagingService messagingService = new AccountMessagingService();

            processing.AccountProcessed += messagingService.OnAccountProcessed;

            processing.Processing(account);
        }
    }
}
