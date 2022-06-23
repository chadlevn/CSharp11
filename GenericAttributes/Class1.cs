namespace GenericAttributes;

public class TypeAttribute : Attribute
{
    public TypeAttribute(Type t) => ParamType = t;

    public Type ParamType { get; }
}

public class TypeAttributeUsage
{
    [TypeAttribute(typeof(string))]
    public static string? Method() => default;
}

// This again? I thought this was in C#10. Nope, it never made it. But they promised us that it would maybe be in C#11 maybe. Potentially.

#region C#11 Preview, need <LangVersion>Preview</LangVersion> in csproj

public class GenericAttribute<T> : Attribute { }

public class GenericAttributeUsage
{
    [GenericAttribute<string>()]
    public static string? Method() => default;
}

#endregion