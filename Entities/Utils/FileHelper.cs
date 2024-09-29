using Microsoft.AspNetCore.Http;

namespace Entities.Utils
{
    public static class FileHelper
    {
        public static async Task<string> SaveFileAsync(IFormFile file, string Type)
        {
            // TODO add image compression 


            if (file == null || file.Length == 0)
            {
                return null;
            }



            var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Media");

            if (!Directory.Exists(uploadsFolderPath))
            {
                Directory.CreateDirectory(uploadsFolderPath);
            }

            uploadsFolderPath = Path.Combine(uploadsFolderPath, Type);

            if (!Directory.Exists(uploadsFolderPath))
            {
                Directory.CreateDirectory(uploadsFolderPath);
            }

            var uniqueFileName = (Guid.NewGuid().ToString().Substring(0, 7)) + DateTime.Now.Ticks.ToString() + "_" + file.FileName;
            var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return uniqueFileName;
        }
    }
}
