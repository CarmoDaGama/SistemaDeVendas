using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Framework
{
    public static class ImagemUtils
    {
        public static byte[] ConvertImagemParaArrayByte(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Bmp);

            return stream.ToArray();
        }
        public static Image ConvertArrayByteParaImagem(byte[] bytes)
        {
            MemoryStream straem = new MemoryStream(bytes);
            return Image.FromStream(straem);
        }
    }
}
