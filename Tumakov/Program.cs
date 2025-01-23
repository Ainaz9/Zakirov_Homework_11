#define DEBUG_ACCOUNT

namespace Tumakov
{
    class Program
    {
        static void TaskTumakov_Ex13_1()
        {
            BankAccount_13_1 account = new BankAccount_13_1("123456789","Слава Мещюк", AccountType_13_1.Checking);

            Console.WriteLine($"Номер счета: {account.numberAccount}");
            Console.WriteLine($"Держатель: {account.accountHolder}");
            Console.WriteLine($"Номер счета: {account.accountType}");

            account.accountHolder = "Паша Петров";

            Console.WriteLine($"Номер счета: {account.numberAccount}");
            Console.WriteLine($"Держатель: {account.accountHolder}");
            Console.WriteLine($"Номер счета: {account.accountType}");


            BankTransaction_13_1 transaction = new BankTransaction_13_1(DateTime.Now, 1500);

            Console.WriteLine($"Время транзакции: {transaction.date}");
            Console.WriteLine($"Сумма транзакции: {transaction.amount}");
        }
        static void TaskTumakov_Ex13_2()
        {
            BankAccount_13_2 account = new BankAccount_13_2("12345678910", "Слава Пещюк", AccountType_13_2.Savings);

            account.AddTransaction(1000,DateTime.Now);
            account.AddTransaction(2000, DateTime.Now);
            account.AddTransaction(3000, DateTime.Now);
            account.AddTransaction(4000, DateTime.Now);
            account.AddTransaction(5000, DateTime.Now);

            Console.WriteLine(account[0]);
            Console.WriteLine(account[1]);
            Console.WriteLine(account[2]);
            Console.WriteLine(account[3]);
            Console.WriteLine(account[4]);
        }
        static void TaskTumakov_Hm13_1()
        {
            Building building = new Building(222, 10, 150, 5);

            Console.WriteLine($"Высота 1-го этажа: {building.FloorHeight()} метра");
            Console.WriteLine($"Кол-во квартир в подъезде: {building.NumberOfApartmentsInTheEntrance()}");
            Console.WriteLine($"Кол-во квартир на этаже: {building.NumberOfApartmentsPerFloor()}");
        }
        static void TaskTumakov_Hm13_2()
        {
            Building building1 = new Building(222, 10, 150, 6);
            Building building2 = new Building(300, 15, 2000, 8);
            Building building3 = new Building(150, 5, 100, 4);

            Buildings buildings = new Buildings();

            buildings.AddBuilding(building1);
            buildings.AddBuilding(building2);
            buildings.AddBuilding(building3);

            Console.WriteLine(buildings[0]);
            Console.WriteLine(buildings[1]);
            Console.WriteLine(buildings[2]);
        }
        static void TaskTumakov_Ex14_1()
        {
            BankAccount_14_1 account = new BankAccount_14_1("12345678910", "Слава Пещюк", AccountType_14_1.Savings);

            #if DEBUG_ACCOUNT
            account.DumpToScreen();
            #endif
        }

        static void TaskTumakov_Ex14_2()
        {
            Rational r1 = new Rational(5,6);
            Rational r2 = new Rational(7,8);

            Console.WriteLine(r1 + r2);
            Console.WriteLine(r1 * r2);
        }

        static void TaskTumakov_Hm14_1()
        {
            BankAccountHm_14_1 account = new BankAccountHm_14_1("123456789", "Слава Мещюк", AccountTypeHm_14_1.Checking);

            Console.WriteLine($"Номер счета: {account.numberAccount}");
            Console.WriteLine($"Держатель: {account.accountHolder}");
            Console.WriteLine($"Номер счета: {account.accountType}");

            account.accountHolder = "Паша Петров";

            Console.WriteLine($"Номер счета: {account.numberAccount}");
            Console.WriteLine($"Держатель: {account.accountHolder}");
            Console.WriteLine($"Номер счета: {account.accountType}");

            Console.WriteLine();

            Type type = typeof(BankAccountHm_14_1);

            object[] attributes = type.GetCustomAttributes(typeof(PersonInfoAttribute), false);

            if (attributes.Length > 0)
            {
                var personInfo = (PersonInfoAttribute)attributes[0];
                Console.WriteLine($"Разработчик: {personInfo.Name}");
                Console.WriteLine($"Организация: {personInfo.OrganizationName}");
            }
            else
            {
                Console.WriteLine("Атрибут PersonInfo не найден.");
            }

            Console.WriteLine();

            BankTransaction_14_1 transaction = new BankTransaction_14_1(DateTime.Now, 1500);

            Console.WriteLine($"Время транзакции: {transaction.date}");
            Console.WriteLine($"Сумма транзакции: {transaction.amount}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков | Упражнение | 13.1");
            Console.WriteLine();
            TaskTumakov_Ex13_1();
            Console.WriteLine();
            Console.WriteLine("Тумаков | Упражнение | 13.2");
            Console.WriteLine();
            TaskTumakov_Ex13_2();
            Console.WriteLine();
            Console.WriteLine("Тумаков | Домашнее задание | 13.1");
            Console.WriteLine();
            TaskTumakov_Hm13_1();
            Console.WriteLine();
            Console.WriteLine("Тумаков | Домашнее задание | 13.2");
            Console.WriteLine();
            TaskTumakov_Hm13_2();
            Console.WriteLine();
            Console.WriteLine("Тумаков | Упражнение | 14.1");
            Console.WriteLine();
            TaskTumakov_Ex14_1();
            Console.WriteLine();
            Console.WriteLine("Тумаков | Упражнение | 14.2");
            Console.WriteLine();
            TaskTumakov_Ex14_2();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Тумаков | Домашнее задание | 14.1");
            Console.WriteLine();
            TaskTumakov_Hm14_1();
            Console.WriteLine();
        }
    }
}