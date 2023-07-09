using System.IO;

namespace Application.Const.PathUtility
{
    public static class PathTools
    {
        public static string AboutUsServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/about/");
        public static string ConstructorServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/constructor/");
        public static string SpectacularServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/spectacular/");
        public static string TeamServernPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/team/");
        public static string BannerServernPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/banner/");
        public static string RealEstateServiceImageServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/realestateservice/");
        public static string PropertyImageServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/property/");
        public static string PropertyGalleryServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/gallery/");

    }
}
