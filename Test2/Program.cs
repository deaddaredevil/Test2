namespace test
{
    class Program
    {
        static void Main()
        {
            string theFinalWord = "exit";
            string userImrut; 

            Console.Write("Введите завершающие солово: ");
            userImrut = Console.ReadLine();

            bool isExit = theFinalWord == userImrut;

            while (isExit == false)
            {
                Console.WriteLine("Цикл");
                if (isExit == true)
                {
                    break;
                }
            }
            Console.WriteLine("Цикла не будет");
        }
    }
}