namespace HomeWorkAuthPager.Helper
{
    public class ImageMethods
    {
        public static string AddFile(
            IWebHostEnvironment appEnvironment,
            IFormFile uploadedFile
            )
        {
            string ImgName = "default.jpg";
            if (uploadedFile != null)
            {
                string filename = uploadedFile.FileName;
                string path = appEnvironment.WebRootPath;
                string extension = Path.GetExtension(filename);
                string name = Path.GetFileNameWithoutExtension(filename);
                string uniqName = Guid.NewGuid().ToString();

                ImgName = $"{name}_{uniqName}{extension}";

                string pathToImg = Path.Combine(path, "image", ImgName);

                using (var fs = new FileStream(pathToImg, FileMode.Create))
                {
                    uploadedFile.CopyTo(fs);
                }
            }
            return ImgName;
        }
    }
}
