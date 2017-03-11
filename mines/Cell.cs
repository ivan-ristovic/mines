using System;
using System.Drawing;
using System.Windows.Forms;

namespace mines
{
    class Cell
    {
        public static int CELL_SIZE = 30;

        private int X;
        private int Y;
        private Button Front;
        private Label Back;
        private bool BombInd;

        public Cell(MainForm parent, int x, int y, int posx, int posy, bool bombInd)
        {
            X = x;
            Y = y;
            BombInd = bombInd;
            Front = new Button() {
                Text = "",
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(CELL_SIZE, CELL_SIZE),
                Location = new Point(X, Y),
                TabStop = false,
                Tag = new Location(posx, posy)
            };
            Front.Click += parent.CellClick;
            Back = new Label() {
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(CELL_SIZE, CELL_SIZE),
                Location = new Point(X, Y)
            };
            parent.Controls.Add(Front);
            parent.Controls.Add(Back);
        }

        public void Open()
        {
            Front.Visible = false;
        }

        public bool HasBomb()
        {
            return BombInd;
        }

        public void SetBomb()
        {
            BombInd = true;
        }

        public void SetBackLabelText(string text)
        {
            Back.Text = text;
        }

        public void SetBackLabel(int bombNum)
        {
            Back.Text = bombNum.ToString();
            switch (bombNum) {
                case 1:
                    Back.ForeColor = Color.Blue;
                    break;
                case 2:
                    Back.ForeColor = Color.Green;
                    break;
                case 3:
                    Back.ForeColor = Color.Red;
                    break;
                case 4:
                    Back.ForeColor = Color.Purple;
                    break;
                case 5:
                    Back.ForeColor = Color.Brown;
                    break;
                case 6:
                    Back.ForeColor = Color.Teal;
                    break;
                case 7:
                    Back.ForeColor = Color.Black;
                    break;
                case 8:
                    Back.ForeColor = Color.Gray;
                    break;
                default:
                    break;
            } // end switch
        }
    }
}
