using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4bai4._1
{
    internal class Account
    {      
        public int initialize { get; set; }
        public int money { get; set; }
        
        public Account() { }
        public Account(int initialize)
        {
            this.initialize = initialize;
        }

        public virtual void Deposit(int money)
        {
            Console.WriteLine("So tien trong tai khoan: " + initialize);
            Console.WriteLine("So tien muon gui: " + money);
            initialize += money;
            
        }
        public virtual void WithDraw(int money)
        {
            Console.WriteLine("So tien trong tai khoan: " + initialize);
            Console.WriteLine("So tien muon rut: " + money);
            initialize -= money;
            
        }
        public void GetBalance()
        {
            Console.WriteLine("So tien hien co: "+initialize);
        }
    }
}
