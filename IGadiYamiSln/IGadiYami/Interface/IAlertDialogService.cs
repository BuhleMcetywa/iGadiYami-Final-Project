using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Interface
{
    public partial interface IAlertDialogService
    {
        Task ShowAlertAsync(string title, string message, string cancel = "OK");
    }
}
