using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosphere
{
    enum TileState
    {
        Barren = 0,
        Grass = 1,
        Water = 2
    }

    class Tile
    {
        public TileState state { get; private set; }
        Color c;
        Rectangle rect;
        Brush b;

        public Tile(int st, Rectangle rect)
        {
            state = (TileState)st;
            this.rect = rect;
            c = Color.Black;
            switch (state)
            {
                case (TileState)0:
                    c = Color.SandyBrown;
                    break;
                case (TileState)1:
                    c = Color.ForestGreen;
                    break;
                case (TileState)2:
                    c = Color.DeepSkyBlue;
                    break;
                default:
                    break;
            }
            b = new SolidBrush(c);
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(b, rect);
        }
    }
}
