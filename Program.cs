namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * 1. Add to stage: git add -A
            * 2. Commit: git commit -m "summary of the changes"
            * 3. Push: git push
            */

            User userOne = new(){ Id = 132, Name = "Jabir"};
            Console.WriteLine($"Hello {userOne.Name}!");
        }
    }
}