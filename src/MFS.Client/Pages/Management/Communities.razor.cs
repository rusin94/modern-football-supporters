using MFS.Client.Infrastructure.Managers.Community;
using MFS.Client.Shared.Dialogs.Communities;
using MFS.Shared.Dto.Communities;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;

namespace MFS.Client.Pages.Management;

public partial class Communities
{
    [Inject]
    private ICommunityManager _communityManager { get; set; }

    [Inject]
    private NotificationService _notificationService { get; set; }

    [Inject]
    private DialogService _dialogService { get; set; }
    private List<CommunityDto> CommunitiesList { get; set; }

    private RadzenDataGrid<CommunityDto> grid;


    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        await LoadData();
    }

    private async Task LoadData()
    {
        var response = await _communityManager.GetCommunitiesAsync(new CancellationToken());
        if (response.Succeeded)
        {
            CommunitiesList = response.Data;
        }
        else
        {
            _notificationService.Notify(NotificationSeverity.Error, response.Messages.First());
        }
    }

    private async Task AddCommunity()
    {
        var result = await _dialogService.OpenAsync<CreateCommunityDialog>("Create Community", null);
        if (result != null)
        {
            _notificationService.Notify(new NotificationMessage
            {
                Severity = NotificationSeverity.Success,
                Summary = "Sukces",
                Detail = "Społeczność stworzona",
                Duration = 4000,
            });

        }
    }   
}