﻿using System.IO;

namespace Application.Const.PathUtility
{
    public static class PathTools
    {
        public static string AboutUsServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/about/");
        public static string ConstructorServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/constructor/");
        public static string SpectacularServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/spectacular/");
        public static string TeamServernPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/team/");

    }
}