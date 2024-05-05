using MFS.Client.Infrastructure.Managers.NewsItem;
using MFS.Client.Shared.Dialogs.NewsItems;
using MFS.Shared.Dto.NewsItems;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;

namespace MFS.Client.Pages.Management;

public partial class NewsItems
{
    private RadzenDataGrid<NewsItemDto> grid;
    [Inject] 
    private INewsItemManager _newsItemManager { get; set; }
    [Inject] 
    private DialogService _dialogService { get; set; }
    [Inject] 
    private NotificationService _notificationService { get; set; }
    public List<NewsItemDto> NewsItemDtos { get; set; }


    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        await LoadData();
    }

    private async Task LoadData()
    {
        var result = await _newsItemManager.GetNewsItemAsync();
        if (result.Succeeded)
        {
            NewsItemDtos = result.Data;
        }
        else
        {
            foreach (var message in result.Messages)
            {
                _notificationService.Notify((new NotificationMessage
                {
                    Severity = NotificationSeverity.Error, Summary = "Błąd", Detail = message,
                    Duration = 4000
                }));
            }
        }
    }

    private async Task AddNewsItem()
    {
        var result = await _dialogService.OpenAsync<CreateNewsItemDialog>("Create News Item");
        if (result)
        {
            _notificationService.Notify((new NotificationMessage
            {
                Severity = NotificationSeverity.Success,
                Summary = "Sukces",
                Detail = "Dodano news",
                Duration = 4000
            }));
        }
    }
}