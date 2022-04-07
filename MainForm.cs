using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class MainForm : Form
    {
        private int barCount;
        private int gridScale;
        private int offset;
        Graphics graphics;
        Bitmap map;
        Pen gridPen, axisPen;


        public MainForm()
        {
            InitializeComponent();
            map = new Bitmap(Field.Width, Field.Height);
            Field.Image = map;
            gridPen = new Pen(Color.LightGray, 2f);
            axisPen = new Pen(Color.Red, 4f);
            barCount = 5;
            offset = 0;
            gridScale = Convert.ToInt32(Field.Width / (barCount * 2));
            DrawGrid();
            DrawAxis(offset);
        }

        private void Reset()
        {

        }

        private void DrawGrid()
        {
            graphics = Graphics.FromImage(Field.Image);
            graphics.Clear(Color.White);
            for(int i = 1; i < barCount * 2; i++)
            {
                graphics.DrawLine(gridPen, new Point(0, i * gridScale), new Point(map.Width, i * gridScale));
                graphics.DrawLine(gridPen, new Point(i * gridScale, 0), new Point(i * gridScale, map.Height));
            }
            Field.Invalidate();
        }

        private void DrawAxis(int offset)
        {
            graphics = Graphics.FromImage(Field.Image);
            graphics.DrawLine(axisPen, new Point(0, map.Height / 2), new Point(map.Width, map.Height / 2)); // X
            graphics.DrawLine(axisPen, new Point(map.Width / 2 + offset * gridScale , 0), new Point(map.Width / 2 + offset * gridScale, map.Height)); // Y
            Field.Invalidate();
        }

        private void ScaleMinus_Click(object sender, EventArgs e)
        {
            if (barCount == 10) return;
            barCount++;
            gridScale = Convert.ToInt32(Field.Width / (barCount * 2));
            DrawGrid();
            DrawAxis(offset);
        }

        private void ShiftRight_Click(object sender, EventArgs e)
        {
            offset--;
            DrawGrid();
            DrawAxis(offset);
        }

        private void ShiftLeft_Click(object sender, EventArgs e)
        {
            offset++;
            DrawGrid();
            DrawAxis(offset);
        }

        private void ScalePlus_Click(object sender, EventArgs e)
        {
            if(barCount == 1) return;
            barCount--;
            gridScale = Convert.ToInt32(Field.Width / (barCount * 2));
            DrawGrid();
            DrawAxis(offset);
        }
    }
}
