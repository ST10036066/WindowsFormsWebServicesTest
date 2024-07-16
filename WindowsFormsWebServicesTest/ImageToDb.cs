using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.ImageFormatConverter;

namespace WindowsFormsWebServicesTest
{
    public  class ImageToDb
    {
        public ImageToDb() { }
        //-------------------------------------------------------
        public byte[] PhotoProcess(Image image)
        {
            //send image and return a byte to the arrray
            var ms = new MemoryStream();
            image.Save(ms, ImageToDb.Png);
                var photo = ms.ToArray();
            return PhotoProcess();
        }

        //----------------------------
        public Image PhotoBuilder(byte[] imageData)
        {
            var fs = new FileStream (path: "image.bmp", FileMode.Create);
            fs.Write(imageData, offset: 0, count: imageData.Length);
            var image = Image.FromStream(fs);
            fs.Close();
            return image;

        }
        //--------------------------------------------------
        public Bitmap GetBitmap()
        {
            var open = new OpenFileDialog
            { 
                Filter = "Image File(*.jpg; *.jpeg; *.gif; *.bmp; *.png) |*.jpg; *.jpeg; *.gif; *.bmp; *.png;*.jfif"

            };
            if(open.ShowDialog() == DialogResult.OK)
            {
                var image = new Bitmap(open.FileName);
                return image;
            }
            return null;
        }
    }
}
