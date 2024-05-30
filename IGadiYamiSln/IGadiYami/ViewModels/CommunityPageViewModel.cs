using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.ViewModels
{
    public partial class CommunityPageViewModel : BaseViewModel
    {
		private bool _ismessagevisible;
		public bool IsMessageVisible
		{
			get { return _ismessagevisible; }
			set { _ismessagevisible = value; OnPropertyChanged(); }
		}

		public CommunityPageViewModel()
		{
            IsMessageVisible = false;
		}

        public void MakeMessageVisible()
		{
            IsMessageVisible = true;
		}

		[RelayCommand]
		public void ShowMessage()
		{
			MakeMessageVisible();
		}
	}
}
