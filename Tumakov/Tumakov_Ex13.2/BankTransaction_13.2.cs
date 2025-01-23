
namespace Tumakov
{
    class BankTransaction_13_2
    {
        private DateTime Date;
        private decimal Amount;

        public BankTransaction_13_2(DateTime date, decimal amount)
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

        public override string ToString()
        {
            return $"Дата: {Date}, Сумма: {Amount}";
        }
    }
}
