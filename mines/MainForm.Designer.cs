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
            this.msMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.msMenuGameNew});
            this.msMenuGame.Name = "msMenuGame";
            this.msMenuGame.Size = new System.Drawing.Size(50, 20);
            this.msMenuGame.Text = "Game";
            // 
            // msMenuGameNew
            // 
            this.msMenuGameNew.Name = "msMenuGameNew";
            this.msMenuGameNew.Size = new System.Drawing.Size(152, 22);
            this.msMenuGameNew.Text = "New";
            this.msMenuGameNew.Click += new System.EventHandler(this.msMainMenuGameNew_Click);
            // 
            // msMenuHelp
            // 
            this.msMenuHelp.Name = "msMenuHelp";
            this.msMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.msMenuHelp.Text = "Help";
            // 
            // msMenuAbout
            // 
            this.msMenuAbout.Name = "msMenuAbout";
            this.msMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.msMenuAbout.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 381);
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
    }
}

