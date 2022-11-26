using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder;

public class Class
{
    public string name;
    public List<Field> fields = new List<Field>();
    public Class()
    {

    }
    public Class(string name, List<Field> fields)
    {
        this.name = name;
        this.fields = fields;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"public class {name}").AppendLine("{");
        foreach (var f in fields)
            sb.AppendLine($"  {f};");
        sb.AppendLine("}");
        return sb.ToString();
    }
}
