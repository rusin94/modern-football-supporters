namespace MFS.Shared.Dto.Authentication;

public record LoginDto
{
    public string Email { get; init; }
    public string Password { get; init; }
}