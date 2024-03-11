namespace MFS.Core.ValueObjects;

public sealed record TiTle(string Value)
{
    public string Value { get; } = Value;

    public static implicit operator string(TiTle name)
        => name.Value;

    public static implicit operator TiTle(string value)
        => new(value);
}