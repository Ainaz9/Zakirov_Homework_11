
namespace Tumakov
{
    enum AccountTypeHm_14_1
    {
        Checking,
        Savings,
        Buisness,
    }
    [PersonInfo("Иван", "ООО Доставка")]
    class BankAccountHm_14_1
    {
        private string NumberAccount;
        private string AccountHolder;
        private AccountTypeHm_14_1 AccountType;

        public BankAccountHm_14_1(string numberAccount, string accountHolder, AccountTypeHm_14_1 accountType)
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
            set { AccountHolder = value; }
        }

        public AccountTypeHm_14_1 accountType
        {
            get { return AccountType; }
        }


    }
}
