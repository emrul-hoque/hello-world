public class User
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string SaySomething()
    {
        return "Hello World";
    }
}