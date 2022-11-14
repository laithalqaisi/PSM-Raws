using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DycreptMagazinePages
{
    public partial class Form1 : Form
    {
        public string SearchPath;
        public string SavePath;

        public Form1()
        {
            InitializeComponent();
        }

        //PocketShounen
        private void button1_Click(object sender, EventArgs e)
        {
            SearchPath = SearchPathTextBox.Text;
            SavePath = SavePathTextBox.Text;

            var images = Directory.EnumerateFiles($@"{SearchPath}", "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jfif") || s.EndsWith(".jpeg"));

            foreach (var image in images)
            {
                FileInfo imageFileInfo = new FileInfo(image);
                List<Bitmap> imageParts = new List<Bitmap>();
                Bitmap bitmap = new Bitmap(image);

                var gridBoxWidth = bitmap.Width / 4;
                var gridBoxHeight = bitmap.Height / 4;

                var Xoffset = 0;
                int Yoffset;

                //Read the image parts
                for (int x = 0; x < 4; x++)
                {
                    Yoffset = 0;
                    for (int y = 0; y < 4; y++)
                    {
                        Bitmap partBitmap = bitmap.Clone(new RectangleF(Xoffset, Yoffset, gridBoxWidth, gridBoxHeight), bitmap.PixelFormat);

                        imageParts.Add(partBitmap);

                        Yoffset += gridBoxHeight;
                    }

                    Xoffset += gridBoxWidth;
                }

                //Reorder and draw the image parts
                Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);

                Yoffset = 0;

                using (var graphics = Graphics.FromImage(newBitmap))
                {
                    for (int y = 0; y < 4; y++)
                    {
                        Xoffset = 0;
                        for (int x = 0; x < 4; x++)
                        {
                            graphics.DrawImage(imageParts[x + y * 4], new RectangleF(Xoffset, Yoffset, gridBoxWidth, gridBoxHeight));

                            Xoffset += gridBoxWidth;
                        }

                        Yoffset += gridBoxHeight;
                    }
                }

                //Save the bitmap to a new image
                newBitmap.Save($@"{SavePath}\{imageFileInfo.Name}.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchPath = SearchPathTextBox.Text;

            var files = Directory.EnumerateFiles($@"{SearchPath}");

            int charIndex = 65; //ASCII code, 65 = A, 66 = B,...., 90 = Z.
            int index = 0;
            
            foreach (var file in files)
            {
                File.Move(file, SearchPath + $@"\{(char)charIndex}{index}" + ".png");
                
                index++;
                if (index > 99)
                {
                    charIndex++;
                    index = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int StartingPageNumber = int.Parse(SPNumberTextBox.Text);
            int EndingPageNumber = int.Parse(EPNumberTextBox.Text);

            string DocString = $"{StartingPageNumber}-{EndingPageNumber} ({EndingPageNumber - StartingPageNumber + 1}pages)\n\n";
            
            for (int i = StartingPageNumber; i <= EndingPageNumber; i++)
            {
                DocString += $"Page {i}: \n\n";
            }
            
            Clipboard.SetText(DocString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}