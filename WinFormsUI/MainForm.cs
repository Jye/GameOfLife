using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
   
    public partial class MainForm : Form
    {
        public class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
                : base()
            {
                this.DoubleBuffered = true;
            }
        }

        Timer stepTimer;
        int cellSize = 15;
        GameOfLife model;
        public MainForm()
        {
            InitializeComponent();
            model = new GameOfLife(45, 45);
            stepTimer = new Timer();
            stepTimer.Interval = 100;
            stepTimer.Tick += stepTimer_Tick;
            SetClientSizeCore(model.Columns * cellSize + menuPanel.Width, model.Rows * cellSize);
            cellsPanel.Paint += cellsPanel_Paint;
            cellsPanel.MouseClick += cellsPanel_Click;
            stepTimer.Start();
        }




        void cellsPanel_Click(object sender, MouseEventArgs e)
        {
            int x = e.X / cellSize;
            int y = e.Y / cellSize;

            model.ToggleCell(x, y);
            cellsPanel.Invalidate();

        }

        void cellsPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Blue);
            for (int x = 0; x < model.Rows; x++)
            {
                for (int y = 0; y < model.Columns; y++)
                {
                    if (model.IsCellAlive(x, y))
                    {
                        g.FillRectangle(brush, x * cellSize, y * cellSize, cellSize, cellSize);
                    }
                    else
                    {
                        g.DrawRectangle(pen, x * cellSize, y * cellSize, cellSize, cellSize);
                    }
                }
            }
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            model.Step();
            cellsPanel.Invalidate();
        }


        void stepTimer_Tick(object sender, EventArgs e)
        {
            if (autoStepCheckBox.Checked)
            {
                model.Step();
                cellsPanel.Invalidate();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            model.Clear();
            cellsPanel.Invalidate();
        }



    }
}
