namespace mines
{
    partial class frmOptions
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.rbFieldSmall = new System.Windows.Forms.RadioButton();
            this.gbField = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbField15 = new System.Windows.Forms.RadioButton();
            this.gbMines = new System.Windows.Forms.GroupBox();
            this.rbMines3 = new System.Windows.Forms.RadioButton();
            this.rbMines2 = new System.Windows.Forms.RadioButton();
            this.rbMines1 = new System.Windows.Forms.RadioButton();
            this.gbField.SuspendLayout();
            this.gbMines.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbFieldSmall
            // 
            this.rbFieldSmall.AutoSize = true;
            this.rbFieldSmall.Checked = true;
            this.rbFieldSmall.Location = new System.Drawing.Point(6, 19);
            this.rbFieldSmall.Name = "rbFieldSmall";
            this.rbFieldSmall.Size = new System.Drawing.Size(50, 17);
            this.rbFieldSmall.TabIndex = 0;
            this.rbFieldSmall.TabStop = true;
            this.rbFieldSmall.Text = "Small";
            this.rbFieldSmall.UseVisualStyleBackColor = true;
            this.rbFieldSmall.CheckedChanged += new System.EventHandler(this.rbFieldSmall_CheckedChanged);
            // 
            // gbField
            // 
            this.gbField.Controls.Add(this.radioButton1);
            this.gbField.Controls.Add(this.rbField15);
            this.gbField.Controls.Add(this.rbFieldSmall);
            this.gbField.Location = new System.Drawing.Point(12, 11);
            this.gbField.Name = "gbField";
            this.gbField.Size = new System.Drawing.Size(89, 100);
            this.gbField.TabIndex = 1;
            this.gbField.TabStop = false;
            this.gbField.Text = "Field size:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Large";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbField15
            // 
            this.rbField15.AutoSize = true;
            this.rbField15.Location = new System.Drawing.Point(6, 42);
            this.rbField15.Name = "rbField15";
            this.rbField15.Size = new System.Drawing.Size(62, 17);
            this.rbField15.TabIndex = 2;
            this.rbField15.Text = "Medium";
            this.rbField15.UseVisualStyleBackColor = true;
            this.rbField15.CheckedChanged += new System.EventHandler(this.rbField15_CheckedChanged);
            // 
            // gbMines
            // 
            this.gbMines.Controls.Add(this.rbMines3);
            this.gbMines.Controls.Add(this.rbMines2);
            this.gbMines.Controls.Add(this.rbMines1);
            this.gbMines.Location = new System.Drawing.Point(107, 12);
            this.gbMines.Name = "gbMines";
            this.gbMines.Size = new System.Drawing.Size(89, 99);
            this.gbMines.TabIndex = 4;
            this.gbMines.TabStop = false;
            this.gbMines.Text = "Mine count:";
            // 
            // rbMines3
            // 
            this.rbMines3.AutoSize = true;
            this.rbMines3.Location = new System.Drawing.Point(6, 65);
            this.rbMines3.Name = "rbMines3";
            this.rbMines3.Size = new System.Drawing.Size(37, 17);
            this.rbMines3.TabIndex = 3;
            this.rbMines3.Text = "45";
            this.rbMines3.UseVisualStyleBackColor = true;
            this.rbMines3.CheckedChanged += new System.EventHandler(this.rbMines40_CheckedChanged);
            // 
            // rbMines2
            // 
            this.rbMines2.AutoSize = true;
            this.rbMines2.Location = new System.Drawing.Point(6, 42);
            this.rbMines2.Name = "rbMines2";
            this.rbMines2.Size = new System.Drawing.Size(37, 17);
            this.rbMines2.TabIndex = 2;
            this.rbMines2.Text = "25";
            this.rbMines2.UseVisualStyleBackColor = true;
            this.rbMines2.CheckedChanged += new System.EventHandler(this.rbMines20_CheckedChanged);
            // 
            // rbMines1
            // 
            this.rbMines1.AutoSize = true;
            this.rbMines1.Checked = true;
            this.rbMines1.Location = new System.Drawing.Point(6, 19);
            this.rbMines1.Name = "rbMines1";
            this.rbMines1.Size = new System.Drawing.Size(37, 17);
            this.rbMines1.TabIndex = 0;
            this.rbMines1.TabStop = true;
            this.rbMines1.Text = "15";
            this.rbMines1.UseVisualStyleBackColor = true;
            this.rbMines1.CheckedChanged += new System.EventHandler(this.rbMines10_CheckedChanged);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 123);
            this.Controls.Add(this.gbMines);
            this.Controls.Add(this.gbField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptions_FormClosing);
            this.gbField.ResumeLayout(false);
            this.gbField.PerformLayout();
            this.gbMines.ResumeLayout(false);
            this.gbMines.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFieldSmall;
        private System.Windows.Forms.GroupBox gbField;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbField15;
        private System.Windows.Forms.GroupBox gbMines;
        private System.Windows.Forms.RadioButton rbMines3;
        private System.Windows.Forms.RadioButton rbMines2;
        private System.Windows.Forms.RadioButton rbMines1;
    }
}