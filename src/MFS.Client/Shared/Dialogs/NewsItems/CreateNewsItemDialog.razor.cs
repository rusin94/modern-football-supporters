using MFS.Client.Infrastructure.Managers.NewsItem;
using MFS.Shared.Dto.NewsItems;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace MFS.Client.Shared.Dialogs.NewsItems;

public partial class CreateNewsItemDialog
{
    [Inject]
    private DialogService _dialogService { get; set; }
    [Inject]
    private INewsItemManager _newsItemManager { get; set; }
    public NewsItemCreateDto NewsItemCreateDto { get; set; } = new NewsItemCreateDto();

    public async Task Submit(NewsItemCreateDto dto)
    {
        await _newsItemManager.CreateNewsItemAsync(dto);
        _dialogService.Close(true);
    }

    private void Cancel()
    {
        _dialogService.Close();
    }
}
