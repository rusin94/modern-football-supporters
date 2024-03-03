namespace MFS.Core.Common;

public interface IEntity<T>
{
    public T Id { get; set; }
}

public interface IEntity
{
}