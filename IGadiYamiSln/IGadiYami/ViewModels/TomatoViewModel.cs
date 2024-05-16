
using IGadiYami.Models.Tomato;
using IGadiYami.Services;

namespace IGadiYami.ViewModels
{
	public class TomatoViewModel : BaseViewModel
	{ 
		private PlantDatabase _plantDatabase;
		private Tomato tomato;

		public TomatoViewModel()
		{
			_plantDatabase = new PlantDatabase();
			LoadData();
			
		}

		private void LoadData()
		{
			tomato = _plantDatabase.GetTomatoInformation();
		}
	}

}
