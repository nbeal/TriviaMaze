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
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NorthLabel = new System.Windows.Forms.Label();
            this.EastLabel = new System.Windows.Forms.Label();
            this.SouthLabel = new System.Windows.Forms.Label();
            this.WestLabel = new System.Windows.Forms.Label();
            this.DungeonMap = new System.Windows.Forms.PictureBox();
            this.WestDoor = new System.Windows.Forms.PictureBox();
            this.EastDoor = new System.Windows.Forms.PictureBox();
            this.SouthDoor = new System.Windows.Forms.PictureBox();
            this.NorthDoor = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthDoor)).BeginInit();
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
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.saveGameToolStripMenuItem.Text = "Save Game";
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
            this.WestLabel.Location = new System.Drawing.Point(85, 407);
            this.WestLabel.Name = "WestLabel";
            this.WestLabel.Size = new System.Drawing.Size(32, 13);
            this.WestLabel.TabIndex = 4;
            this.WestLabel.Text = "West";
            this.WestLabel.Click += new System.EventHandler(this.WestLabel_Click);
            // 
            // DungeonMap
            // 
            this.DungeonMap.Image = ((System.Drawing.Image)(resources.GetObject("DungeonMap.Image")));
            this.DungeonMap.Location = new System.Drawing.Point(174, 181);
            this.DungeonMap.Name = "DungeonMap";
            this.DungeonMap.Size = new System.Drawing.Size(370, 317);
            this.DungeonMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DungeonMap.TabIndex = 5;
            this.DungeonMap.TabStop = false;
            // 
            // WestDoor
            // 
            this.WestDoor.Image = ((System.Drawing.Image)(resources.GetObject("WestDoor.Image")));
            this.WestDoor.Location = new System.Drawing.Point(38, 269);
            this.WestDoor.Name = "WestDoor";
            this.WestDoor.Size = new System.Drawing.Size(130, 135);
            this.WestDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WestDoor.TabIndex = 6;
            this.WestDoor.TabStop = false;
            // 
            // EastDoor
            // 
            this.EastDoor.Image = ((System.Drawing.Image)(resources.GetObject("EastDoor.Image")));
            this.EastDoor.Location = new System.Drawing.Point(550, 269);
            this.EastDoor.Name = "EastDoor";
            this.EastDoor.Size = new System.Drawing.Size(130, 135);
            this.EastDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EastDoor.TabIndex = 7;
            this.EastDoor.TabStop = false;
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
            // 
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 657);
            this.Controls.Add(this.NorthDoor);
            this.Controls.Add(this.SouthDoor);
            this.Controls.Add(this.EastDoor);
            this.Controls.Add(this.WestDoor);
            this.Controls.Add(this.DungeonMap);
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
            ((System.ComponentModel.ISupportInitialize)(this.DungeonMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthDoor)).EndInit();
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
        private System.Windows.Forms.PictureBox DungeonMap;
        private System.Windows.Forms.PictureBox WestDoor;
        private System.Windows.Forms.PictureBox EastDoor;
        private System.Windows.Forms.PictureBox SouthDoor;
        private System.Windows.Forms.PictureBox NorthDoor;
    }
}