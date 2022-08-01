using MoneyLibrary;
using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyHelper money1 = new MoneyHelper(20, 70);
            MoneyHelper money2 = new MoneyHelper(10, 40);

            //money1 = new MoneyHelper(30, 10);
            //money2 = new MoneyHelper(10, 50);

            //money1 = new MoneyHelper(60, 70);
            //money2 = new MoneyHelper(90, 10);

            //money1 = new MoneyHelper(30, 40);
            //money2 = new MoneyHelper(40, 80);

            //money1 = new MoneyHelper(40, 60);
            //money2 = new MoneyHelper(40, 20);

            //money1 = new MoneyHelper(50, 30);
            //money2 = new MoneyHelper(50, 80);

            //money1 = new MoneyHelper(20, 90);
            //money2 = new MoneyHelper(20, 90);

            //money1 = new MoneyHelper(0, 80);
            //money2 = new MoneyHelper(0, 30);

            //money1 = new MoneyHelper(0, 40);
            //money2 = new MoneyHelper(0, 70);

            //money1 = new MoneyHelper(0, 0);
            //money2 = new MoneyHelper(0, 0);

            MoneyHelper plusMoney1 = money1 + money2;
            MoneyHelper minusMoney1 = money1 - money2;
            Console.WriteLine($"{money1.Euro} Euro {money1.Cents} Cents");
            Console.WriteLine($"{money2.Euro} Euro {money2.Cents} Cents");
            Console.WriteLine($"{plusMoney1.Euro} Euro {plusMoney1.Cents} Cents");
            Console.WriteLine($"{minusMoney1.Euro} Euro {minusMoney1.Cents} Cents");
            Console.WriteLine();

        }
    }
}