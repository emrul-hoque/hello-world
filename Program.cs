namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            User userOne = new(){ Id = 132, Name = "Jabir"};
            Console.WriteLine($">>>>>>>> Hello {userOne.Name}!");
        }
    }
}