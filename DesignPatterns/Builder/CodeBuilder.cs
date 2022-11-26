namespace DesignPatterns.Builder;

public class CodeBuilder
{
    public Class classElement = new Class();
    public CodeBuilder(string className)
    {
        classElement.name = className;
    }
    public CodeBuilder AddField(string name, string type)
    {
        var f = new Field(type, name);
        classElement.fields.Add(f);
        return this;
    }
    public override string ToString()
    {
        return classElement.ToString();
    }
}
