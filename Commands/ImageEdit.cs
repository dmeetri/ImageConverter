using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace Commands
{
    public class ImageEdit
    {
        public void resize(string path, int newHeight)
        {
            string home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullPath = path.Replace("~", home);
            string directory = Path.GetDirectoryName(fullPath);
            string filename = Path.GetFileName(path);

            using (Image image = Image.Load(fullPath))
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                int newWidth = (originalWidth * newHeight) / originalHeight;
                image.Mutate(x => x.Resize(newWidth, newHeight));

                string newPath = Path.Combine(directory, "resized_" + filename);
                image.Save(newPath);

                Console.WriteLine($"Image is saved as {newPath}");
            }
        }

        public void convert()
        {
            
        }

        public void deleteData()
        {

        }
    }
}