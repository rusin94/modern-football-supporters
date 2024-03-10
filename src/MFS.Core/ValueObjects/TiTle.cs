namespace MFS.Core.ValueObjects;

public sealed record TiTle
{
    public string Value { get; }

    public static implicit operator string(TiTle name)
        => name.Value;

    public static implicit operator TiTle(string value)
        => new(value);
}