namespace MFS.Core.ValueObjects.Community;

public record Name(string Value)
{
    public string Value { get; }

    public static implicit operator string(Name name)
        => name.Value;

    public static implicit operator Name(string value)
        => new(value);
}