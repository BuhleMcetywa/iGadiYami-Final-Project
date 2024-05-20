using IGadiYami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Services
{
    public interface IPlantDatabase
    {
		List<Disease> GetDiseasesForVegetable(int vegTypeID);

	}
}
