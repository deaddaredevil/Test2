namespace test
{
    class Program
    {
        static void Main()
        {
            string finalWord = "exit";
            string userInput;
            Console.Write("Введите завершающие солово: ");
            userInput = Console.ReadLine();
            bool isExit = finalWord == userInput;
            while (isExit == false)
            {
                Console.WriteLine("Цикл");
                if (userInput == finalWord)
                {  
                    isExit = true;
                }
            }
            Console.WriteLine("Цикла не будет");
            //при переносе в нутрь цикла все перестает работать. т.к объявление userInput переменной идет внитри цикла, а она составляющая булевой переменной. и как в бесконечном цикле вообще можно ввести контрольное слово?
        }
    }
}