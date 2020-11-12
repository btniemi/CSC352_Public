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
        bool isEditingImage = false;
        static int overlayScale = 100;
        Bitmap originalOverlayImage = null;

        BindingList<Layer> layers = new BindingList<Layer>();

        public Form1()
        {
            InitializeComponent();
            layers.Add(new Layer() { FileName = "", Current = new Bitmap(mapPictureBox.Image), Location = new Point(0, 0) });
            renderedMap = RenderLayers();
            mapPictureBox.Image = renderedMap;
            mapPictureBox_Resize(this, new EventArgs());

            // bind the combo box to our layers
            BindingSource layersBindingSource = new BindingSource();
            layersBindingSource.DataSource = layers;
            layerSelectionComboBox.DataSource = layersBindingSource.DataSource;
            layerSelectionComboBox.DisplayMember = "Name";
            layerSelectionComboBox.ValueMember = "Current";

            // bind the mouse wheel events
            MouseWheel += Form1_MouseWheel;
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (isEditingImage)
            {
                if(originalOverlayImage == null)
                {
                    originalOverlayImage = new Bitmap(overlayImage);
                }

                debugStatus.Text = $"Edit Mode: ON Size: {e.Delta} Scale: {overlayScale}";

                int increaseScaleBy = 1;

                if(Control.ModifierKeys == Keys.Shift)
                {
                    increaseScaleBy = 10;
                }

                if (e.Delta > 1)
                {
                    // If Positive Grow Image
                    overlayScale = overlayScale + increaseScaleBy;
                }
                else
                {
                    // Negitive Shrink
                    if(overlayScale - increaseScaleBy > 1)
                    {
                        overlayScale = overlayScale - increaseScaleBy;
                    }
                    
                }

                double scale = overlayScale * .01;

                Size scaledSize = Renderer.Scale(originalOverlayImage.Size, scale);
                scaledImageLabel.Text = scaledSize.ToString();

                Bitmap scaledBitmap = new Bitmap(originalOverlayImage, scaledSize);

                overlayImage.Dispose();
                overlayImage = null;
                overlayImage = scaledBitmap;

            }
            else
            {
                debugStatus.Text = $"Edit Mode: OFF Size: {e.Delta}";
            }
        }

        private Bitmap RenderLayers()
        {
            return Renderer.RenderLayers(layers, mapPictureBox.Image.Width, mapPictureBox.Image.Height);
        }

        private void assetPictureBox_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(assetPictureBox.Image);
            mapPictureBox.Cursor = Cursors.Cross;
            isEditingImage = true;
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

            var mousePosition = new Point(e.X, e.Y);
            mousePosActual.Text = $"Mouse Postion Actual - X: {e.X}, Y:{e.Y}";
            mousePosScaled.Text = $"Mouse Postion Scaled - X: {overlayLocation.X}, Y:{overlayLocation.Y}";
        }

        private void mapPictureBox_Resize(object sender, EventArgs e)
        {
            scaleX = Decimal.Divide(renderedMap.Width, mapPictureBox.Width);
            scaleY = Decimal.Divide(renderedMap.Height, mapPictureBox.Height);
        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {
            if(overlayImage == null)
            {
                return;
            }

            layers.Add(new Layer() { Current = new Bitmap(overlayImage), FileName = string.Empty, Location = overlayLocation });
            mapPictureBox.Cursor = Cursors.Default;
            
            overlayImage.Dispose();
            overlayImage = null;

            renderedMap = RenderLayers();
            mapPictureBox.Image = renderedMap;
            overlayScale = 100;

            originalOverlayImage?.Dispose();
            originalOverlayImage = null;

            isEditingImage = false;


        }

        private void layerSelectionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (layerSelectionComboBox.SelectedValue is Bitmap)
            {
                layerPictureBox.Image = layerSelectionComboBox.SelectedValue as Bitmap;
            }
            else if (layerSelectionComboBox.SelectedValue is Layer)
            {
                layerPictureBox.Image = (layerSelectionComboBox.SelectedValue as Layer).Current;
            }
            else
            {
                // Do Nothing
            }
        }

        private void scaledImageLabel_Click(object sender, EventArgs e)
        {

        }

        private void debugStatus_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
