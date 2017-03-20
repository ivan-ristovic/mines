namespace mines
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnResetGame = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuGameNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainGameOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblMineCount = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(145, 27);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(40, 40);
            this.btnResetGame.TabIndex = 1;
            this.btnResetGame.TabStop = false;
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.msMainMenuGameNew_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuGame,
            this.msMenuHelp,
            this.msMenuAbout});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(319, 24);
            this.msMenu.TabIndex = 2;
            this.msMenu.Text = "menuStrip1";
            // 
            // msMenuGame
            // 
            this.msMenuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuGameNew,
            this.msMainGameOptions});
            this.msMenuGame.Name = "msMenuGame";
            this.msMenuGame.Size = new System.Drawing.Size(50, 20);
            this.msMenuGame.Text = "Game";
            // 
            // msMenuGameNew
            // 
            this.msMenuGameNew.Name = "msMenuGameNew";
            this.msMenuGameNew.Size = new System.Drawing.Size(132, 22);
            this.msMenuGameNew.Text = "New Game";
            this.msMenuGameNew.Click += new System.EventHandler(this.msMainMenuGameNew_Click);
            // 
            // msMainGameOptions
            // 
            this.msMainGameOptions.Name = "msMainGameOptions";
            this.msMainGameOptions.Size = new System.Drawing.Size(132, 22);
            this.msMainGameOptions.Text = "Options";
            this.msMainGameOptions.Click += new System.EventHandler(this.msMainGameOptions_Click);
            // 
            // msMenuHelp
            // 
            this.msMenuHelp.Name = "msMenuHelp";
            this.msMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.msMenuHelp.Text = "Help";
            this.msMenuHelp.Click += new System.EventHandler(this.msMenuHelp_Click);
            // 
            // msMenuAbout
            // 
            this.msMenuAbout.Name = "msMenuAbout";
            this.msMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.msMenuAbout.Text = "About";
            this.msMenuAbout.Click += new System.EventHandler(this.msMenuAbout_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Location = new System.Drawing.Point(12, 73);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(295, 296);
            this.pnlBackground.TabIndex = 3;
            // 
            // lblMineCount
            // 
            this.lblMineCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMineCount.ForeColor = System.Drawing.Color.Red;
            this.lblMineCount.Location = new System.Drawing.Point(12, 27);
            this.lblMineCount.Name = "lblMineCount";
            this.lblMineCount.Size = new System.Drawing.Size(62, 40);
            this.lblMineCount.TabIndex = 4;
            this.lblMineCount.Text = "0";
            this.lblMineCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 381);
            this.Controls.Add(this.lblMineCount);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.msMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mines";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuGame;
        private System.Windows.Forms.ToolStripMenuItem msMenuGameNew;
        private System.Windows.Forms.ToolStripMenuItem msMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem msMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem msMainGameOptions;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblMineCount;
    }
}

