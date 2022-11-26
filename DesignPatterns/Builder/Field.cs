namespace DesignPatterns.Builder;

public class Field
{
    public string type;
    public string name;
    public Field(string type, string name)
    {
        this.type = type;
        this.name = name;
    }

    public override string ToString()
    {
        return $"public {type} {name}";
    }
}
