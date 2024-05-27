namespace IGadiYami.Interface
{
    public partial interface IAlertDialogService
    {
        Task ShowAlertAsync(string title, string message, string cancel = "OK");
    }
}
