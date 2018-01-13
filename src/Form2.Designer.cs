namespace Guess
{
    partial class Form1P
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
            this.randomButton = new System.Windows.Forms.Button();
            this.guessTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.CPUScore = new System.Windows.Forms.Label();
            this.entryButton = new System.Windows.Forms.Button();
            this.turnsLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(56, 173);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(75, 23);
            this.randomButton.TabIndex = 0;
            this.randomButton.Text = "Roll";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // guessTxt
            // 
            this.guessTxt.Enabled = false;
            this.guessTxt.Location = new System.Drawing.Point(113, 117);
            this.guessTxt.Name = "guessTxt";
            this.guessTxt.Size = new System.Drawing.Size(56, 20);
            this.guessTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guess the Number";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(204, 106);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(82, 13);
            this.label78.TabIndex = 3;
            this.label78.Text = "Player 1 Score -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPU Score -";
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.Location = new System.Drawing.Point(292, 106);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(13, 13);
            this.p1Score.TabIndex = 5;
            this.p1Score.Text = "0";
            // 
            // CPUScore
            // 
            this.CPUScore.AutoSize = true;
            this.CPUScore.Location = new System.Drawing.Point(292, 135);
            this.CPUScore.Name = "CPUScore";
            this.CPUScore.Size = new System.Drawing.Size(13, 13);
            this.CPUScore.TabIndex = 6;
            this.CPUScore.Text = "0";
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(38, 173);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(108, 23);
            this.entryButton.TabIndex = 7;
            this.entryButton.Text = "Submit Guess";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Visible = false;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // turnsLabel
            // 
            this.turnsLabel.AutoSize = true;
            this.turnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnsLabel.Location = new System.Drawing.Point(11, 41);
            this.turnsLabel.Name = "turnsLabel";
            this.turnsLabel.Size = new System.Drawing.Size(135, 24);
            this.turnsLabel.TabIndex = 8;
            this.turnsLabel.Text = "Player 1\'s Turn";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(207, 173);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.mainMenuButton.TabIndex = 10;
            this.mainMenuButton.Text = "Play Again?";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Visible = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // Form1P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 246);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.turnsLabel);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.CPUScore);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessTxt);
            this.Controls.Add(this.randomButton);
            this.Name = "Form1P";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.TextBox guessTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label CPUScore;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Label turnsLabel;
        private System.Windows.Forms.Button mainMenuButton;
    }
}
