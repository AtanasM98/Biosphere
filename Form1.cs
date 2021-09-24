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
            foreach (List<Tile> row in grid.tiles)
            {
                foreach (Tile tile in row)
                {
                    tile.Draw(g);
                }
            }
        }

        private void genGrid_Click(object sender, EventArgs e)
        {
            if(g != null)
            {
                g.Clear(this.BackColor);
            }
            int numTiles = int.Parse(tbGridSize.Text);
            grid = new Grid(25, numTiles);
            canvasPaint(grid);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            canvasPaint(grid);
        }
    }
}
