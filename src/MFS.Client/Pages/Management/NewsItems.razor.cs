using MFS.Client.Infrastructure.Managers.NewsItem;
using MFS.Client.Shared.Dialogs;
using MFS.Shared.Dto.NewsItems;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;

namespace MFS.Client.Pages.Management;

public partial class NewsItems
{
    private RadzenDataGrid<NewsItemDto> grid;
    [Inject] private INewsItemManager _newsItemManager { get; set; }
    [Inject] private DialogService _dialogService { get; set; }
    public List<NewsItemDto> NewsItemDtos { get; set; }


    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        NewsItemDtos = await _newsItemManager.GetNewsItemAsync();
    }

    private async Task AddNewsItem()
    {
        await _dialogService.OpenAsync<CreateNewsItemDialog>("Create News Item");
    }
}