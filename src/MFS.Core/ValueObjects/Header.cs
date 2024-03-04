namespace MFS.Core.ValueObjects;

public sealed record Header
{
    public string Value { get; }

    public static implicit operator string(Header name)
        => name.Value;

    public static implicit operator Header(string value)
        => new(value);
}