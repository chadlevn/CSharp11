namespace RequiredKeyword;

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
}

public class PersonContainer
{
    private readonly Person _person;

    public PersonContainer()
    {
        // The below code won't compile unless all required fields are passed along. This helps to eliminate the need for lengthy constructors.
        _person = new Person()
        {
            FirstName = "John",
            LastName = "Smith"
        };
    }
}
