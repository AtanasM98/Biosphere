using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biosphere
{
    enum TileState
    {
        Water = 0,
        Sand = 1,
        Grass = 2,
    }

    class Tile
    {
        public TileState state { get; private set; }
        public Rectangle rect { get; private set; }

        public Tile(int st, Point p, Size s)
        {
            rect = new Rectangle(p, s);
            state = (TileState)st;
        }

        public Color getColor()
        {
            switch (state)
            {
                case (TileState)0:
                    return Color.SandyBrown;
                case (TileState)1:
                    return Color.ForestGreen;
                case (TileState)2:
                    return Color.DeepSkyBlue;
                default:
                    return Color.Black;
            }
        }
    }
}
