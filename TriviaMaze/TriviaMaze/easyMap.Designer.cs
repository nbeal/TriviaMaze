namespace ConsoleApplication4
{
    partial class easyMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easyMap));
            this.map0 = new System.Windows.Forms.PictureBox();
            this.map1 = new System.Windows.Forms.PictureBox();
            this.map2 = new System.Windows.Forms.PictureBox();
            this.map3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.map0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map3)).BeginInit();
            this.SuspendLayout();
            // 
            // map0
            // 
            this.map0.Image = ((System.Drawing.Image)(resources.GetObject("map0.Image")));
            this.map0.Location = new System.Drawing.Point(35, 32);
            this.map0.Name = "map0";
            this.map0.Size = new System.Drawing.Size(517, 402);
            this.map0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map0.TabIndex = 0;
            this.map0.TabStop = false;
            this.map0.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // map1
            // 
            this.map1.Image = ((System.Drawing.Image)(resources.GetObject("map1.Image")));
            this.map1.Location = new System.Drawing.Point(35, 32);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(517, 402);
            this.map1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map1.TabIndex = 1;
            this.map1.TabStop = false;
            // 
            // map2
            // 
            this.map2.Image = ((System.Drawing.Image)(resources.GetObject("map2.Image")));
            this.map2.Location = new System.Drawing.Point(35, 32);
            this.map2.Name = "map2";
            this.map2.Size = new System.Drawing.Size(517, 402);
            this.map2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map2.TabIndex = 2;
            this.map2.TabStop = false;
            // 
            // map3
            // 
            this.map3.Image = ((System.Drawing.Image)(resources.GetObject("map3.Image")));
            this.map3.Location = new System.Drawing.Point(35, 32);
            this.map3.Name = "map3";
            this.map3.Size = new System.Drawing.Size(517, 402);
            this.map3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map3.TabIndex = 3;
            this.map3.TabStop = false;
            this.map3.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // easyMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.map3);
            this.Controls.Add(this.map2);
            this.Controls.Add(this.map1);
            this.Controls.Add(this.map0);
            this.Name = "easyMap";
            this.Text = "Easy Map";
            this.Load += new System.EventHandler(this.easyMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.map0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map0;
        private System.Windows.Forms.PictureBox map1;
        private System.Windows.Forms.PictureBox map2;
        private System.Windows.Forms.PictureBox map3;
    }
}