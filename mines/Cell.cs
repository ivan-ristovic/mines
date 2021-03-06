﻿using System.Drawing;
using System.Windows.Forms;

namespace mines
{
    class Cell
    {
        public static int CELL_SIZE = 30;
        private static Image IMG_MINE = Properties.Resources.imgMine;
        private static Image IMG_FLAG = Properties.Resources.imgFlag;

        // Cell position in MainForm (in pixels)
        private int X;
        private int Y;
        
        // Cell is made of one button (front) and a label (back)
        private Button Front;
        private Label Back;

        // Indicator if bomb is underneath the cell
        private bool BombInd;

        // Indicators
        private bool IsOpened;
        private bool IsMarked;

        
        public Cell(MainForm parent, int x, int y, int posx, int posy, bool bombInd)
        {
            X = x;
            Y = y;
            BombInd = bombInd;
            IsOpened = false;
            Front = new Button() {
                Text = "",
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(CELL_SIZE, CELL_SIZE),
                Location = new Point(X, Y),
                TabStop = false,
                Tag = new Location(posx, posy)
            };
            Front.MouseDown += parent.CellClick;
            Back = new Label() {
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Helvetica", 10),
                Size = new Size(CELL_SIZE, CELL_SIZE),
                Location = new Point(X, Y)
            };
            parent.Controls.Add(Front);
            parent.Controls.Add(Back);
        }


        // Opening cell - hiding front button
        public void Open()
        {
            // I decided to leave it hidden because maybe in future I might implement an undo option
            Front.Visible = false;
            IsOpened = true;
        }

        public void Mark()
        {
            if (IsMarked)
                Front.Image = null;
            else
                Front.Image = IMG_FLAG;
            IsMarked = !IsMarked;
        }

        public bool IsOpen()
        {
            return IsOpened;
        }

        public bool HasMark()
        {
            return IsMarked;
        }

        public bool HasBomb()
        {
            return BombInd;
        }

        public void SetBomb()
        {
            BombInd = true;
            Back.Image = IMG_MINE;
        }

        public string GetBackLabelText()
        {
            return Back.Text;
        }

        public void SetBackLabelText(string text)
        {
            Back.Text = text;
        }

        public void SetBackLabel(int bombNum)
        {
            Back.Text = bombNum.ToString();

            // Deciding which color to use, depending on the number of bombs around the cell
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

        public void Clear()
        {
            IsOpened = false;
            BombInd = false;
            Front.Visible = true;
            Front.Text = "";
            Back.Text = "";
            Front.Image = null;
            Back.Image = null;
        }

        public void Lock()
        {
            Front.Enabled = false;
        }

        public void Unlock()
        {
            Front.Enabled = true;
        }

        public void Delete()
        {
            Front.Dispose();
            Back.Dispose();
        }
    }
}
