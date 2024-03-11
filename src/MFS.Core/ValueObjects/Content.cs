namespace MFS.Core.ValueObjects;

public sealed record Content(string Value)
{
    public string Value { get; } = Value;

    public static implicit operator string(Content name)
        => name.Value;

    public static implicit operator Content(string value)
        => new(value);
}