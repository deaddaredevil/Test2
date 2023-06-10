namespace test
{
    class Program
    {
        static void Main()
        {
            const string ComandConvertRub = "1";
            const string ComandConvertUsd = "2";
            const string ComandConvertEur = "3";
            const string ComandExit = "0";

            float rublesBalance;
            float usdBalans;
            float eurBalans;
            float rubInUsd = 0.012f;
            float rubInEur = 0.011f;
            float usdInRub = 82.59f;
            float usdInEur = 0.93f;
            float eurInRub = 88.87f;
            float eurInUsd = 1.08f;
            string userInput = "";
            int requestedAmount;
            float enoughMoney;

            Console.WriteLine("Добро пожаловать в обменник валют. Укажите количество средств на счете.");
            Console.Write("Сколько у вас рублей: ");
            rublesBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас долларов: ");
            usdBalans = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас евро: ");
            eurBalans = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Какую валюту вы хотите поменять:" +
                $"{ComandConvertRub} - Рубли." +
                $"{ComandConvertUsd} - Доллары." +
                $"{ComandConvertEur} - Евро." +
                $"{ComandExit} - Выход.");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case ComandConvertRub:
                    Console.Write($"В выбрали рубли, на какую валюту вы хотите поменять: " +
                        $"1 - на доллары." +
                        $"2 - на евро. " +
                        $"{ComandExit} - Выход. ");
                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = rublesBalance - usdInRub * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else if (enoughMoney >= 0)
                        {
                            usdBalans += requestedAmount;
                            rublesBalance -= usdInRub * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {usdBalans} долларов.");
                        }
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = rublesBalance - eurInRub * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else if (enoughMoney >= 0)
                        {
                            eurBalans += requestedAmount;
                            rublesBalance -= eurInRub * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {eurBalans} долларов.");
                        }
                    }
                    else if (userInput == ComandExit)
                        Console.WriteLine("Завершение программы!");
                    break;

                case ComandConvertUsd:
                    Console.Write($"В выбрали доллары, на какую валюту вы хотите поменять: " +
                        $"1 - на рубли." +
                        $"2 - на евро. " +
                        $"{ComandExit} - выход. ");
                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = usdBalans - rubInUsd * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else if (enoughMoney >= 0)
                        {
                            rublesBalance += requestedAmount;
                            usdBalans -= rubInUsd * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {usdBalans} долларов.");
                        }
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = usdBalans - eurInUsd * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else if (enoughMoney >= 0)
                        {
                            eurBalans += requestedAmount;
                            usdBalans -= eurInUsd * requestedAmount;
                            Console.WriteLine($"Теперь у вас {usdBalans} долларов и {eurBalans} евро.");
                        }
                    }
                    else if (userInput == ComandExit)
                        Console.WriteLine("Завершение программы!");
                    break;

                case ComandConvertEur:
                    Console.Write($"В выбрали евро, на какую валюту вы хотите поменять: " +
                        $"1 - на доллары." +
                        $"2 - на рубли. " +
                        $"{ComandExit} - Выход.");
                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = eurBalans - usdInEur * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else if (enoughMoney >= 0)
                        {
                            usdBalans += requestedAmount;
                            eurBalans -= usdInEur * requestedAmount;
                            Console.WriteLine($"Теперь у вас {eurBalans} евро и {usdBalans} долларов.");
                        }
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = eurBalans - rubInEur * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else if (enoughMoney >= 0)
                        {
                            rublesBalance += requestedAmount;
                            eurBalans -= rubInEur * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {eurBalans} евро.");
                        }
                    }
                    else if (userInput == ComandExit)
                        Console.WriteLine("Завершение программы!");
                    break;
                case ComandExit:
                    Console.WriteLine("Завершение операции");
                    break;

                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
    }
}