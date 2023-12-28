using System.Drawing.Imaging;

namespace FilmsStorage.Settings
{
    public class FileManager
    {
        private const string _imagesDir = @"D:\COURSE WORKS\CourseWork\FilmsStorage\FilmsStorageImages";

        private const string _imagesFilter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif;*.jfif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif;*.jfif" +
                                           "|PNG Portable Network Graphics (*.png)|*.png" +
                                           "|BMP Windows Bitmap (*.bmp)|*.bmp" +
                                           "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
                                           "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
                                           "|GIF Graphics Interchange Format (*.gif)|*.gif";


        public static Bitmap? LoadImage()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = _imagesFilter;

                if (DialogResult.OK == dialog.ShowDialog())
                {
                    return new Bitmap(dialog.FileName);
                }
            }

            return null;
        }

        public static string SaveImage(Image image)
        {
            var name = $"{Guid.NewGuid()}.jpeg";
            var path = Path.Combine(_imagesDir, name);

            image.Save(path, ImageFormat.Jpeg);

            return name;
        }

        public static Image GetImage(string name)
        {
            var path = Path.Combine(_imagesDir, name);

            return Image.FromFile(path);
        }
    }
}
