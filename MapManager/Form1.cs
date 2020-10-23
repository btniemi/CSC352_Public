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
        public Form1()
        {
            InitializeComponent();
            AssetPictureBox.AllowDrop = true;
            MapPictureBox.AllowDrop = true;
        }

        private void AssetPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Drag Drop encountered");
        }

        private void AssetPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Drag Enter encountered");
        }

        private void AssetPictureBox_DragLeave(object sender, EventArgs e)
        {
            Debug.WriteLine("Drag Leave encountered");
        }

        private void AssetPictureBox_DragOver(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Drag Over encountered");
        }

        private void AssetPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AssetPictureBox.DoDragDrop(AssetPictureBox.Image, DragDropEffects.Copy);
        }

        private void MapPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Map: Drag Enter Event Encountered");
        }

        private void MapPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("Map: Drage Drop Operation Completed");
        }
    }
}
