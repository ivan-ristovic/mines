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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.msMainMenuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuGameNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuGame,
            this.msMainMenuHelp,
            this.msMainMenuAbout});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(319, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // msMainMenuGame
            // 
            this.msMainMenuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuGameNew});
            this.msMainMenuGame.Name = "msMainMenuGame";
            this.msMainMenuGame.Size = new System.Drawing.Size(50, 20);
            this.msMainMenuGame.Text = "Game";
            // 
            // msMainMenuGameNew
            // 
            this.msMainMenuGameNew.Name = "msMainMenuGameNew";
            this.msMainMenuGameNew.Size = new System.Drawing.Size(152, 22);
            this.msMainMenuGameNew.Text = "New";
            this.msMainMenuGameNew.Click += new System.EventHandler(this.msMainMenuGameNew_Click);
            // 
            // msMainMenuHelp
            // 
            this.msMainMenuHelp.Name = "msMainMenuHelp";
            this.msMainMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.msMainMenuHelp.Text = "Help";
            // 
            // msMainMenuAbout
            // 
            this.msMainMenuAbout.Name = "msMainMenuAbout";
            this.msMainMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.msMainMenuAbout.Text = "About";
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(12, 27);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(40, 40);
            this.btnResetGame.TabIndex = 1;
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.msMainMenuGameNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 381);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.msMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mines";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGame;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameNew;
        private System.Windows.Forms.Button btnResetGame;
    }
}

