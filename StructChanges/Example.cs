namespace StructChanges;

struct Person
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }

    // The C# 11 compiler ensures that all fields of a struct type are initialized to their default value as part of executing a constructor.
    // This change means any field or auto property not initialized by a constructor is automatically initialized by the compiler.
    // Structs where the constructor doesn't definitely assign all fields now compile, and any fields not explicitly initialized are set to their default value.
    // You can read more about how this change affects struct initialization in the article on structs.

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
