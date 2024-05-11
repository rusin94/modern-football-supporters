using MFS.Client.Infrastructure.Managers.Authentication;
using MFS.Shared.Dto.Authentication;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace MFS.Client.Pages.Authentication;

public partial class Login
{
    [Inject] 
    public IAuthenticationManager AuthenticationManager { get; set; }

    [Inject]
    private NotificationService NotificationService { get; set; }

    [Inject]
    private NavigationManager NavigationManager { get; set; }

    public LoginDto LoginDto { get; set; } = new LoginDto();

    public async Task LoginUser()
    {
        var result = await AuthenticationManager.LoginAsync(LoginDto);
        if (result.Succeeded)
        {
            NavigationManager.NavigateTo("/");
        }
        else
        {
            foreach (var error in result.Messages)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Błąd",
                    Detail = error,
                    Duration = 4000
                });
            }
        }
    }
    
}