namespace test
{
    class Program
    {
        static void Main()
        {
            int sumOfImages = 52;
            int picturesInRow = 3;
            int fullRange;
            fullRange = sumOfImages / picturesInRow;
            int extraPictures;
            extraPictures = sumOfImages % 3;
            Console.WriteLine($"У вас {fullRange} заполненых рядов и {extraPictures} у вас лишние!");
        }
    }
}