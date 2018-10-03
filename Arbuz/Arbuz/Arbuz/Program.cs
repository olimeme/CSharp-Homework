using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using static System.Console;

namespace Arbuz
{
    class Program
    {
        public static string PasswordGenerate(int length)
        {
            Random _random = new Random(Environment.TickCount);

            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder(length);

            for (int i = 0; i < length; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);

            return builder.ToString();
        }

        public static void Message(string code, string phoneNumber)
        {
            string accountSid = "AC46d729f9bab280d217192471bb510f0e";
            string authToken = "9a4d673663e8e6de021d0c5d8c0af348";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Your account verification code: " + code,
                from: new Twilio.Types.PhoneNumber("+19413000318"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)

                //+77011007185
            );
        }

        static void Main(string[] args)
        {
            int triesLeftFirst = 3;

            string passCode = PasswordGenerate(4);
            WriteLine("Welcome to Dynya.kz");
            WriteLine();

            WriteLine("Создайте свой аккаунт");
            WriteLine();

            WriteLine("Введите свое полное имя");
            string fullName = ReadLine();
            Clear();

            WriteLine("Введите логин");
            string login = ReadLine();
            Clear();

            WriteLine("Введите пароль");
            string password = ReadLine();
            Clear();

            WriteLine("Введите номер телефона");
            string phoneNumber = ReadLine();
            Clear();

            while (triesLeftFirst > 0)
            {
                WriteLine("Введите код подтверждения");
                Message(passCode, phoneNumber);
                WriteLine(passCode);
                string code = ReadLine();

                if (code == passCode)
                {
                    WriteLine("Аккаунт успешно подтвержден!");
                    break;
                }
                else
                {
                    triesLeftFirst--;
                    WriteLine("Осталось попыток - " + triesLeftFirst);
                }
            }

            if (triesLeftFirst < 0)
            {
                WriteLine("Нет попыток");
                WriteLine("Повторите позже");
                ReadLine();
                return;
            }
            Goods diapers = new Goods(Categories.KidsGoods, "Huggis", 1500);
            Goods fruits = new Goods(Categories.Groceries, "Fruit Pack", 4000);
            Goods hlebci = new Goods(Categories.Groceries, "Хлебцы молодцы", 200);
            Goods cookies = new Goods(Categories.KidsGoods, "Huggis Cookies", 500);
            Goods meat = new Goods(Categories.Groceries, "Meat from Shymkent", 1200);
            Goods poridge = new Goods(Categories.KidsGoods, "NAN-3", 2000);
            Goods rice = new Goods(Categories.Groceries, "Nippon", 1000);
            Goods soySauce = new Goods(Categories.Groceries, "K-sauce ", 800);
            Goods whiskey = new Goods(Categories.Alcochol, "Jameson", 5000);
            Goods machette = new Goods(Categories.CampingKits, "Jack The Ripper", 40000);
            Goods tent = new Goods(Categories.CampingKits, "North Face Tent 4x4", 80000);
            Goods HomeFreshener = new Goods(Categories.ForHome, "ZARA home freshener", 5000);

            var GoodsOnSetOut = new List<Goods> { diapers,fruits,hlebci,cookies,rice,soySauce,meat,poridge};

            User user = new User(login, password, phoneNumber, fullName);

            Cart cart = new Cart();

            ReadLine();
            Clear();

            int menuChoice = 0;
            while (true)
            {
                WriteLine("1.Продукты");
                WriteLine("2.Детские товары");
                WriteLine("3.Для дома");
                WriteLine("4.Приборы для выживания и кэмпинга");
                WriteLine("5.Для животных");
                WriteLine("6.Спиртное");
                WriteLine("7.Корзина");
                WriteLine("8.Выход");

                string str = ReadLine();

                bool isParsed = int.TryParse(str, out menuChoice);

                if (isParsed)
                    menuChoice = int.Parse(str);
                else
                {
                    Clear();
                    continue;
                }
                Clear();
                if (menuChoice <= 8)
                {
                    switch (menuChoice)
                    {
                        case 1:
                            {
                                int choice1;
                                WriteLine("Введите индекс товара чтобы добавить его в корзину:");
                                WriteLine();
                                for (int i=0;i<GoodsOnSetOut.Count; i++)
                                {
                                    if (GoodsOnSetOut[i].GetCategories() == Categories.Groceries)
                                    {
                                        Write(i + ".");
                                        GoodsOnSetOut[i].PrintInfo();
                                    }
                                }

                                str = ReadLine();

                                isParsed = int.TryParse(str, out choice1);

                                if (isParsed)
                                    choice1 = int.Parse(str);
                                cart.AddToCart(GoodsOnSetOut[choice1]);
                                ReadLine();
                                Clear();
                            }
                            break;
                        case 2:
                            {
                                int choice1;
                                WriteLine("Введите индекс товара чтобы добавить его в корзину:");
                                WriteLine();
                                for (int i = 0; i < GoodsOnSetOut.Count; i++)
                                {
                                    if (GoodsOnSetOut[i].GetCategories() == Categories.KidsGoods)
                                    {
                                        Write(i + ".");
                                        GoodsOnSetOut[i].PrintInfo();
                                    }
                                }

                                str = ReadLine();

                                isParsed = int.TryParse(str, out choice1);

                                if (isParsed)
                                    choice1 = int.Parse(str);
                                cart.AddToCart(GoodsOnSetOut[choice1]);
                                ReadLine();
                                Clear();
                            }
                            break;
                        case 3:
                            {
                                int choice1;
                                WriteLine("Введите индекс товара чтобы добавить его в корзину:");
                                WriteLine();
                                for (int i = 0; i < GoodsOnSetOut.Count; i++)
                                {
                                    if (GoodsOnSetOut[i].GetCategories() == Categories.ForHome)
                                    {
                                        Write(i + ".");
                                        GoodsOnSetOut[i].PrintInfo();
                                    }
                                }

                                str = ReadLine();

                                isParsed = int.TryParse(str, out choice1);

                                if (isParsed)
                                    choice1 = int.Parse(str);
                                cart.AddToCart(GoodsOnSetOut[choice1]);
                                ReadLine();
                                Clear();
                            }
                            break;
                        case 4:
                            {
                                int choice1;
                                WriteLine("Введите индекс товара чтобы добавить его в корзину:");
                                WriteLine();
                                for (int i = 0; i < GoodsOnSetOut.Count; i++)
                                {
                                    if (GoodsOnSetOut[i].GetCategories() == Categories.CampingKits)
                                    {
                                        Write(i + ".");
                                        GoodsOnSetOut[i].PrintInfo();
                                    }
                                }

                                str = ReadLine();

                                isParsed = int.TryParse(str, out choice1);

                                if (isParsed)
                                    choice1 = int.Parse(str);
                                cart.AddToCart(GoodsOnSetOut[choice1]);
                                ReadLine();
                                Clear();
                            }
                            break;
                        case 5:
                            {
                                int choice1;
                                WriteLine("Введите индекс товара чтобы добавить его в корзину:");
                                WriteLine();
                                for (int i = 0; i < GoodsOnSetOut.Count; i++)
                                {
                                    if (GoodsOnSetOut[i].GetCategories() == Categories.ForPets)
                                    {
                                        Write(i + ".");
                                        GoodsOnSetOut[i].PrintInfo();
                                    }
                                }

                                str = ReadLine();

                                isParsed = int.TryParse(str, out choice1);

                                if (isParsed)
                                    choice1 = int.Parse(str);
                                cart.AddToCart(GoodsOnSetOut[choice1]);
                                ReadLine();
                                Clear();
                            }
                            break;
                        case 6:
                            {
                                int choice1;
                                WriteLine("Введите индекс товара чтобы добавить его в корзину:");
                                WriteLine();
                                for (int i = 0; i < GoodsOnSetOut.Count; i++)
                                {
                                    if (GoodsOnSetOut[i].GetCategories() == Categories.Alcochol)
                                    {
                                        Write(i + ".");
                                        GoodsOnSetOut[i].PrintInfo();
                                    }
                                }

                                str = ReadLine();

                                isParsed = int.TryParse(str, out choice1);

                                if (isParsed)
                                    choice1 = int.Parse(str);
                                cart.AddToCart(GoodsOnSetOut[choice1]);
                                ReadLine();
                                Clear();
                            }
                            break;
                        case 7:
                            {
                                int choice;
                                int userMoneyAmount;
                                if (cart.CalculateTheSumOfAllGoods() != 0)
                                {
                                    while (true)
                                    {
                                        cart.PrintInfo();
                                        WriteLine("Общая сумма: " + cart.CalculateTheSumOfAllGoods());
                                        WriteLine("Хотите оплатить?");
                                        WriteLine("1.Да");
                                        WriteLine("2.Нет");
                                        str = ReadLine();

                                        isParsed = int.TryParse(str, out choice);

                                        if (isParsed)
                                            choice = int.Parse(str);
                                        else
                                        {
                                            Clear();
                                            continue;
                                        }
                                        if (choice == 1)
                                        {
                                            while (true)
                                            {
                                                WriteLine("Введите сумму для оплаты :");
                                                str = ReadLine();

                                                isParsed = int.TryParse(str, out userMoneyAmount);

                                                if (isParsed)
                                                    userMoneyAmount = int.Parse(str);

                                                if (cart.CalculateTheSumOfAllGoods() > userMoneyAmount)
                                                    WriteLine("Недостаточно средств для оплаты!");
                                                else
                                                {
                                                    WriteLine("Спасибо за оплату!");
                                                    WriteLine("Ваша сдача: " + (userMoneyAmount - cart.CalculateTheSumOfAllGoods()));
                                                    cart.ClearCart();
                                                    ReadLine();
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                        else
                                            break;
                                    }
                                }
                                else
                                {

                                }

                                ReadLine();
                                Clear();
                            }
                            break;
                        case 8:
                            return;
                    }

                }
                else
                {
                    Clear();
                    continue;
                }

            }
        }
    }
}
