namespace ConsoleApplication4
{
    partial class Question
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
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.QuestionField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(25, 139);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(576, 37);
            this.answer1.TabIndex = 1;
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(25, 182);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(576, 37);
            this.answer2.TabIndex = 2;
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(25, 225);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(576, 37);
            this.answer3.TabIndex = 3;
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(25, 268);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(576, 37);
            this.answer4.TabIndex = 4;
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.Click += new System.EventHandler(this.answer4_Click);
            // 
            // QuestionField
            // 
            this.QuestionField.AutoSize = true;
            this.QuestionField.Location = new System.Drawing.Point(22, 58);
            this.QuestionField.Name = "QuestionField";
            this.QuestionField.Size = new System.Drawing.Size(10, 13);
            this.QuestionField.TabIndex = 5;
            this.QuestionField.Text = " ";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 338);
            this.Controls.Add(this.QuestionField);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Name = "Question";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Label QuestionField;
    }
}