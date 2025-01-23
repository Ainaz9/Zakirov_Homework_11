
namespace Tumakov
{
    enum AccountType_13_1
    {
        Checking,
        Savings,
        Buisness,
    }
    class BankAccount_13_1
    {
        private string NumberAccount;
        private string AccountHolder;
        private AccountType_13_1 AccountType;

        public BankAccount_13_1(string numberAccount, string accountHolder, AccountType_13_1 accountType)
        {
            NumberAccount = numberAccount;
            AccountHolder = accountHolder;
            AccountType = accountType;
        }

        public string numberAccount
        {
            get { return NumberAccount; }
        }

        public string accountHolder
        {
            get { return AccountHolder; }
            set {  AccountHolder = value; }
        }

        public AccountType_13_1 accountType
        {
            get { return AccountType; }
        }


    }
}
