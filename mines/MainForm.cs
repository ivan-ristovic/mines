using System;
using System.Drawing;
using System.Windows.Forms;

namespace mines
{
    public partial class MainForm : Form
    {
        // Images that we are using
        private static Image IMG_NEUTRAL = Properties.Resources.imgNeutral;
        private static Image IMG_OPEN = Properties.Resources.imgOpen;
        private static Image IMG_WIN = Properties.Resources.imgWin;
        private static Image IMG_LOSE = Properties.Resources.imgLose;

        // Game properties
        private static int FIELD_SIZE = 10;
        private static int BOMB_NUM = 15;

        // Cell grid and game running indicator
        private Cell[,] Field = new Cell[FIELD_SIZE, FIELD_SIZE];
        private bool GameOver = false;


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateCellGridAt(5, 75);

            // Resizing form to fit the field
            Width = 25 + FIELD_SIZE * Cell.CELL_SIZE;
            Height = 120 + FIELD_SIZE * Cell.CELL_SIZE;

            // Calculating middle reset button location and placing it's image
            btnResetGame.Location = new Point((Width - btnResetGame.Width) / 2, 30);
            btnResetGame.Image = IMG_NEUTRAL;
        }

        private void CreateCellGridAt(int x, int y)
        {
            // Creating Cell grid:
            // horizontal and vertical are initial positions for the grid's upper left cell
            int horizontal = x, vertical = y;
            for (int i = 0; i < FIELD_SIZE; i++) {
                for (int j = 0; j < FIELD_SIZE; j++) {
                    // Creating cell
                    Field[i, j] = new Cell(this, horizontal, vertical, i, j, false);
                    // Moving to next cell in a row
                    horizontal += Cell.CELL_SIZE;
                }
                // Moving to next row
                horizontal = x;
                vertical += Cell.CELL_SIZE;
            }

            // Initializing field
            PlaceBombs();
            UpdateFieldLabels();
        }

        private void PlaceBombs()
        {
            // Randomly place bombs on the board
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

                    // Skipping mine cells
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

        public void CellClick(object sender, MouseEventArgs me)
        {
            // Extracting location of the clicked cell
            Location l = (Location)(((Button)sender).Tag);
            int i = l.GetX();
            int j = l.GetY();

            // Determinating left/right click
            if (me.Button == MouseButtons.Left && !Field[i, j].HasMark()) {
                btnResetGame.Image = IMG_OPEN;
                OpenCell(i, j);
                if (!GameOver)
                    btnResetGame.Image = IMG_NEUTRAL;
            } else
                Field[i, j].Mark();
        }

        private void OpenCell(int i, int j)
        {
            if (GameOver)
                return;

            if (!Field[i, j].HasMark())
                Field[i, j].Open();

            if (Field[i, j].HasBomb()) {
                btnResetGame.Image = IMG_LOSE;
                LockField();
                GameOver = true;
                return;
            }

            // If the field is blank, then recursively open all neighbour cells which aren't marked
            if (Field[i, j].GetBackLabelText() == "") {
                if (i > 0 && j > 0 && !Field[i - 1, j - 1].IsOpen())
                    OpenCell(i - 1, j - 1);
                if (i > 0 && !Field[i - 1, j].IsOpen())
                    OpenCell(i - 1, j);
                if (i > 0 && j < FIELD_SIZE - 1 && !Field[i - 1, j + 1].IsOpen())
                    OpenCell(i - 1, j + 1);
                if (j > 0 && !Field[i, j - 1].IsOpen())
                    OpenCell(i, j - 1);
                if (j < FIELD_SIZE - 1 && !Field[i, j + 1].IsOpen())
                    OpenCell(i, j + 1);
                if (i < FIELD_SIZE - 1 && j > 0 && !Field[i + 1, j - 1].IsOpen())
                    OpenCell(i + 1, j - 1);
                if (i < FIELD_SIZE - 1 && !Field[i + 1, j].IsOpen())
                    OpenCell(i + 1, j);
                if (i < FIELD_SIZE - 1 && j < FIELD_SIZE - 1 && !Field[i + 1, j + 1].IsOpen())
                    OpenCell(i + 1, j + 1);
            }
        }

        private void msMainMenuGameNew_Click(object sender, EventArgs e)
        {
            // Clearing field
            for (int i = 0; i < FIELD_SIZE; i++) {
                for (int j = 0; j < FIELD_SIZE; j++) {
                    Field[i, j].Clear();
                }
            }

            // Resetting game
            GameOver = false;
            PlaceBombs();
            UpdateFieldLabels();
            UnlockField();
            btnResetGame.Image = IMG_NEUTRAL;
        }

        private void LockField()
        {
            for (int i = 0; i < FIELD_SIZE; i++) {
                for (int j = 0; j < FIELD_SIZE; j++) {
                    Field[i, j].Lock();
                }
            }
        }

        private void UnlockField()
        {
            for (int i = 0; i < FIELD_SIZE; i++) {
                for (int j = 0; j < FIELD_SIZE; j++) {
                    Field[i, j].Unlock();
                }
            }
        }
    }
}
