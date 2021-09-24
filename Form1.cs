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
            if(grid != null)
            {
                foreach (Tile tile in grid.tiles)
                {
                    g.FillRectangle(new SolidBrush(tile.getColor()), tile.rect);
                }
            }
        }

        private void genGrid_Click(object sender, EventArgs e)
        {
            if(g != null)
            {
                g.Clear(this.BackColor);
            }
            if(tbGridSize.Text != "")
            {
                int numTiles = int.Parse(tbGridSize.Text);
                float scale = 0.0335f;
                if (tbFloat.Text != String.Empty)
                {
                    scale = float.Parse(tbFloat.Text);
                }
                grid = new Grid(20, numTiles, scale);
                canvasPaint(grid);
            }
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
