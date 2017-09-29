using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSC.Initializer.Utils
{
    public static class ImageUtil
    {
        public static Dictionary<string, ImageType> ImageTypes = new Dictionary<string, ImageType>
        {
            {".jpg", ImageType.Jpg},
            {".jpeg",ImageType.Jpeg},
            {".png",ImageType.Png},
            {".x-png",ImageType.Xpng},
            {".gif",ImageType.Gif}
        };

        public static Dictionary<ImageType, ImageFormat> ImageFormats = new Dictionary<ImageType, ImageFormat>
        {
            {ImageType.Jpg, ImageFormat.Jpeg},
            {ImageType.Jpeg, ImageFormat.Jpeg},
            {ImageType.Png, ImageFormat.Png},
            {ImageType.Xpng, ImageFormat.Png},
            {ImageType.Gif, ImageFormat.Gif}
        };

        public static byte[] ToByteArray(this Image image, ImageType type)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormats[type]);
            return ms.ToArray();
        }

        public static byte[] ToByteArray(this Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.GetImageFormat());
            return ms.ToArray();
        }

        public static Image ToImage(this byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }
            ImageConverter converter = new ImageConverter();
            return (Image)converter.ConvertFrom(byteArrayIn);
        }

        public static System.Drawing.Imaging.ImageFormat GetImageFormat(this System.Drawing.Image img)
        {
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                return System.Drawing.Imaging.ImageFormat.Bmp;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return System.Drawing.Imaging.ImageFormat.Png;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
                return System.Drawing.Imaging.ImageFormat.Emf;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
                return System.Drawing.Imaging.ImageFormat.Exif;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                return System.Drawing.Imaging.ImageFormat.Gif;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
                return System.Drawing.Imaging.ImageFormat.Icon;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
                return System.Drawing.Imaging.ImageFormat.MemoryBmp;
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
                return System.Drawing.Imaging.ImageFormat.Tiff;
            else
                return System.Drawing.Imaging.ImageFormat.Wmf;
        }
    }
}
