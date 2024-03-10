namespace MFS.Core.ValueObjects
{
    public record Summary
    {
        public double Value { get; }

        public static implicit operator double(Summary name)
            => name.Value;

        public static implicit operator Summary(double value)
            => new(value);
    }
}
