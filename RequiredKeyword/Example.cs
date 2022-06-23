﻿namespace RequiredKeyword;

/// <summary>
///     The new required keyword can replace the use of constructors.
/// </summary>
public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
}

#region How It Works

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

#endregion

#region Extending a Class

// Yes, developers are people too.
public class Developer : Person
{
    // Don't have to worry about a bunch of different constructors here!
}

public class DeveloperContainer
{
    private readonly Developer _person;

    public DeveloperContainer()
    {
        // The below code won't compile unless all required fields are passed along. This helps to eliminate the need for lengthy constructors.
        _person = new Developer()
        {
            FirstName = "John",
            LastName = "Smith"
        };
    }
}

#endregion