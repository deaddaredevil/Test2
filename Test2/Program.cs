namespace test
{
    class Program
    {
        static void Main()
        {
            int sumPicture = 52;
            int completedLine;
            completedLine = sumPicture / 3;
            int lackPicture;
            lackPicture = 3 - sumPicture % 3;
            Console.WriteLine($"У вас {completedLine} заполненых рядов и вам не хватает {lackPicture} до завершение следующего!");

        }
    }
}