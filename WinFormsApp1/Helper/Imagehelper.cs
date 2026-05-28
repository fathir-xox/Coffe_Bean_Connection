using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Imaging;

namespace FinalProjek.Helper
{
    public class Imagehelper
    {
        public static byte[] ImageToBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image BinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }
    }
}
