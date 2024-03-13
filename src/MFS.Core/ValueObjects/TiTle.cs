namespace MFS.Core.ValueObjects;

public sealed record Title(string Value)
{
    public string Value { get; } = Value;

    public static implicit operator string(Title name)
        => name.Value;

    public static implicit operator Title(string value)
        => new(value);
}