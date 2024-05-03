using MFS.Client.Infrastructure.Managers.Community;
using MFS.Shared.Dto.Communities;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace MFS.Client.Pages.Management;

public partial class Communities
{
    [Inject]
    private ICommunityManager _communityManager { get; set; }

    [Inject]
    private NotificationService _notificationService { get; set; }
    private List<CommunityDto> CommunitiesList { get; set; }


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

}