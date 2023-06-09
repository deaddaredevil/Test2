namespace test
{
    class Program
    {
        static void Main()
        {
            const string ComandConvertRub = "1";
            const string ComandConvertUsd = "2";
            const string ComandConvertEur = "3";

            float hasRub;
            float hasUsd;
            float hasEur;
            float rubInUsd = 0.012f, rubInEur = 0.011f, usdInRub = 82.59f, usdInEur = 0.93f, eurInRub = 88.87f, eurInUsd = 1.08f;
            string userSelection = "";
            int requestedAmount;
            float enoughMoney;

            Console.WriteLine("Добро пожаловать в обменник валют. Укажите количество средств на счете.");
            Console.Write("Сколько у вас рублей: ");
            hasRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас долларов: ");
            hasUsd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас евро: ");
            hasEur = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Какую валюту вы хотите поменять:" +
                $"{ComandConvertRub} - Рубли." +
                $"{ComandConvertUsd} - Доллары." +
                $"{ComandConvertEur} - Евро.");
            userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case ComandConvertRub:
                    Console.Write("В выбрали рубли, на какую валюту вы хотите поменять: " +
                        "1 - на доллары." +
                        "2 - на евро. ");
                    userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = hasRub - usdInRub * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            hasUsd += requestedAmount;
                            hasRub -= usdInRub * requestedAmount;
                            Console.WriteLine($"Теперь у вас {hasRub} рублей и {hasUsd} долларов.");
                        }
                    }
                    else if (userSelection == "2")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = hasRub - eurInRub * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            hasEur += requestedAmount;
                            hasRub -= eurInRub * requestedAmount;
                            Console.WriteLine($"Теперь у вас {hasRub} рублей и {hasEur} долларов.");
                        }
                    }
                    break;
                case ComandConvertUsd:
                    Console.Write("В выбрали доллары, на какую валюту вы хотите поменять: " +
                        "1 - на рубли." +
                        "2 - на евро. ");
                    userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = hasUsd - rubInUsd * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            hasRub += requestedAmount;
                            hasUsd -= rubInUsd * requestedAmount;
                            Console.WriteLine($"Теперь у вас {hasRub} рублей и {hasUsd} долларов.");
                        }
                    }
                    else if (userSelection == "2")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = hasUsd - eurInUsd * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            hasEur += requestedAmount;
                            hasUsd -= eurInUsd * requestedAmount;
                            Console.WriteLine($"Теперь у вас {hasUsd} долларов и {hasEur} евро.");
                        }
                    }
                    break;
                case ComandConvertEur:
                    Console.Write("В выбрали евро, на какую валюту вы хотите поменять: " +
                        "1 - на доллары." +
                        "2 - на рубли. ");
                    userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = hasEur - usdInEur * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            hasUsd += requestedAmount;
                            hasEur -= usdInEur * requestedAmount;
                            Console.WriteLine($"Теперь у вас {hasEur} евро и {hasUsd} долларов.");
                        }
                    }
                    else if (userSelection == "2")
                    {
                        Console.WriteLine("сколько валюты вы хотите?");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = hasEur - rubInEur * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            hasRub += requestedAmount;
                            hasEur -= rubInEur * requestedAmount;
                            Console.WriteLine($"Теперь у вас {hasRub} рублей и {hasEur} евро.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
    }
}