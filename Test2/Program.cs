namespace test
{
    class Program
    {
        static void Main()
        {
            string outputString;
            int numberOfStringOutput;
            Console.Write("Введите ваше сообщение: ");
            outputString = Console.ReadLine();
            Console.WriteLine("Сколько вы хотите его дублировать? ");
            numberOfStringOutput = Convert.ToInt32(Console.ReadLine());
            for(int i = numberOfStringOutput; i > 0; i--)
            {
                Console.WriteLine(outputString);
            }
        }
    }
}