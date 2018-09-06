using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Bankomat;

namespace Namespace
{
    class Program
    {
        static bool PasswordValidation(Account account)
        {
            int triesLeft = 3;
            string password;
            while (triesLeft > 0)
            {
                WriteLine("Введите пароль: ");
                password = ReadLine();
                if (account.IsPasswordValid(password))
                    return true;
                else
                {
                    triesLeft--;
                    WriteLine("Осталось попыток - " + triesLeft);
                }
            }
            WriteLine("Нет попыток");
            WriteLine("Повторите позже");
            ReadLine();
            return false;
        }


        static void PrintWalletBalance(Account account)
        {
            WriteLine("Ваш баланс - " + account.WalletBalance);
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();

            string userPassword = bank.GetClientPassword();

            string userWalletNumber = bank.GetWalletNumber();

            string firstName = "";

            string middleName = "";

            string lastName = "";

            int age;

            string str = "";

            bool validPassword;


            WriteLine("Открытие счета в банке");

            WriteLine("Введите имя");

            firstName = ReadLine();

            WriteLine("Введите фамилию");

            lastName = ReadLine();

            WriteLine("Введите ваше отчество");

            middleName = ReadLine();

            WriteLine("Введите ваш возраст");

            str = ReadLine();

            bool isParsed = int.TryParse(str, out age);

            if (isParsed)
                age = int.Parse(str);

            Client client = new Client(firstName, middleName, lastName, age);
            Account account = new Account(userPassword, userWalletNumber);

            WriteLine("Ваш пароль от аккаунта - " + userPassword);

            WriteLine("Ваш номер счета - " + userWalletNumber);

            WriteLine("Нажмите ENTER чтобы подтвердть");
            ReadLine();

            Clear();

            validPassword = PasswordValidation(account);
            if (!validPassword)
                return;

            Clear();

            int menuChoice=0;
            while(menuChoice<4)
            {
            WriteLine("1.Вывод баланса");
            WriteLine("2.Пополнение счета");
            WriteLine("3.Снять деньги со счета");
            WriteLine("4.Выход");
                str = ReadLine();

                isParsed = int.TryParse(str, out menuChoice);

                if (isParsed)
                    menuChoice = int.Parse(str);

                Clear();
                switch(menuChoice)
                {
                    case 1:
                        PrintWalletBalance(account);
                        ReadLine();
                        Clear();
                        break;
                    case 2:
                        {
                            int amount;
                            WriteLine("Сколько денег хотите добавить");
                            str = ReadLine();

                            isParsed = int.TryParse(str, out amount);

                            if (isParsed)
                                amount = int.Parse(str);

                            account.AddWalletBalance(amount);
                            PrintWalletBalance(account);
                            ReadLine();
                            Clear();
                        } break;
                    case 3:
                        {
                            int amount;
                            WriteLine("Сколько денег хотите снять");
                            str = ReadLine();

                            isParsed = int.TryParse(str, out amount);

                            if (isParsed)
                                amount = int.Parse(str);

                            account.WithdrawMoney(amount);
                            PrintWalletBalance(account);
                            ReadLine();
                            Clear();
                        }break;
                }
            }
            ReadLine();
        }
    }
}
