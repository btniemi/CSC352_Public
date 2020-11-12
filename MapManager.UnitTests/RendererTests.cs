﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MapManager.UnitTests
{
    [TestFixture]
    public class RendererTests
    {
        [TestCaseSource(typeof(RenderLayer_ValidArguments_Tests))]
        public void RendererLayers_ValidArguments(IEnumerable<Layer> layers, int width, int height)
        {
            Bitmap render = Renderer.RenderLayers(layers, width, height);
            string bitmapPath = Path.Combine(TestContext.CurrentContext.TestDirectory, $"{TestContext.CurrentContext.Test.Name}.bmp");
            render.Save(bitmapPath);
        }

        public void GenerateGrid()
        {
            Bitmap paper = new Bitmap(1001, 1001);
            using (Graphics g = Graphics.FromImage(paper))
            {
                for (int i = 0; i <= 1000; i = i + 10)
                {
                    g.DrawLine(new Pen(Color.Black), new Point(i, 0), new Point(i, 1000)); //vertical line
                    g.DrawLine(new Pen(Color.Black), new Point(0, i), new Point(1000, i)); //horizontal line
                }
            }
            string savePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Grid.bmp");
            paper.Save(savePath);
        }

        [TestCaseSource(typeof(Scale_ValidArguments_Tests))] //mimic what is above...???
        public void Scale_ValidArguments(Size original, double growPercent, Size expected)
        {
            Size actual = Renderer.Scale(original, growPercent);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    internal class RenderLayer_ValidArguments_Tests : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestCaseData
                (
                new Layer[]
                {
                    new Layer(@"C:\Users\braedon.niemi\Documents\GitHub\CSC352_Public\MapManager\Assets\JPG Maps\ascent_callouts.jpg"),
                    new Layer(@"C:\Users\braedon.niemi\Documents\GitHub\CSC352_Public\MapManager\Assets\Agents\Controllers\Omen_artwork.png")
                    {
                        Location = new System.Drawing.Point(207, 50)
                    }
                },
                1000,
                1054
                ).SetName("CenteredImage");
        }
    }

    internal class Scale_ValidArguments_Tests : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestCaseData(new Size(100, 100), 1, new Size(100, 100));
            yield return new TestCaseData(new Size(100, 100), .5, new Size(50, 50));
            yield return new TestCaseData(new Size(100, 100), .01, new Size(1, 1));
            yield return new TestCaseData(new Size(96, 50), .32, new Size(30, 16));
            yield return new TestCaseData(new Size(77, 651), .67, new Size(51, 436));
        }
    }
}
