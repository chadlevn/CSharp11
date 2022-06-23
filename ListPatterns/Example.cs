namespace ListPatterns;

public class Example
{
    private readonly List<string> _testList;

    public Example()
    {
        _testList = new List<string>() { "Hello", "World", "." };
    }

    /// <summary>
    ///     List patterns extend pattern matching to match sequences of elements in a list or an array.
    /// </summary>
    [Fact]
    public void BasicPatternMatches()
    {
        var testText = _testList switch   
        {
            ["Hello", "World", "."] => "Pass",
            _ => "Fail"
        };

        Assert.Equal("Pass", testText);
    }

    [Fact]
    public void OrderMattersThoFrFr()
    {
        Assert.False(_testList is ["World", ".", "Hello"]);
    }

    #region The Discard Pattern, _

    [Fact]
    public void DiscardPatternMatches()
    {
        var testText = _testList switch
        {
            [_, "World", "."] => "Pass",
            //[_, "World", _] => "Pass",
            //[_, _, _] => "Pass",
            _ => "Fail"
        };

        Assert.Equal("Pass", testText);
    }

    #endregion

    #region The Range Pattern ..

    [Fact]
    public void RangePatternMatches()
    {
        var testText = _testList switch
        {
            [.., "."] => "Pass",
            //["Hello", ..] => "Pass",
            //[..] => "Pass",
            _ => "Fail"
        };

        Assert.Equal("Pass", testText);
    }

    #endregion

    #region Multiple Use

    [Fact]
    public void WhyNotBoth()
    {
        Assert.True(_testList is [.., _]);
    }

    #endregion
}