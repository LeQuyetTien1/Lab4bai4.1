using Lab4bai4._1;
using System;
class Program
{
    static void Main(string[] args)
    {
        CheckAccount a = new CheckAccount();
        Console.Write("Nhap so tien hien tai: ");
        a.initialize = int.Parse(Console.ReadLine());
        Console.Write("Nhap so tien ban muon gui: ");
        int money1 = int.Parse(Console.ReadLine());
        a.Deposit(money1);
        a.GetBalance();
        Console.ReadKey();
        Console.Write("Nhap so tien ban muon rut: ");
        int money2 = int.Parse(Console.ReadLine());
        a.WithDraw(money2);
        a.GetBalance();
        Console.ReadKey();
        SavingAccount b = new SavingAccount();
        Console.Write("Nhap so tien muon gui tiet kiem: ");
        b.initialize = int.Parse(Console.ReadLine());
        Console.Write("Lai suat: ");
        b.rate = double.Parse(Console.ReadLine());
        b.GetInterest();


    }
}