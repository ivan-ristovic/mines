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
    public partial class frmOptions : Form
    {
        // Option set
        public int OPTION_FIELD_SIZE_X = 10;
        public int OPTION_FIELD_SIZE_Y = 10;
        public int MINE_NUM = 15;

        // Parent form
        private MainForm MainParent;


        public frmOptions(MainForm parent)
        {
            InitializeComponent();
            MainParent = parent;
        }


        private void rbFieldSmall_CheckedChanged(object sender, EventArgs e)
        {
            OPTION_FIELD_SIZE_X = 10;
            OPTION_FIELD_SIZE_Y = 10;
        }

        private void rbField15_CheckedChanged(object sender, EventArgs e)
        {
            OPTION_FIELD_SIZE_X = 20;
            OPTION_FIELD_SIZE_Y = 10;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OPTION_FIELD_SIZE_X = 20;
            OPTION_FIELD_SIZE_Y = 15;
        }

        private void rbMines10_CheckedChanged(object sender, EventArgs e)
        {
            MINE_NUM = 15;
        }

        private void rbMines20_CheckedChanged(object sender, EventArgs e)
        {
            MINE_NUM = 25;
        }

        private void rbMines40_CheckedChanged(object sender, EventArgs e)
        {
            MINE_NUM = 45;
        }

        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            // On close we just hide the form, not close it in order to save the settings
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
                MainParent.UpdateOptions();
            }
        }
    }
}
