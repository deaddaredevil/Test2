namespace test
{
    class Program
    {
        static void Main()
        {
            int imagesCount = 52;
            int picturesInRanges = 3;
            int fullRanges;
            fullRanges = imagesCount / picturesInRanges;
            int extraPictures;
            extraPictures = imagesCount % picturesInRanges;
            Console.WriteLine($"У вас {fullRanges} заполненых рядов и {extraPictures} у вас лишние!");
        }
    }
}