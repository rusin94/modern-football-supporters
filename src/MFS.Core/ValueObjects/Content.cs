namespace MFS.Core.ValueObjects;

public sealed record Content
{
    public string Value { get; }

    public static implicit operator string(Content name)
        => name.Value;

    public static implicit operator Content(string value)
        => new(value);
}