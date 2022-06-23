namespace NameOfChanges;

public class Example
{
    /// <summary>
    ///     Type parameter names and parameter names are now in scope when used in a nameof expression in an attribute declaration on that method. 
    /// </summary>
    [Author(nameof(value))]
    public void Scope(string value)
    {
        throw new NotImplementedException();
    }
}

[AttributeUsage(AttributeTargets.Method)]
public class AuthorAttribute : Attribute
{
    private readonly string _name;

    public AuthorAttribute(string name)
    {
        _name = name;
    }

    public string Name => _name;
}