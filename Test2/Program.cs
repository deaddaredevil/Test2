namespace test
{
    class Program
    {
        static void Main()
        {
            string finalWord = "exit";
            string userInput = default;
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Цикл");
                Console.Write("Введите завершающие слово:");
                userInput = Console.ReadLine();

                if (userInput == finalWord)
                {
                    isExit = true;
                }
            }

            Console.WriteLine("Цикла не будет");
        }
    }
}