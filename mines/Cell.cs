using System.Drawing;
using System.Windows.Forms;

namespace mines
{
    class Cell
    {
        public static int CELL_SIZE = 20;

        private int X;
        private int Y;
        private Button Front;
        private Label Back;
        private bool BombInd;
        private bool Opened;

        public Cell(Form parent, int x, int y, string bgText, bool bombInd)
        {
            X = x;
            Y = y;
            BombInd = bombInd;
            Opened = false;
            Front = new Button() {
                Text = "",
                Size = new Size(CELL_SIZE, CELL_SIZE),
                Location = new Point(X, Y),
            };
            Back = new Label() {
                Text = bgText,
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
    }
}
