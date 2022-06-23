namespace StringPatterns;

public class Example
{
    // You could do this for a few releases now.

    [Fact]
    public void BasicStringPatternMatching()
    {
        var testString = "ABC";

        Assert.True(testString is "ABC");
    }

    // Direct Quote from CSharp Planning GitHub: https://github.com/dotnet/csharplang/blob/main/proposals/pattern-match-span-of-char-on-string.md

    // For perfomance, usage of Span<char> and ReadOnlySpan<char> is preferred over string in many scenarios.
    // The framework has added many new APIs to allow you to use ReadOnlySpan<char> in place of a string.
    // A common operation on strings is to use a switch to test if it is a particular value, and the compiler optimizes such a switch.
    // However there is currently no way to do the same on a ReadOnlySpan<char> efficiently, other than implementing the switch and the optimization manually.
    // In order to encourage adoption of ReadOnlySpan<char> we allow pattern matching a ReadOnlySpan<char>, on a constant string, thus also allowing it to be used in a switch.

    #region ReadOnlySpan and Span<char>

    static bool IsHelloWorld(ReadOnlySpan<char> s)
    {
        return s is "Hello World.";
    }

    static bool IsABC(Span<char> s)
    {
        return s switch { "ABC" => true, _ => false };
    }

    #endregion
}