namespace MFS.Core.ValueObjects;

public sealed record Author
{
    public string Value { get; }

    public static implicit operator string(Author name)
        => name.Value;

    public static implicit operator Author(string value)
        => new(value);
}