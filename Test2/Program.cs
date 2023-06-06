namespace test
{
    class Program
    {
        static void Main()
        {
            string theFinalWord = "exit";
            string userInrut;
            bool isExit = theFinalWord == userInrut;

            while (isExit == false)
            {
                Console.Write("Введите завершающие солово: ");
                userInrut = Console.ReadLine();
                Console.WriteLine("Цикл");
                if (userInrut == theFinalWord)
                {
                    isExit == true;
                }
            }
            Console.WriteLine("Цикла не будет");
            //при переносе в нутрь цикла все перестает работать. т.к объявление userInput переменной идет внитри цикла, а она составляющая булевой переменной. и как в бесконечном цикле вообще можно ввести контрольное слово?
        }
    }
}