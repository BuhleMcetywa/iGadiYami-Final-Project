using IGadiYami.Models.Carrot;
using IGadiYami.Models.Onion;
using IGadiYami.Models.Potato;
using IGadiYami.Models.Spinach;
using IGadiYami.Models.Tomato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Services
{
    public interface IPlantDatabase
    {
        // Carrots
        Carrot GetCarrotInformation();
        CarrotDisease GetCarrotDiseaseByName(string name);

        // Onions
        Onion GetOnionInformation();
        OnionDisease GetOnionDiseaseByName(string name);

        // Potatoes
        Potato GetPotatoInformation();
        PotatoDisease GetPotatoDiseaseByName(string name);

        // Spinachs
        Spinach GetSpinachInformation();
        SpinachDisease GetSpinachDiseaseByName(string name);

        // Tomatoes
        Tomato GetTomatoInformation();
        TomatoDisease GetTomatoDiseaseByName(string name);
    }
}
