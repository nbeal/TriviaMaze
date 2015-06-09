namespace ConsoleApplication4
{
    partial class Maze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maze));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NorthLabel = new System.Windows.Forms.Label();
            this.EastLabel = new System.Windows.Forms.Label();
            this.SouthLabel = new System.Windows.Forms.Label();
            this.WestLabel = new System.Windows.Forms.Label();
            this.DungeonMap5 = new System.Windows.Forms.PictureBox();
            this.WestDoor = new System.Windows.Forms.PictureBox();
            this.EastDoor = new System.Windows.Forms.PictureBox();
            this.SouthDoor = new System.Windows.Forms.PictureBox();
            this.NorthDoor = new System.Windows.Forms.PictureBox();
            this.DungeonMap1 = new System.Windows.Forms.PictureBox();
            this.DungeonMap2 = new System.Windows.Forms.PictureBox();
            this.DungeonMap3 = new System.Windows.Forms.PictureBox();
            this.DungeonMap4 = new System.Windows.Forms.PictureBox();
            this.DungeonMap6 = new System.Windows.Forms.PictureBox();
            this.DungeonMap7 = new System.Windows.Forms.PictureBox();
            this.DungeonMap8 = new System.Windows.Forms.PictureBox();
            this.DungeonMap9 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap9)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.mapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // NorthLabel
            // 
            this.NorthLabel.AutoSize = true;
            this.NorthLabel.Location = new System.Drawing.Point(344, 24);
            this.NorthLabel.Name = "NorthLabel";
            this.NorthLabel.Size = new System.Drawing.Size(33, 13);
            this.NorthLabel.TabIndex = 1;
            this.NorthLabel.Text = "North";
            // 
            // EastLabel
            // 
            this.EastLabel.AutoSize = true;
            this.EastLabel.Location = new System.Drawing.Point(603, 407);
            this.EastLabel.Name = "EastLabel";
            this.EastLabel.Size = new System.Drawing.Size(28, 13);
            this.EastLabel.TabIndex = 2;
            this.EastLabel.Text = "East";
            // 
            // SouthLabel
            // 
            this.SouthLabel.AutoSize = true;
            this.SouthLabel.Location = new System.Drawing.Point(344, 643);
            this.SouthLabel.Name = "SouthLabel";
            this.SouthLabel.Size = new System.Drawing.Size(35, 13);
            this.SouthLabel.TabIndex = 3;
            this.SouthLabel.Text = "South";
            // 
            // WestLabel
            // 
            this.WestLabel.AutoSize = true;
            this.WestLabel.Location = new System.Drawing.Point(95, 407);
            this.WestLabel.Name = "WestLabel";
            this.WestLabel.Size = new System.Drawing.Size(32, 13);
            this.WestLabel.TabIndex = 4;
            this.WestLabel.Text = "West";
            this.WestLabel.Click += new System.EventHandler(this.WestLabel_Click);
            
            // 
            // WestDoor
            // 
            this.WestDoor.Image = ((System.Drawing.Image)(resources.GetObject("WestDoor.Image")));
            this.WestDoor.Location = new System.Drawing.Point(44, 269);
            this.WestDoor.Name = "WestDoor";
            this.WestDoor.Size = new System.Drawing.Size(130, 135);
            this.WestDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WestDoor.TabIndex = 6;
            this.WestDoor.TabStop = false;
            this.WestDoor.Click += new System.EventHandler(this.WestDoor_Click);
            // 
            // EastDoor
            // 
            this.EastDoor.Image = ((System.Drawing.Image)(resources.GetObject("EastDoor.Image")));
            this.EastDoor.Location = new System.Drawing.Point(556, 269);
            this.EastDoor.Name = "EastDoor";
            this.EastDoor.Size = new System.Drawing.Size(130, 135);
            this.EastDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EastDoor.TabIndex = 7;
            this.EastDoor.TabStop = false;
            this.EastDoor.Click += new System.EventHandler(this.EastDoor_Click);
            // 
            // SouthDoor
            // 
            this.SouthDoor.Image = ((System.Drawing.Image)(resources.GetObject("SouthDoor.Image")));
            this.SouthDoor.Location = new System.Drawing.Point(299, 504);
            this.SouthDoor.Name = "SouthDoor";
            this.SouthDoor.Size = new System.Drawing.Size(130, 135);
            this.SouthDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SouthDoor.TabIndex = 8;
            this.SouthDoor.TabStop = false;
            this.SouthDoor.Click += new System.EventHandler(this.SouthDoor_Click);
            // 
            // NorthDoor
            // 
            this.NorthDoor.Image = ((System.Drawing.Image)(resources.GetObject("NorthDoor.Image")));
            this.NorthDoor.Location = new System.Drawing.Point(299, 40);
            this.NorthDoor.Name = "NorthDoor";
            this.NorthDoor.Size = new System.Drawing.Size(130, 135);
            this.NorthDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NorthDoor.TabIndex = 9;
            this.NorthDoor.TabStop = false;
            this.NorthDoor.Click += new System.EventHandler(this.NorthDoor_Click);
            // 
            // DungeonMap1
            // 
            this.DungeonMap1.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap1.Image")));
            this.DungeonMap1.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap1.Name = "DungeonMap1";
            this.DungeonMap1.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap1.TabIndex = 10;
            this.DungeonMap1.TabStop = false;
            // 
            // DungeonMap2
            // 
            this.DungeonMap2.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap2.Image")));
            this.DungeonMap2.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap2.Name = "DungeonMap2";
            this.DungeonMap2.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap2.TabIndex = 11;
            this.DungeonMap2.TabStop = false;
            // 
            // DungeonMap3
            // 
            this.DungeonMap3.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap3.Image")));
            this.DungeonMap3.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap3.Name = "DungeonMap3";
            this.DungeonMap3.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap3.TabIndex = 12;
            this.DungeonMap3.TabStop = false;
            // 
            // DungeonMap4
            // 
            this.DungeonMap4.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap4.Image")));
            this.DungeonMap4.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap4.Name = "DungeonMap4";
            this.DungeonMap4.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap4.TabIndex = 13;
            this.DungeonMap4.TabStop = false;
            // 
            // DungeonMap5
            // 
            this.DungeonMap5.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap5.Image")));
            this.DungeonMap5.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap5.Name = "DungeonMap5";
            this.DungeonMap5.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap5.TabIndex = 5;
            this.DungeonMap5.TabStop = false;
            // 
            // DungeonMap6
            // 
            this.DungeonMap6.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap6.Image")));
            this.DungeonMap6.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap6.Name = "DungeonMap6";
            this.DungeonMap6.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap6.TabIndex = 14;
            this.DungeonMap6.TabStop = false;
            // 
            // DungeonMap7
            // 
            this.DungeonMap7.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap7.Image")));
            this.DungeonMap7.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap7.Name = "DungeonMap7";
            this.DungeonMap7.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap7.TabIndex = 15;
            this.DungeonMap7.TabStop = false;
            // 
            // DungeonMap8
            // 
            this.DungeonMap8.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap8.Image")));
            this.DungeonMap8.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap8.Name = "DungeonMap8";
            this.DungeonMap8.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap8.TabIndex = 16;
            this.DungeonMap8.TabStop = false;
            // 
            // DungeonMap9
            // 
            this.DungeonMap9.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap9.Image")));
            this.DungeonMap9.Location = new System.Drawing.Point(180, 181);
            this.DungeonMap9.Name = "DungeonMap9";
            this.DungeonMap9.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap9.TabIndex = 17;
            this.DungeonMap9.TabStop = false;
            // 
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 657);
            this.Controls.Add(this.DungeonMap9);
            this.Controls.Add(this.DungeonMap8);
            this.Controls.Add(this.DungeonMap7);
            this.Controls.Add(this.DungeonMap6);
            this.Controls.Add(this.DungeonMap4);
            this.Controls.Add(this.DungeonMap3);
            this.Controls.Add(this.DungeonMap2);
            this.Controls.Add(this.DungeonMap1);
            this.Controls.Add(this.NorthDoor);
            this.Controls.Add(this.SouthDoor);
            this.Controls.Add(this.EastDoor);
            this.Controls.Add(this.WestDoor);
            this.Controls.Add(this.DungeonMap5);
            this.Controls.Add(this.WestLabel);
            this.Controls.Add(this.SouthLabel);
            this.Controls.Add(this.EastLabel);
            this.Controls.Add(this.NorthLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Maze";
            this.Text = "Maze";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.Label NorthLabel;
        private System.Windows.Forms.Label EastLabel;
        private System.Windows.Forms.Label SouthLabel;
        private System.Windows.Forms.Label WestLabel;
        private System.Windows.Forms.PictureBox DungeonMap5;
        private System.Windows.Forms.PictureBox WestDoor;
        private System.Windows.Forms.PictureBox EastDoor;
        private System.Windows.Forms.PictureBox SouthDoor;
        private System.Windows.Forms.PictureBox NorthDoor;
        private System.Windows.Forms.PictureBox DungeonMap1;
        private System.Windows.Forms.PictureBox DungeonMap2;
        private System.Windows.Forms.PictureBox DungeonMap3;
        private System.Windows.Forms.PictureBox DungeonMap4;
        private System.Windows.Forms.PictureBox DungeonMap6;
        private System.Windows.Forms.PictureBox DungeonMap7;
        private System.Windows.Forms.PictureBox DungeonMap8;
        private System.Windows.Forms.PictureBox DungeonMap9;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
    }
}