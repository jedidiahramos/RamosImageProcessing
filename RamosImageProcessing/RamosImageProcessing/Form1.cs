using System;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;
using static WebCamLib.Device;
using static WebCamLib.DeviceManager;
using WebCamLib;
using System.Windows.Forms;

namespace RamosImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap imageB, imageA, colorgreen;
        String mode;
        public Form1()
        {
            InitializeComponent();
            mode = "neutral";
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            mode = "neutral";
            timer1.Stop();
            timer1.Enabled = false;
            d.Stop();
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog1.FileName);
            boxB.Image = imageB;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            mode = "copy";
            copy();
        }

        private void copy()
        {
            // BASIC COPY
            colorgreen = new Bitmap(imageB.Width, imageB.Height);
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    colorgreen.SetPixel(x, y, pixel);
                }
            }
            boxGreen.Image = colorgreen;
        }

        private void greyBtn_Click(object sender, EventArgs e)
        {
            mode = "grey";
            grey();
        }

        private void grey()
        {
            // GREYSCALE
            colorgreen = new Bitmap(imageB.Width, imageB.Height);
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    colorgreen.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }
            boxGreen.Image = colorgreen;
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            mode = "invert";
            invert();
        }

        private void invert()
        {
            // COLOR INVERSION
            colorgreen = new Bitmap(imageB.Width, imageB.Height);
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    colorgreen.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            boxGreen.Image = colorgreen;
        }

        private void histogramBtn_Click(object sender, EventArgs e)
        {
            mode = "histogram";
            histogram();
        }

        private void histogram()
        {
            // HISTOGRAM
            colorgreen = new Bitmap(imageB.Width, imageB.Height);
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    colorgreen.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }
            Color sample;
            int[] histData = new int[256];
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    sample = colorgreen.GetPixel(x, y);
                    histData[sample.R]++;
                }
            }
            Bitmap graph = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    graph.SetPixel(x, y, Color.White);
                }
            }
            // PLOT HISTOGRAM DATA
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histData[x] / 5, 800); y++)
                {
                    graph.SetPixel(x, 799 - y, Color.Black);
                }
            }
            colorgreen = graph;
            boxGreen.Image = colorgreen;
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            colorgreen.Save(saveFileDialog1.FileName);
        }

        private void sepiaBtn_Click(object sender, EventArgs e)
        {
            mode = "sepia";
            sepia();
        }
        private void sepia()
        {
            // SEPIA
            colorgreen = new Bitmap(imageB.Width, imageB.Height);
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    int r = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int g = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int b = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);
                    r = Math.Min(r, 255);
                    g = Math.Min(g, 255);
                    b = Math.Min(b, 255);
                    colorgreen.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            boxGreen.Image = colorgreen;
        }

        private void backgroundBtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog2.FileName);
            boxA.Image = imageA;
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            mode = "subtract";
            subtract();
        }

        private void subtract()
        {
            //SUBTRACT
            colorgreen = new Bitmap(imageB.Width, imageB.Height);

            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue > threshold)
                    {
                        colorgreen.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        colorgreen.SetPixel(x, y, backpixel);
                    }
                }
            }
            boxGreen.Image = colorgreen;
        }

        Device d = DeviceManager.GetAllDevices()[0];
        private void webcamBtn_Click(object sender, EventArgs e)
        {
            d.ShowWindow(boxB);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            //Device d = DeviceManager.GetDevice(listBox1.SelectedIndex);
            d.Sendmessage();
            d.ShowWindow(boxB);
            data = Clipboard.GetDataObject();
            if (data != null)
            {
                bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
                if (bmap != null)
                {
                    Bitmap b = new Bitmap(bmap);
                    boxB.Image = b;
                    imageB = b;
                    switch(mode)
                    {
                        case "copy":
                            copy();
                            break;
                        case "grey":
                            grey();
                            break;
                        case "invert":
                            invert();
                            break;
                        case "histogram":
                            histogram();
                            break;
                        case "sepia":
                            sepia();
                            break;
                    }
                }
            }
        }
    }
}