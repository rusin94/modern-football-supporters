namespace MFS.Shared.Wrapper;

public interface IResult
{
    List<string> Messages { get; set; }
    bool Succeeded { get; set; }
}

public interface IResult<T> : IResult
{
    T Data { get; set; }
}