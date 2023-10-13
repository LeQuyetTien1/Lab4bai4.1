using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4bai4._1
{
    internal class Account
    {
        public int Balance { get; set; }
        private int initialize;
        public int Initialize
        {
            get { return initialize; }
            set { initialize = value; }
        }

        public Account(int initialize)
        {
            this.initialize = initialize;
        }

        public void Deposit(int money)
        {
            Console.WriteLine("So tien trong tai khoan: " + initialize);
            Console.WriteLine("So tien muon gui: " + money);
        }
        public void WithDraw(int money)
        {
            Console.WriteLine("So tien trong tai khoan: " + initialize);
            Console.WriteLine("So tien muon rut: " + money);
        }
        public int GetBalance()
        {
            return initialize;
        }
    }
}
