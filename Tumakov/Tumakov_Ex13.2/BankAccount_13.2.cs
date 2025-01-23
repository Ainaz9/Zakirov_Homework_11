
namespace Tumakov
{
    enum AccountType_13_2
    {
        Checking,
        Savings,
        Buisness,
    }
    class BankAccount_13_2
    {
        private string NumberAccount;
        private string AccountHolder;
        private AccountType_13_2 AccountType;
        private List<BankTransaction_13_2> bankTransaction;

        public BankAccount_13_2(string numberAccount, string accountHolder, AccountType_13_2 accountType)
        {
            NumberAccount = numberAccount;
            AccountHolder = accountHolder;
            AccountType = accountType;
            bankTransaction = new List<BankTransaction_13_2>();
        }

        public string numberAccount
        {
            get { return NumberAccount; }
        }

        public string accountHolder
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }

        public AccountType_13_2 accountType
        {
            get { return AccountType; }
        }

        public void AddTransaction(decimal amount, DateTime date)
        {
            bankTransaction.Add(new BankTransaction_13_2(date,amount));
        }

        public BankTransaction_13_2 this[int index]
        {
            get 
            {
                if (index < 0 || index >= bankTransaction.Count)
                {
                    throw new Exception("Индекс больше кол-во транзакции");
                }
                else
                {
                    return bankTransaction[index];
                }
            }
            set 
            {
                if (index < 0 || index >= bankTransaction.Count)
                {
                    throw new Exception("Индекс больше кол-во полей");
                }
                else
                {
                    bankTransaction[index] = value;
                }
            }
        }
    }
}
