using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsBankAccountDemo01
{
    public class AccountProcessingEventArgs : EventArgs
    {
        public Account Account { get; set; }
        public readonly string msg;
        public AccountProcessingEventArgs(Account account, string message)
        {
            this.Account = account;
            msg = message;
        }
    }
    class AccountProcessing
    {
        public delegate void AccountProcessingEventHandler(Object sender, AccountProcessingEventArgs e);

        public event AccountProcessingEventHandler AccountProcessed;

        public void Processing(Account account)
        {
            Console.WriteLine("Processing account...");
            Thread.Sleep(3000);

            OnAccountProcessed(account);
        }

        public void OnAccountProcessed(Account account)
        {
            AccountProcessed?.Invoke(this, new AccountProcessingEventArgs(account, "Process Complete"));
        }
    }
}
