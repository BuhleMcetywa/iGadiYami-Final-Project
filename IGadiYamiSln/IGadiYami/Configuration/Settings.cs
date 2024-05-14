using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Configuration
{
    public class Settings : ISettings
    {
        // Custom Vision Details
        public static string CustomVisionEndPoint => "https://igadiyamicusomvision.cognitiveservices.azure.com/";
        public static string PredictionKey => "ea23dda48ae741fe95fdcff27c9bc7ed";
        public static string ProjectId => "312aeef8-548d-4c7c-840c-01e05059f978";
        public static string PublishedName => "Plant Disease Detection";
    }
}
