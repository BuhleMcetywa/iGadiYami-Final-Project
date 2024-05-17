using IGadiYami.Models;
using IGadiYami.ViewModels.PlantPageViewModels;
using IGadiYami.Views.Plant_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.ViewModels
{
    public class StartGardeningPageViewModel : BaseViewModel
    {
		private List<StartGardeningMenu> _startGardeningMenus;

		public List<StartGardeningMenu> StartGardeningMenus
		{
			get { return _startGardeningMenus; }
			set { _startGardeningMenus = value; OnPropertyChanged(); }
		}

        public StartGardeningPageViewModel()
        {
            StartGardeningMenuOptionCollections();
        }

        void StartGardeningMenuOptionCollections()
        {
            StartGardeningMenus = new List<StartGardeningMenu>
            {
                new StartGardeningMenu
                {
                    Name = "Onions",
                    Description = "A cold-season crop, easy to grow and a staple in most gardens.",
                    Image = "onions.jpg"
                },
                new StartGardeningMenu
                {
                    Name = "Potatoes",
                    Description = "A versatile root vegetable, rich in vitamins C, B6, and other nutrients.",
                    Image = "potatoes.jpg"
                },
                new StartGardeningMenu
                {
                    Name = "Spinach",
                    Description = "A nutrient-rich leafy green vegetable, originated in Persia.",
                    Image = "spinach.jpg"
                },
                new StartGardeningMenu
                {
                    Name = "Tomatoes",
                    Description = " A major source of antioxidant lycopene, linked to many health benefits.",
                    Image = "tomatoes.jpg"
                },
                new StartGardeningMenu
                {
                    Name = "Carrots",
                    Description = "Rich in beta carotene, fiber, and antioxidants, known for numerous health benefits.",
                    Image = "carrot.jpg"
                }
            };
        }
    }
}
