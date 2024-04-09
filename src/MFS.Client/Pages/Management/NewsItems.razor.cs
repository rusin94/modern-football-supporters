using MFS.Client.Infrastructure.Managers.NewsItem;
using MFS.Shared.Dto.NewsItems;
using Microsoft.AspNetCore.Components;

namespace MFS.Client.Pages.Management;

public partial class NewsItems
{
    [Inject] private INewsItemManager _newsItemManager { get; set; }

    public List<NewsItemDto> NewsItemDtos { get; set; }


    protected override async Task OnInitializedAsync()
    {
        NewsItemDtos = await _newsItemManager.GetNewsItemAsync();
        await base.OnInitializedAsync();
    }
}