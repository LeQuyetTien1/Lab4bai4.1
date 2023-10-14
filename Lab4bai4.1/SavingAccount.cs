using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4bai4._1
{
    internal class SavingAccount: Account
    {
        public double rate;
        public SavingAccount() { }
        public SavingAccount(int initialize, double rate): base(initialize)
        {
            this.rate = rate;
        }
        public void GetInterest()
        {
            
            Console.WriteLine("So tien lai nhan duoc hang thang: "+ initialize * rate);
        }        
    }
}
