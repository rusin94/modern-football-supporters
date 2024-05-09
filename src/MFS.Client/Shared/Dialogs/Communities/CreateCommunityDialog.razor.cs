using MFS.Client.Infrastructure.Managers.Community;
using MFS.Shared.Dto.Communities;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace MFS.Client.Shared.Dialogs.Communities
{
    public partial class CreateCommunityDialog
    {
        [Inject]
        private DialogService _dialogService { get; set; }

        [Inject]
        private ICommunityManager _communityManager { get; set; }

        public CommunityCreateDto CommunityCreateDto { get; set; } = new();

        public async Task Submit(CommunityCreateDto dto)
        {
            await _communityManager.CreateCommunityAsync(dto );
            _dialogService.Close(true);
        }

        public void Cancel()
        {
            _dialogService.Close();
        }
    }
}
