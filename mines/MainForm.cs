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
        private Cell[,] Field = new Cell[FIELD_SIZE, FIELD_SIZE];

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int horizontal = 10, vertical = 10;
            for (int i = 0; i < FIELD_SIZE; i++) {
                for (int j = 0; j < FIELD_SIZE; j++) {
                    Field[i, j] = new Cell(this, horizontal, vertical, "", false);
                    horizontal += Cell.CELL_SIZE;
                }
                horizontal = 10;
                vertical += Cell.CELL_SIZE;
            }
        }
    }
}
