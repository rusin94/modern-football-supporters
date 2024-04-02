using MFS.Client.Infrastructure.Managers.NewsItem;
using Microsoft.AspNetCore.Components;

namespace MFS.Client.Pages
{
    public partial class NewsItems
    {
        [Inject] private INewsItemManager _newsItemManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await _newsItemManager.GetNewsItemAsync(cancellationToken: new CancellationToken());
            return base.OnInitializedAsync();
        }
    }
}
