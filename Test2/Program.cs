namespace test
{
    class Program
    {
        static void Main()
        {
            string name = "Evtushenko";
            string famileName = "Valentin";
            Console.WriteLine(name + " " + famileName);
            string trueName;
            string trueFamilyName;
            trueName = famileName;
            trueFamilyName = name;
            Console.WriteLine(trueName + " " + trueFamilyName);

        }
    }
}