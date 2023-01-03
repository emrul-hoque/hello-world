namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * STEPS:
            * 1. Add to stage: git add -A
            * 2. Commit: git commit -m "any message"
            * 3. Push: git push
            */
            Console.WriteLine("What is your name?");
            string? MyName = Convert.ToString(Console.ReadLine());
            User userOne = new(){ Id = 132, Name = MyName};
            Console.WriteLine($"Hello {userOne.Name}!");
            userOne.SaySomething();
        }
    }
}