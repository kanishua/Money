using System;

namespace MoneyLibrary
{
    //Create class Money (with base operations + and -) (no negative!)
    public class MoneyHelper
    {
        private int _euro;
        private int _cents;
        const int amountOfCentsInOneEuro = 100;

        public int Euro
        {
            get => _euro;
            set
            {
                if (value >= 0)
                {
                    _euro = value;
                }
                else
                {
                    throw new ArgumentException("Not enough money in the account");
                }
            }
        }

        public int Cents
        {
            get => _cents;
            set
            {
                if (Euro >= 0 && value >= 0)
                {
                    _cents = value;
                }
                else if (Euro > 0 && value < 0)
                {
                    _euro -= 1;
                    _cents = value + amountOfCentsInOneEuro;
                }
                else if (value >= amountOfCentsInOneEuro)
                {
                    _euro += value / amountOfCentsInOneEuro;
                    _cents = value % amountOfCentsInOneEuro;
                }
                else
                {
                    throw new ArgumentException("Not enough money in the account");
                }
            }
        }

        public MoneyHelper()
        {
            Euro = 0;
            Cents = 0;
        }

        public MoneyHelper(int euro, int cents)
        {
            Euro = euro;
            Cents = cents;
        }

        public static MoneyHelper operator +(MoneyHelper a, MoneyHelper b)
        {
            return new MoneyHelper(a.Euro + b.Euro, a.Cents + b.Cents);
        }

        public static MoneyHelper operator -(MoneyHelper a, MoneyHelper b)
        {
            return new MoneyHelper((a.Euro - b.Euro), (a.Cents - b.Cents));
        }
    }
}
