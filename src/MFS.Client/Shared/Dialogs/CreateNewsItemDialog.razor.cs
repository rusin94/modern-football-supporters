using MFS.Shared.Dto.NewsItems;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace MFS.Client.Shared.Dialogs;

public partial class CreateNewsItemDialog
{
    [Inject] private DialogService _dialogService { get; set; }
    public NewsItemCreateDto NewsItemCreateDto { get; set; } = new NewsItemCreateDto();

    public void Submit(NewsItemCreateDto dto)
    {
    }

    private void Cancel()
    {
        _dialogService.Close();
    }
}
