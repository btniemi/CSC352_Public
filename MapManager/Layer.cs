using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public class Layer
    {
        public Layer()
        {

        }
        public Layer(string filePath)
        {
            Current = new Bitmap(filePath);
            FileName = filePath;
            Location = new Point(0, 0);
        }
        public Bitmap Current { get; set; }

        public string FileName { get; set; }

        public Point Location { get; set; }
    }
}
