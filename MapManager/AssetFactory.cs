using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public static class AssetFactory
    {
        /// <summary>
        /// Given a directory of Asset files, construct an Enuerable that represents the asset.
        /// </summary>
        /// <param name="assetDirectory">The root directory to search for assets </param>
        /// <returns> IEnumerable of <see cref="Asset"/></returns>
        public static IEnumerable<Asset> Construct(string assetDirectory)
        {
            IList<Asset> assets = new List<Asset>();
            var allAssetsPath = Directory.EnumerateFiles(assetDirectory, "*.jpg", SearchOption.AllDirectories);

            foreach(var assetPath in allAssetsPath)
            {
                assets.Add(new Asset(assetPath));
            }

            return assets;
        }
    }
}
