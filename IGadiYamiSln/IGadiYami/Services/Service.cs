
using IGadiYami.Interface;
using IGadiYami.Models;

namespace IGadiYami.Services
{
    public class Service : IService
    {
        private IAlertDialogService _dialogService;

        public Service(IAlertDialogService dialogService)
        {
            _dialogService = dialogService;

        }

        public async void Save(UserDetails signup)
        {
            await _dialogService.ShowAlertAsync("Save", $"{signup.Name} Saved", "Ok");

        }

    }
}
