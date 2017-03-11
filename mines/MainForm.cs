using System;
using System.Windows.Forms;

namespace mines
{
    public partial class MainForm : Form
    {
        private static int FIELD_SIZE = 10;
        private static int BOMB_NUM = 15;
        private Cell[,] Field = new Cell[FIELD_SIZE, FIELD_SIZE];
        private bool GameOver = false;


        public MainForm()
        {
            InitializeComponent();
            CreateCellGrid();
        }


        private void CreateCellGrid()
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
                    if (i > 0 && j > 0 && Field[i - 1, j - 1].HasBomb())
                        count++;
                    if (i > 0 && Field[i - 1, j].HasBomb())
                        count++;
                    if (i > 0 && j < FIELD_SIZE - 1 && Field[i - 1, j + 1].HasBomb())
                        count++;
                    if (j > 0 && Field[i, j - 1].HasBomb())
                        count++;
                    if (j < FIELD_SIZE - 1 && Field[i, j + 1].HasBomb())
                        count++;
                    if (i < FIELD_SIZE - 1 && j > 0 && Field[i + 1, j - 1].HasBomb())
                        count++;
                    if (i < FIELD_SIZE - 1 && Field[i + 1, j].HasBomb())
                        count++;
                    if (i < FIELD_SIZE - 1 && j < FIELD_SIZE - 1 && Field[i + 1, j + 1].HasBomb())
                        count++;

                    if (count != 0)
                        Field[i, j].SetBackLabel(count);
                }
            }
        }

        public void CellClick(object sender, EventArgs e)
        {
            if (GameOver)
                return;

            Location l = (Location)(((Button)sender).Tag);
            int i = l.GetX();
            int j = l.GetY();
            Field[i, j].Open();
            if (Field[i, j].HasBomb()) {
                MessageBox.Show("gg");
                GameOver = true;
                return;
            }
            if (Field[i, j].GetBackLabelText() == "") {
                // TODO open recursively all cells around current cell
            }
        }
    }
}
