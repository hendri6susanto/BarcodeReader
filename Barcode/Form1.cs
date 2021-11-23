using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using QRCoder;
using ZXing.QrCode;
using ZXing;

namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {

            //QRCodeGenerator qr = new QRCodeGenerator();
            //QRCodeData data = qr.CreateQrCode(barTB.Text, QRCodeGenerator.ECCLevel.Q);
            //data.SaveRawData("QRCode",QRCodeData.Compression.Uncompressed);
            //QRCode code = new QRCode(data);
            //pictureBox.Image = code.GetGraphic(5);

            var options = new QrCodeEncodingOptions
            {
                Height = pictureBox.Height,
                Width = pictureBox.Width
            };

            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var text = barTB.Text;

            if(text == "")
            {
                MessageBox.Show("Please Insert The Text!!!");
                return;
            }

            var result = writer.Write(text);
            pictureBox.Image = result;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string location = @"C:\Users\Hendri\source\repos\Barcode\QRImages";
            var dialog = new SaveFileDialog();

            dialog.InitialDirectory = location;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(dialog.FileName);
            }
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new BarcodeReader();
                var imgFile = Image.FromFile(dialog.FileName) as Bitmap;
                pictureBox.Image = imgFile;
                var result = reader.Decode(imgFile);
                decodeTB.Text = result.Text;
            }
        }
    }
}
