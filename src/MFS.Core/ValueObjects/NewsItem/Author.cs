namespace MFS.Core.ValueObjects.NewsItem;

public sealed record Author(string Value)
{
    public string Value { get; } = Value;

    public static implicit operator string(Author name)
        => name.Value;

    public static implicit operator Author(string value)
        => new(value);
}