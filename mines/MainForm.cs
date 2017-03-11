using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mines
{
    public partial class MainForm : Form
    {
        private static int FIELD_SIZE = 10;
        private static int BOMB_NUM = 15;
        private Cell[,] Field = new Cell[FIELD_SIZE, FIELD_SIZE];

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            // Creating Cell grid:
            // horizontal and vertical are initial positions for the grid's upper left cell
            int horizontal = 10, vertical = 10;
            for (int i = 0; i < FIELD_SIZE; i++) {
                for (int j = 0; j < FIELD_SIZE; j++) {
                    // Creating cell
                    Field[i, j] = new Cell(this, horizontal, vertical, i, j, false);
                    // Moving to next cell in a row
                    horizontal += Cell.CELL_SIZE;
                }
                // Moving to next row
                horizontal = 10;
                vertical += Cell.CELL_SIZE;
            }

            // Initializing field
            PlaceBombs();
            UpdateFieldLabels();
        }

        private void PlaceBombs()
        {
            Random r = new Random();
            for (int i = 0; i < BOMB_NUM; i++) {
                int x = r.Next(FIELD_SIZE);
                int y = r.Next(FIELD_SIZE);
                Field[x, y].SetBomb();
                Field[x, y].SetBackLabelText("*");
            }
        }

        private void UpdateFieldLabels()
        {
            for (int i = 0; i < FIELD_SIZE; i++) {
                for (int j = 0; j < FIELD_SIZE; j++) {
                    if (Field[i, j].HasBomb())
                        continue;

                    // Counting how many bombs there are around our current cell
                    int count = 0;
                    Field[i, j].SetBackLabel(count);
                }
            }
        }

        public void CellClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Location l = (Location)(b.Tag);
            if (Field[l.GetX(), l.GetY()].HasBomb())
                MessageBox.Show("gg");
            Field[l.GetX(), l.GetY()].Open();
        }
    }
}
