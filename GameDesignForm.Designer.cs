namespace PYuAssignment2
{
    partial class GameDesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.pl = new System.Windows.Forms.Panel();
            this.pbGbox = new System.Windows.Forms.PictureBox();
            this.pbRbox = new System.Windows.Forms.PictureBox();
            this.pbGdoor = new System.Windows.Forms.PictureBox();
            this.pbRdoor = new System.Windows.Forms.PictureBox();
            this.pbWall = new System.Windows.Forms.PictureBox();
            this.pbNone = new System.Windows.Forms.PictureBox();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRdoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNone)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(372, 43);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(175, 20);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(77, 43);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(91, 20);
            this.txtRow.TabIndex = 2;
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(238, 43);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(91, 20);
            this.txtCol.TabIndex = 3;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(36, 50);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(34, 13);
            this.lblRow.TabIndex = 4;
            this.lblRow.Text = "Rows";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(185, 50);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(47, 13);
            this.lblCol.TabIndex = 5;
            this.lblCol.Text = "Columns";
            // 
            // pl
            // 
            this.pl.Controls.Add(this.pbGbox);
            this.pl.Controls.Add(this.pbRbox);
            this.pl.Controls.Add(this.pbGdoor);
            this.pl.Controls.Add(this.pbRdoor);
            this.pl.Controls.Add(this.pbWall);
            this.pl.Controls.Add(this.pbNone);
            this.pl.Controls.Add(this.btnGreenBox);
            this.pl.Controls.Add(this.btnRedBox);
            this.pl.Controls.Add(this.btnGreenDoor);
            this.pl.Controls.Add(this.btnRedDoor);
            this.pl.Controls.Add(this.btnWall);
            this.pl.Controls.Add(this.btnNone);
            this.pl.Controls.Add(this.label1);
            this.pl.Location = new System.Drawing.Point(12, 81);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(156, 449);
            this.pl.TabIndex = 6;
            // 
            // pbGbox
            // 
            this.pbGbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGbox.Image = ((System.Drawing.Image)(resources.GetObject("pbGbox.Image")));
            this.pbGbox.Location = new System.Drawing.Point(27, 357);
            this.pbGbox.Name = "pbGbox";
            this.pbGbox.Size = new System.Drawing.Size(50, 51);
            this.pbGbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGbox.TabIndex = 25;
            this.pbGbox.TabStop = false;
            // 
            // pbRbox
            // 
            this.pbRbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRbox.Image = ((System.Drawing.Image)(resources.GetObject("pbRbox.Image")));
            this.pbRbox.Location = new System.Drawing.Point(27, 292);
            this.pbRbox.Name = "pbRbox";
            this.pbRbox.Size = new System.Drawing.Size(50, 51);
            this.pbRbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRbox.TabIndex = 24;
            this.pbRbox.TabStop = false;
            // 
            // pbGdoor
            // 
            this.pbGdoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGdoor.Image = ((System.Drawing.Image)(resources.GetObject("pbGdoor.Image")));
            this.pbGdoor.Location = new System.Drawing.Point(27, 227);
            this.pbGdoor.Name = "pbGdoor";
            this.pbGdoor.Size = new System.Drawing.Size(50, 51);
            this.pbGdoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGdoor.TabIndex = 23;
            this.pbGdoor.TabStop = false;
            // 
            // pbRdoor
            // 
            this.pbRdoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRdoor.Image = ((System.Drawing.Image)(resources.GetObject("pbRdoor.Image")));
            this.pbRdoor.Location = new System.Drawing.Point(27, 162);
            this.pbRdoor.Name = "pbRdoor";
            this.pbRdoor.Size = new System.Drawing.Size(50, 51);
            this.pbRdoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRdoor.TabIndex = 22;
            this.pbRdoor.TabStop = false;
            // 
            // pbWall
            // 
            this.pbWall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbWall.Image = ((System.Drawing.Image)(resources.GetObject("pbWall.Image")));
            this.pbWall.Location = new System.Drawing.Point(27, 97);
            this.pbWall.Name = "pbWall";
            this.pbWall.Size = new System.Drawing.Size(50, 51);
            this.pbWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWall.TabIndex = 21;
            this.pbWall.TabStop = false;
            // 
            // pbNone
            // 
            this.pbNone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbNone.Image = ((System.Drawing.Image)(resources.GetObject("pbNone.Image")));
            this.pbNone.Location = new System.Drawing.Point(27, 32);
            this.pbNone.Name = "pbNone";
            this.pbNone.Size = new System.Drawing.Size(50, 51);
            this.pbNone.TabIndex = 20;
            this.pbNone.TabStop = false;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Location = new System.Drawing.Point(13, 357);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(140, 51);
            this.btnGreenBox.TabIndex = 19;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Location = new System.Drawing.Point(13, 292);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(140, 51);
            this.btnRedBox.TabIndex = 18;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Location = new System.Drawing.Point(13, 227);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(140, 51);
            this.btnGreenDoor.TabIndex = 17;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Location = new System.Drawing.Point(13, 162);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(140, 51);
            this.btnRedDoor.TabIndex = 16;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // btnWall
            // 
            this.btnWall.Location = new System.Drawing.Point(13, 97);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(140, 51);
            this.btnWall.TabIndex = 15;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnNone
            // 
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNone.Location = new System.Drawing.Point(13, 32);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(140, 51);
            this.btnNone.TabIndex = 14;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tool Box";
            // 
            // GameDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameDesignForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameDesignForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pl.ResumeLayout(false);
            this.pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRdoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.PictureBox pbGbox;
        private System.Windows.Forms.PictureBox pbRbox;
        private System.Windows.Forms.PictureBox pbGdoor;
        private System.Windows.Forms.PictureBox pbRdoor;
        private System.Windows.Forms.PictureBox pbWall;
        private System.Windows.Forms.PictureBox pbNone;
    }
}