namespace RawStringLiterals;

public class Example
{
    // Raw String Literals are still in Preview, part of .NET 7

    /// <summary>
    ///     Raw string literals are a new format for string literals. 
    ///     A raw string literal starts with at least three double-quote (""") characters. It ends with the same number of double-quote characters.
    /// </summary>
    public string LiteralString = """This is a literal string""";

    /// <summary>
    ///     New lines for the beginning and end don't count. The example below prints "Hello World."
    /// </summary>
    [Fact]
    public void FirstAndLastNewLinesDontCount()
    {
        // The alignment of the triple double quotes matters here. Any text behind these quotes will not compile.
        var testString = 
            """
            Hello World.
            """;

        Assert.Equal("Hello World.", testString);
    }

    /// <summary>
    ///     Interpolation can be mixed with this, just as you might expect.
    /// </summary>
    static readonly string _world = "World";
    public string NowWithInterpolation =
        $"""
        Hello {_world}.
        """;

    /// <summary>
    ///     If you want to mix interpolation with JSON, just add extra dollar signs equal to how many you'd like the escape count to be.
    /// </summary>
    public string EscapedByBrackets =
        $$"""
        {
            "parameter": "Hello {{_world}}."
        }
        """;

    /// <summary>
    ///     If you need a lot of double quotes for some reason (seriously though, why do you need so many?) you can escape them by increasing the opening and closing quotes until you have a greater number.
    /// </summary>
    public string EscapedByQuotes =
        """""
        Sometimes you need a """"LOT"""" of double quotes!
        """"";
}