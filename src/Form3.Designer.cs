namespace Guess
{
    partial class Form2P
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
            this.RandomButton = new System.Windows.Forms.Button();
            this.guessTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1Label = new System.Windows.Forms.Label();
            this.p2Label = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(57, 176);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(75, 23);
            this.RandomButton.TabIndex = 0;
            this.RandomButton.Text = "Roll";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // guessTxt
            // 
            this.guessTxt.Enabled = false;
            this.guessTxt.Location = new System.Drawing.Point(116, 120);
            this.guessTxt.Name = "guessTxt";
            this.guessTxt.Size = new System.Drawing.Size(57, 20);
            this.guessTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guess the Number:";
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(35, 176);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(111, 23);
            this.entryButton.TabIndex = 3;
            this.entryButton.Text = "Submit Guess";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Visible = false;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 1 Score -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player 2 Score -";
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.Location = new System.Drawing.Point(292, 107);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(13, 13);
            this.p1Label.TabIndex = 6;
            this.p1Label.Text = "0";
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Location = new System.Drawing.Point(292, 130);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(13, 13);
            this.p2Label.TabIndex = 7;
            this.p2Label.Text = "0";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(11, 39);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(135, 24);
            this.turnLabel.TabIndex = 8;
            this.turnLabel.Text = "Player 1\'s Turn";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(207, 176);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.mainMenuButton.TabIndex = 9;
            this.mainMenuButton.Text = "Play Again?";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Visible = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // Form2P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 245);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.p2Label);
            this.Controls.Add(this.p1Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessTxt);
            this.Controls.Add(this.RandomButton);
            this.Name = "Form2P";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.TextBox guessTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Button mainMenuButton;
    }
}
