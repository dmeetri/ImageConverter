using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace Commands
{
    public class ImageEdit
    {
        public void Resize(string path, string width, string height)
        {
            int targetWidth = int.Parse(width);
            int targetHeight = int.Parse(height);

            using (Image image = Image.Load(path))
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;

                image.Mutate(x => x.Resize(targetWidth, targetHeight));

                string newPath = "resized_" + path;
                image.Save(newPath);

                Console.WriteLine($"Изображение сохранено как {newPath}");
            }
        }

        public void Convert()
        {
            
        }

        public void DeleteData()
        {

        }
    }
}