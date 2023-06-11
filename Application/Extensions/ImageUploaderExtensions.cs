using Microsoft.AspNetCore.Http;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class ImageUploaderExtensions
    {
        public static string UploadImage(string base64String, string path, string deleteFileName = null)
        {
            if (string.IsNullOrEmpty(base64String))
                return null;
            var image = Base64ToImage(base64String);
            var resizedImage = new Bitmap(image, new Size(256, 256));

            if (image is null || resizedImage is null)
                return null;
            var imageName = Guid.NewGuid().ToString("N") + ".jpeg";
            image.AddImageToServer(imageName, path+"origin/", deleteFileName);
            resizedImage.AddImageToServer(imageName, path+"compressed/", deleteFileName);
            return imageName;
        }
        public static void AddImageToServer(this Image image, string fileName, string path, string deleteFileName = null)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            if (!string.IsNullOrEmpty(deleteFileName)) File.Delete(path + deleteFileName);

            string imageName = path + fileName;
            using (var stream = new FileStream(imageName, FileMode.Create))
            {
                if (!Directory.Exists(imageName)) image.Save(stream, ImageFormat.Jpeg);
            }

        }

        public static void DeleteImageFromServer(string fileName, string originalPath)
        {

            File.Delete(originalPath + fileName);

        }

        public static byte[] DecodeUrlBase64(string s)
        {
            return Convert.FromBase64String(s.Substring(s.LastIndexOf(',') + 1));
        }

        public static Image Base64ToImage(string base64String)
        {
            var res = DecodeUrlBase64(base64String);
            MemoryStream ms = new MemoryStream(res, 0, res.Length);
            ms.Write(res, 0, res.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public static async Task<byte[]> GetBytes(this IFormFile formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                await formFile.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }

    }
}
