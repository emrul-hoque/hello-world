public class User
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public void SaySomething()
    {
        Console.WriteLine("Are you a Male or Female ?");
        string? gender = Convert.ToString(Console.ReadLine());
        if(gender == "F" || gender == "Female" || gender == "female")
        {
            Console.WriteLine("You're a good girl, " + Name);
        }

        else
        {
            Console.WriteLine("You're a good boy, " + Name);
        }
        
    }
}