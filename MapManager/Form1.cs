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
        bool isModifyingLayer = false;
        int editingLayerIndex = -1;

        BindingList<Layer> layers = new BindingList<Layer>();

        public Form1()
        {
            InitializeComponent();
            layers.Add(new Layer() { Name ="Base", FileName = null, Current = new Bitmap(mapPictureBox.Image), Location = new Point(0, 0) });
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

            // bind the combo box to out assets binging source
            BindingSource assestBindingSource = new BindingSource();
            assestBindingSource.DataSource = AssetFactory.Construct(@"C:\Users\braedon.niemi\Documents\GitHub\CSC352_Public\MapManager\Assets");
            assetComboBox.DataSource = assestBindingSource.DataSource;
            assetComboBox.DisplayMember = "Name";
            assetComboBox.ValueMember = "FilePath";
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (isEditingImage)
            {
                if (originalOverlayImage == null)
                {
                    originalOverlayImage = new Bitmap(overlayImage);
                }

                debugStatus.Text = $"Edit Mode: ON Size: {e.Delta} Scale: {overlayScale}";

                int increaseScaleBy = 1;

                if (Control.ModifierKeys == Keys.Shift)
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
                    if (overlayScale - increaseScaleBy > 1)
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
            if (renderedMap == null && overlayImage == null)
            {
                return;
            }

            mapPictureBox.Image = renderedMap;

            if (combinedImage != null)
            {
                combinedImage.Dispose();
                combinedImage = null;
            }

            combinedImage = new Bitmap(renderedMap);

            using (Graphics combiner = Graphics.FromImage(combinedImage))
            {
                combiner.DrawImage(overlayImage, overlayLocation);
            }

            mapPictureBox.Image = combinedImage;
        }

        private void mapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }

            overlayLocation = new Point(
                (int)(e.X * scaleX) - overlayImage.Width / 2,
                (int)(e.Y * scaleY) - overlayImage.Height / 2);

            if (isModifyingLayer)
            {
                layers[editingLayerIndex].Location = overlayLocation;
                layers[editingLayerIndex].Current.Dispose();
                layers[editingLayerIndex].Current = new Bitmap(overlayImage);
                layers[editingLayerIndex].ShouldRender = true;
                Image previousImage = mapPictureBox.Image;
                mapPictureBox.Image = RenderLayers();
                previousImage.Dispose();
                previousImage = null;
                GC.Collect();
                layers[editingLayerIndex].ShouldRender = false;
            }
            else
            {
                ShowCombinedImage();
            }

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
            if (overlayImage == null)
            {
                return;
            }

            if (isModifyingLayer)
            {
                layers[editingLayerIndex].ShouldRender = true;
                editingLayerIndex = -1;
                isModifyingLayer = false;
            }
            else
            {
                layers.Add(new Layer() { Current = new Bitmap(overlayImage), FileName = string.Empty, Location = overlayLocation });
            }

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

        private void editLayerBtn_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(layerSelectionComboBox.SelectedValue as Bitmap);
            editingLayerIndex = layerSelectionComboBox.SelectedIndex;
            layers[editingLayerIndex].ShouldRender = false;
            renderedMap = RenderLayers();
            mapPictureBox.Cursor = Cursors.Cross;
            isEditingImage = true;
            isModifyingLayer = true;
        }

        private void assetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // we know where the asset file is
            string assetFilePath;

            if(assetComboBox.SelectedValue is string)
            {
                assetFilePath = assetComboBox.SelectedValue as string;
            }
            else if (assetComboBox.SelectedValue is Asset)
            {
                assetFilePath = (assetComboBox.SelectedValue as Asset).FilePath;
            }
            else
            {
                throw new InvalidOperationException();
            }

            // load the asset file as a bit map
            Bitmap assetPicture = new Bitmap(assetFilePath);
            assetPictureBox.Image = assetPicture;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Bitmap (*.bmp)|*.bmp";
                DialogResult result = sfd.ShowDialog();
                if(result == DialogResult.OK)
                {
                    mapPictureBox.Image.Save(sfd.FileName);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp";
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mapPictureBox.Image = new Bitmap(ofd.FileName);
                    layerSelectionComboBox.DataSource = null;
                    layers.Clear();
                    layers.Add(new Layer() { Name = "Base", FileName = ofd.FileName, Current = new Bitmap(mapPictureBox.Image), Location = new Point(0, 0) });
                    layerSelectionComboBox.DataSource = layers;
                    layerSelectionComboBox.DisplayMember = "Name";
                    layerSelectionComboBox.ValueMember = "Current";
                    renderedMap.Dispose();
                    renderedMap = RenderLayers();
                    layerSelectionComboBox_SelectedValueChanged(this, new EventArgs());
                }
            }
        }
    }
}
