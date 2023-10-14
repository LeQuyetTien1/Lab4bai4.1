using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4bai4._1
{
    internal class CheckAccount: Account
    {
        public int FeeTransfer;
        public CheckAccount() { }
        public CheckAccount(int FeeTransfer, int initialize): base(initialize)
        {
            this.FeeTransfer = FeeTransfer;
        }
        public override void Deposit(int money)
        {
            Console.WriteLine("So tien trong tai khoan: " + initialize);
            Console.WriteLine("So tien muon gui: " + money);
            initialize += money-FeeTransfer;
            
        }
        public override void WithDraw(int money)
        {
            Console.WriteLine("So tien trong tai khoan: " + initialize);
            Console.WriteLine("So tien muon rut: " + money);
            initialize -= money-FeeTransfer;
            
        }
        public new void GetBalance()
        {
            base.GetBalance();
        }
    }
}
