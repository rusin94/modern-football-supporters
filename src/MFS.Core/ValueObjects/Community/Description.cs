namespace MFS.Core.ValueObjects.Community;

public record Description(string Value)
{
    public string Value { get; }

    public static implicit operator string(Description description)
        => description.Value;

    public static implicit operator Description(string value)
        => new(value);
}