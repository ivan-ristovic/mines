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
        private static int FIELD_SIZE_X = 10;
        private static int FIELD_SIZE_Y = 10;
        private static int MINE_NUM = 15;

        // Cell grid and game running indicator
        private Cell[,] Field;
        private bool GameOver = false;

        // Options form
        private frmOptions Options;

        // Mark counter
        private int MarkedMines = 0;
        private int MarkedCorrectly = 0;


        public MainForm()
        {
            InitializeComponent();
            Options = new frmOptions(this);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Creating field
            Field = new Cell[FIELD_SIZE_Y, FIELD_SIZE_X];
            CreateCellGridAt(5, 75);

            // Resizing form to fit the field
            Width = 25 + FIELD_SIZE_X * Cell.CELL_SIZE;
            Height = 120 + FIELD_SIZE_Y * Cell.CELL_SIZE;

            // Calculating middle reset button location and placing it's image
            btnResetGame.Location = new Point((Width - btnResetGame.Width) / 2, 30);

            // Resizing background panel to fit the field
            pnlBackground.Width = Width - 23;
            pnlBackground.Height = Height - 117;
            pnlBackground.SendToBack();
            pnlBackground.Location = new Point(4, 74);

            // Mine counters
            MarkedMines = 0;
            MarkedCorrectly = 0;
            lblMineCount.Text = MINE_NUM.ToString();

            // Game over indicator
            GameOver = false;

            btnResetGame.Image = IMG_NEUTRAL;
        }

        private void CreateCellGridAt(int x, int y)
        {
            // Creating Cell grid:
            // horizontal and vertical are initial positions for the grid's upper left cell
            int horizontal = x, vertical = y;
            for (int i = 0; i < FIELD_SIZE_Y; i++) {
                for (int j = 0; j < FIELD_SIZE_X; j++) {
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
            for (int i = 0; i < MINE_NUM; i++) {
                int x = r.Next(FIELD_SIZE_Y);
                int y = r.Next(FIELD_SIZE_X);
                if (Field[x, y].HasBomb()) {
                    i--;
                    continue;
                }
                Field[x, y].SetBomb();
                Field[x, y].SetBackLabelText("*");
            }
        }

        private void LockField()
        {
            for (int i = 0; i < FIELD_SIZE_Y; i++) {
                for (int j = 0; j < FIELD_SIZE_X; j++) {
                    Field[i, j].Lock();
                }
            }
        }

        private void UnlockField()
        {
            for (int i = 0; i < FIELD_SIZE_Y; i++) {
                for (int j = 0; j < FIELD_SIZE_X; j++) {
                    Field[i, j].Unlock();
                }
            }
        }

        private void UpdateFieldLabels()
        {
            for (int i = 0; i < FIELD_SIZE_Y; i++) {
                for (int j = 0; j < FIELD_SIZE_X; j++) {

                    // Skipping mine cells
                    if (Field[i, j].HasBomb())
                        continue;

                    // Counting how many bombs there are around our current cell
                    int count = 0;
                    if (i > 0 && j > 0 && Field[i - 1, j - 1].HasBomb())
                        count++;
                    if (i > 0 && Field[i - 1, j].HasBomb())
                        count++;
                    if (i > 0 && j < FIELD_SIZE_X - 1 && Field[i - 1, j + 1].HasBomb())
                        count++;
                    if (j > 0 && Field[i, j - 1].HasBomb())
                        count++;
                    if (j < FIELD_SIZE_X - 1 && Field[i, j + 1].HasBomb())
                        count++;
                    if (i < FIELD_SIZE_Y - 1 && j > 0 && Field[i + 1, j - 1].HasBomb())
                        count++;
                    if (i < FIELD_SIZE_Y - 1 && Field[i + 1, j].HasBomb())
                        count++;
                    if (i < FIELD_SIZE_Y - 1 && j < FIELD_SIZE_X - 1 && Field[i + 1, j + 1].HasBomb())
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
            if (me.Button == MouseButtons.Left) {               // Left click
                // If the cell is not marked, we open it
                if (!Field[i, j].HasMark()) {
                    btnResetGame.Image = IMG_OPEN;
                    OpenCell(i, j);
                    if (!GameOver)
                        btnResetGame.Image = IMG_NEUTRAL;
                } 
            } else {                                            // Right click
                // User cannot mark more mines than there really are
                if (MarkedMines < MINE_NUM) {

                    // Checking if field already has a mark
                    if (Field[i, j].HasMark()) {
                        // If it does, decrementing the counters since the flag will be removed
                        MarkedMines--;
                        MarkedCorrectly--;
                    } else {
                        MarkedMines++;
                        // Update correct guess counter, if user marked correctly
                        if (Field[i, j].HasBomb())
                            MarkedCorrectly++;
                    }

                    // Toggling flag
                    Field[i, j].Mark();
                }
            }

            // Updating mine label text
            lblMineCount.Text = (MINE_NUM - MarkedMines).ToString();

            // If user marked all bombs, he won the game
            if (MarkedCorrectly == MINE_NUM) {
                GameOver = true;
                btnResetGame.Image = IMG_WIN;
                LockField();
            }
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
            if (!Field[i,j].HasMark() && Field[i, j].GetBackLabelText() == "") {
                if (i > 0 && j > 0 && !Field[i - 1, j - 1].IsOpen())
                    OpenCell(i - 1, j - 1);
                if (i > 0 && !Field[i - 1, j].IsOpen())
                    OpenCell(i - 1, j);
                if (i > 0 && j < FIELD_SIZE_X - 1 && !Field[i - 1, j + 1].IsOpen())
                    OpenCell(i - 1, j + 1);
                if (j > 0 && !Field[i, j - 1].IsOpen())
                    OpenCell(i, j - 1);
                if (j < FIELD_SIZE_X - 1 && !Field[i, j + 1].IsOpen())
                    OpenCell(i, j + 1);
                if (i < FIELD_SIZE_Y - 1 && j > 0 && !Field[i + 1, j - 1].IsOpen())
                    OpenCell(i + 1, j - 1);
                if (i < FIELD_SIZE_Y - 1 && !Field[i + 1, j].IsOpen())
                    OpenCell(i + 1, j);
                if (i < FIELD_SIZE_Y - 1 && j < FIELD_SIZE_X - 1 && !Field[i + 1, j + 1].IsOpen())
                    OpenCell(i + 1, j + 1);
            }
        }

        public void UpdateOptions()
        {
            // Deleting previous field
            for (int i = 0; i < FIELD_SIZE_Y; i++) {
                for (int j = 0; j < FIELD_SIZE_X; j++) {
                    Field[i, j].Delete();
                }
            }

            FIELD_SIZE_X = Options.OPTION_FIELD_SIZE_X;
            FIELD_SIZE_Y = Options.OPTION_FIELD_SIZE_Y;
            MINE_NUM = Options.MINE_NUM;

            InitializeGame();
            
            btnResetGame.PerformClick();
        }

        private void msMainMenuGameNew_Click(object sender, EventArgs e)
        {
            // Clearing field
            for (int i = 0; i < FIELD_SIZE_Y; i++) {
                for (int j = 0; j < FIELD_SIZE_X; j++) {
                    Field[i, j].Clear();
                }
            }

            // Resetting game
            GameOver = false;
            PlaceBombs();
            UpdateFieldLabels();
            UnlockField();
            lblMineCount.Text = MINE_NUM.ToString();
            btnResetGame.Image = IMG_NEUTRAL;
        }

        private void msMainGameOptions_Click(object sender, EventArgs e)
        {
            Options.Show();
        }

        private void msMenuHelp_Click(object sender, EventArgs e)
        {

        }

        private void msMenuAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
