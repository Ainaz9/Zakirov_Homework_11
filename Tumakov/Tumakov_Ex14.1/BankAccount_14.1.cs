#define DEBUG_ACCOUNT

namespace Tumakov
{
    enum AccountType_14_1
    {
        Checking,
        Savings,
        Buisness,
    }
    class BankAccount_14_1
    {
        private string NumberAccount;
        private string AccountHolder;
        private AccountType_14_1 AccountType;

        public BankAccount_14_1(string numberAccount, string accountHolder, AccountType_14_1 accountType)
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

        public AccountType_14_1 accountType
        {
            get { return AccountType; }
        }

        #if DEBUG_ACCOUNT
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер счета: {NumberAccount}");
            Console.WriteLine($"Владелец счета: {AccountHolder}");
            Console.WriteLine($"Тип аккаунта: {AccountType}");
        }
        #endif
    }
}
