using IGadiYami.Models.Diseases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Services
{
    public interface IPlantDatabase
    {
		Disease GetDiseaseByTag(string tag);
		List<Disease> GetDiseasesForVegetable(int vegTypeID);

	}
}
