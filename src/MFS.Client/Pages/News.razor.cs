using MFS.Client.Infrastructure.Managers.NewsItem;
using MFS.Shared.Dto.NewsItems;
using Microsoft.AspNetCore.Components;

namespace MFS.Client.Pages;

public partial class News
{
    [Inject] private INewsItemManager _newsItemManager { get; set; }
    public IEnumerable<NewsItemDto> NewsItemDtos { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var result = await _newsItemManager.GetNewsItemAsync(CancellationToken.None);
        await base.OnInitializedAsync();
    }
}