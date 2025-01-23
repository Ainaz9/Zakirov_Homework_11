

namespace Tumakov
{
    class BankTransaction_14_1
    {
        private DateTime Date;
        private decimal Amount;

        public BankTransaction_14_1(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
        }

        public decimal amount
        {
            get { return Amount; }
        }

        public DateTime date
        {
            get { return Date; }
        }
    }
}
