using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biosphere
{
    class Grid
    {
        public int tileSize { get; private set; }
        public int tileCount { get; private set; }
        public Tile[,] tiles { get; private set; }

        public List<Animal> animals { get; private set; }

        public Grid(int sz, int numTl, float scale)
        {
            animals = new List<Animal>();
            tileSize = sz;
            tileCount = numTl;
            tiles = new Tile[numTl, numTl];
            Random rand = new Random();
            SimplexNoise.Noise.Seed = rand.Next();
            float[,] noiseValues = SimplexNoise.Noise.Calc2D(numTl, numTl, scale);

            for (int i = 0; i < numTl; i++)
            {
                for(int j = 0; j < numTl; j++)
                {
                    Point p = new Point(i * (tileSize + 1) + 5, j * (tileSize + 1) + 5);
                    Size s = new Size(tileSize, tileSize);
                    int tileVal = 0;
                    if (noiseValues[i, j] < 40)
                    {
                        tileVal = 0;
                    }
                    else if (noiseValues[i, j] < 155)
                    {
                        tileVal = 1;
                    }
                    else
                    {
                        tileVal = 2;
                    }
                    tiles[i, j] = new Tile(tileVal, p, s);
                }
            }
        }

        public void CleanUp()
        {
            tiles = new Tile[0,0];
            animals.Clear();
        }

        public void AddAnimal(Animal an)
        {
            animals.Add(an);
        }
    }
}
