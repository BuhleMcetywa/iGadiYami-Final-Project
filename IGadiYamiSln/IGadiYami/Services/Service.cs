using IGadiYami.Interface;
using IGadiYami.Models.UserInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
