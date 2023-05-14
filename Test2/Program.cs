namespace test
{
    class Program
    {
        static void Main()
        {
            int imagesCount = 52;
            int picturesInRange = 3;
            int fullRanges;
            fullRanges = imagesCount / picturesInRange;
            int extraPictures;
            extraPictures = imagesCount % picturesInRange;
            Console.WriteLine($"У вас {fullRanges} заполненых рядов и {extraPictures} у вас лишние!");
        }
    }
}