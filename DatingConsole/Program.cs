namespace DatingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Forrest Hartley", 35, "Boston", "US", "he/him");
            Console.WriteLine(sam.ViewProfile());
            sam.SetHobbies(new string[] { "reading", "writing computer programs", "watching star trek" });
            Console.WriteLine(sam.ViewProfile());
        }

    }
}