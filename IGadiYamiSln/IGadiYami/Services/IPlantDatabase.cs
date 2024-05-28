using IGadiYami.Models;

namespace IGadiYami.Services
{
    public interface IPlantDatabase
    {
        Disease GetDiseaseByTag(string tag);
        List<Disease> GetDiseasesForVegetable(int vegTypeID);

    }
}
