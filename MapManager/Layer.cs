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
            Name = Guid.NewGuid().ToString("D");
        }
        public Layer(string filePath)
        {
            Current = new Bitmap(filePath);
            FileName = filePath;
            Location = new Point(0, 0);
            Name = Guid.NewGuid().ToString("D");
        }
        public Bitmap Current { get; set; }

        public string FileName { get; set; }

        public Point Location { get; set; }

        public string Name { get; set; }

        public Size RendererSize{ get; set; }
    }
}
