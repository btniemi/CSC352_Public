using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public class Renderer
    {
        public static Bitmap RenderLayers(IEnumerable<Layer> layers, int width, int height)
        {
            Bitmap render = new Bitmap(width, height);

            foreach (var layer in layers)
            {
                using (Graphics combiner = Graphics.FromImage(render))
                {
                    combiner.DrawImage(layer.Current, layer.Location);
                }
            }

            return render;
        }
    }
}
