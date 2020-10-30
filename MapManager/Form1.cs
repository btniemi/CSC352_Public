using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapManager
{
    public partial class Form1 : Form
    {
        Bitmap renderedMap = null;
        Bitmap overlayImage = null;
        Bitmap combinedImage = null;
        Point overlayLocation = new Point();
        Decimal scaleX;
        Decimal scaleY;

        List<Layer> layers = new List<Layer>();

        public Form1()
        {
            InitializeComponent();
            layers.Add(new Layer() { FileName = "", Current = new Bitmap(mapPictureBox.Image), Location = new Point(0, 0) });
            renderedMap = RenderLayers(layers);
            mapPictureBox_Resize(this, new EventArgs());
        }

        private Bitmap RenderLayers(IEnumerable<Layer> layers)
        {
            return layers.First().Current;

            //Bitmap render = new Bitmap();
            
            //foreach(var layer in layers)
            //{
            //    //walk through each layer and the logic in combined image should happen here
            //    //and return us the complete rendered image
            //    //each new layer needs to also run this logic after you set the new layer down...
            //}
        }

        private void assetPictureBox_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(assetPictureBox.Image);
            mapPictureBox.Cursor = Cursors.Cross;
        }

        private void ShowCombinedImage()
        {
            if(renderedMap == null && overlayImage == null)
            {
                return;
            }

            mapPictureBox.Image = renderedMap;

            if(combinedImage != null)
            {
                combinedImage.Dispose();
                combinedImage = null;
            }

            combinedImage = new Bitmap(renderedMap);

            using(Graphics combiner = Graphics.FromImage(combinedImage))
            {
                combiner.DrawImage(overlayImage, overlayLocation);
            }

            mapPictureBox.Image = combinedImage;
        }

        private void mapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(overlayImage == null)
            {
                return;
            }

            overlayLocation = new Point(
                (int)(e.X * scaleX) - overlayImage.Width / 2,
                (int)(e.Y * scaleY) - overlayImage.Height / 2);
            ShowCombinedImage();
        }

        private void mapPictureBox_Resize(object sender, EventArgs e)
        {
            scaleX = Decimal.Divide(renderedMap.Width, mapPictureBox.Width);
            scaleY = Decimal.Divide(renderedMap.Height, mapPictureBox.Height);
        }
    }
}
