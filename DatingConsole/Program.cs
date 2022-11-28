namespace DatingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile bear = new Profile("Forrest Hartley", 35, "Boston", "US", "he/him");
            Console.WriteLine(bear.ViewProfile());
            bear.SetHobbies(new string[] { "reading", "writing computer programs", "watching star trek" });
            Console.WriteLine(bear.ViewProfile());
        }

    }
}