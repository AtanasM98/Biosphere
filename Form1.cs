using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biosphere
{
    public partial class Form1 : Form
    {
        Grid grid;
        Graphics g = null;
        public Form1()
        {
            InitializeComponent();
        }

        void canvasPaint(Grid grid)
        {
            g = canvas.CreateGraphics();
            if (grid != null)
            {
                foreach (Tile tile in grid.tiles)
                {
                    g.FillRectangle(new SolidBrush(tile.getColor()), tile.rect);
                }
            }
        }
        void canvasPaintAnimal(Animal an)
        {
            g = canvas.CreateGraphics();
            if (grid != null)
            {
                g.FillEllipse(new SolidBrush(an.color), an.Rect);
            }
        }

        private void genGrid_Click(object sender, EventArgs e)
        {
            if(g != null)
            {
                g.Clear(this.BackColor);
                grid.CleanUp();
            }
            if(tbGridSize.Text != "")
            {
                int numTiles = int.Parse(tbGridSize.Text);
                float scale = 0.0335f;
                int tileSize = 20;
                if (tbFloat.Text != String.Empty)
                {
                    scale = float.Parse(tbFloat.Text);
                }
                if (tbTileSize.Text != String.Empty)
                {
                    tileSize = int.Parse(tbTileSize.Text);
                }
                grid = new Grid(tileSize, numTiles, scale);
                canvasPaint(grid);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            grid.CleanUp();
        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            canvasPaint(grid);
        }

        private void btnPutZebra_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Tile t = grid.tiles[rand.Next(0, grid.tileCount), rand.Next(0, grid.tileCount)];
            int x, y;
            x = t.rect.Location.X + (grid.tileSize / 4);
            y = t.rect.Location.Y + (grid.tileSize / 4);
            Point position = new Point(x, y);
            Rectangle rect = new Rectangle(position, new Size(grid.tileSize/2, grid.tileSize/2));
            Zebra zebra = new Zebra((float)rand.NextDouble(), (float)rand.NextDouble(), false, position, rect);
            canvasPaintAnimal(zebra);
        }
    }
}
