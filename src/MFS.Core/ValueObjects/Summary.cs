namespace MFS.Core.ValueObjects
{
    public record Summary(double Value1)
    {
        public double Value { get; } = Value1;

        public static implicit operator double(Summary name)
            => name.Value;

        public static implicit operator Summary(double value)
            => new(value);
    }
}
