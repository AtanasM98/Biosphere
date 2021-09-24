using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosphere
{
    class Grid
    {
        public int tileSize { get; private set; }
        public int tileCount { get; private set; }
        public List<List<Tile>> tiles { get; private set; }

        public Grid(int sz, int numTl)
        {
            tileSize = sz;
            tileCount = numTl;
            this.tiles = new List<List<Tile>>(numTl);
            for(int i = 0; i < numTl; i++)
            {
                List<Tile> tempTiles = new List<Tile>(numTl);
                for(int j = 0; j < numTl; j++)
                {
                    Random rand = new Random();
                    Point p = new Point(i * (tileSize + 3) + 5, j * (tileSize + 3) + 5);
                    Size s = new Size(tileSize, tileSize);
                    Rectangle rect = new Rectangle(p, s);
                    tempTiles.Add(new Tile(rand.Next(0, 3), rect));
                }
                this.tiles.Add(tempTiles);
            }
        }

    }
}
