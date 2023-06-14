namespace test
{
    class Program
    {
        static void Main()
        {
            const string CommandConvertRublesToDollars = "1";
            const string CommandConvertRublesToEuro = "2";
            const string CommandConvertDollarsToRubles = "3";
            const string CommandConvertDollarsToEuro = "4";
            const string CommandConvertEuroToRubles = "5";
            const string CommandConvertEuroToDollars = "6";
            const string CommandExit = "exit";

            float rublesBalance;
            float dollarsBalance;
            float euroBalance;
            float rublesInDollars = 0.012f;
            float rublesInEuro = 0.011f;
            float dollarsInRubles = 82.59f;
            float dollarsInEuro = 0.93f;
            float euroInRubles = 88.87f;
            float euroInDollars = 1.08f;
            string userInput = "";
            int requestedAmount;
            float enoughMoney;
            bool isWork = true;

            Console.WriteLine("Добро пожаловать в обменник валют. Укажите количество средств на счете.");
            Console.Write("Сколько у вас рублей: ");
            rublesBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас долларов: ");
            dollarsBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас евро: ");
            euroBalance = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Какую валюту вы хотите поменять:" +
                $"{CommandConvertRublesToDollars} - Рубли на доллары." +
                $"{CommandConvertRublesToEuro} - Рубли на евро." +
                $"{CommandConvertDollarsToRubles} - Доллары на рубли." +
                $"{CommandConvertDollarsToEuro} - Доллары на евро" +
                $"{CommandConvertEuroToRubles} - Евро на рубли" +
                $"{CommandConvertEuroToDollars} - Евро на доллары" +
                $"{CommandExit} - Выход.");
            userInput = Console.ReadLine();

            while (isWork)
            {
                switch (userInput)
                {
                    case CommandConvertRublesToDollars:
                        Console.WriteLine("В выбрали рубли на доллары, сколько вы хотите поменять: ");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = rublesBalance - dollarsInRubles * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            dollarsBalance += requestedAmount;
                            rublesBalance -= dollarsInRubles * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {dollarsBalance} долларов.");
                        }
                        break;

                    case CommandConvertRublesToEuro:
                        Console.WriteLine("В выбрали рубли на евро, сколько вы хотите поменять: ");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = rublesBalance - euroInRubles * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            euroBalance += requestedAmount;
                            rublesBalance -= euroInRubles * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {euroBalance} евро.");
                        }
                        break;

                    case CommandConvertDollarsToRubles:
                        Console.WriteLine("В выбрали доллары на рубли, сколько вы хотите поменять: ");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = dollarsBalance - rublesInDollars * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            rublesBalance += requestedAmount;
                            dollarsBalance -= rublesInDollars * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {dollarsBalance} долларов.");
                        }
                        break;

                    case CommandConvertDollarsToEuro:
                        Console.WriteLine("В выбрали доллары на евро, сколько вы хотите поменять: ");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = dollarsBalance - euroInDollars * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            euroBalance += requestedAmount;
                            dollarsBalance -= euroInDollars * requestedAmount;
                            Console.WriteLine($"Теперь у вас {dollarsBalance} долларов и {euroBalance} евро.");
                        }
                        break;

                    case CommandConvertEuroToRubles:
                        Console.WriteLine("В выбрали евро на рубли, сколько вы хотите поменять: ");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = euroBalance - rublesInEuro * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            rublesBalance += requestedAmount;
                            euroBalance -= rublesInEuro * requestedAmount;
                            Console.WriteLine($"Теперь у вас {rublesBalance} рублей и {euroBalance} евро.");
                        }
                        break;

                    case CommandConvertEuroToDollars:
                        Console.WriteLine("В выбрали евро на доллары, сколько вы хотите поменять: ");
                        requestedAmount = Convert.ToInt32(Console.ReadLine());
                        enoughMoney = euroBalance - dollarsInEuro * requestedAmount;

                        if (enoughMoney < 0)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            dollarsBalance += requestedAmount;
                            euroBalance -= dollarsInEuro * requestedAmount;
                            Console.WriteLine($"Теперь у вас {dollarsBalance} долларов и {euroBalance} евро.");
                        }
                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }
            }

            Console.WriteLine("Всего доброго!");
        }
    }
}