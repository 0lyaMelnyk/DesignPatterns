namespace DesignPatterns.Factory;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    internal Person(string name, int id)
    {
        Id = id;
        Name = name;
    }
}
