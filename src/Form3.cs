//Kyle Opland Program 3 Guessing Game 11/5/14

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guess
{
    public partial class Form2P : Form
    {

        public Form2P()
        {
            InitializeComponent();
            
        }

        int num = 0;
        int counter = 0;
        int p1guesses = 0;
        int p2guesses = 0;
        int p1score = 0;
        int p2score = 0;

        private void RandomButton_Click(object sender, EventArgs e)
        {
            RandomButton.Hide();
            Random r = new Random();
            num = r.Next(0, 100);
            entryButton.Show();
            guessTxt.Enabled = true;
            
        }
        private void p1Turn()
        {
            int guess;
            p1guesses++;

            if (Int32.TryParse(guessTxt.Text, out guess))
            {
                if (guess < num)
                {
                    BackColor = Color.Aqua;
                }
                if (guess > num)
                {
                    BackColor = Color.Red;
                }
                if (guess == num)
                {
                    BackColor = DefaultBackColor;
                    entryButton.Hide();
                    RandomButton.Show();
                    guessTxt.Clear();
                    guessTxt.Enabled = false;
                    p1score++;
                    p1Label.Text = p1score.ToString();
                    MessageBox.Show("You have guessed the correct number of " + num + ". It took you " + p1guesses + " attempts.", "Congratulations", MessageBoxButtons.OK);
                    p1guesses = 0;
                    
                }   

            }

            else
            {
                MessageBox.Show("Error: Input is not a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                counter--;
                return;
            }
            if (p1score == 3)
            {
                turnLabel.Text = "Player 1 has won the game";
                RandomButton.Enabled = false;
                mainMenuButton.Show();
                return;
            }

            turnLabel.Text = "Player 2's Turn";
        }

        private void p2Turn()
        {
            int guess;
            p2guesses++;

            if (Int32.TryParse(guessTxt.Text, out guess))
            {
                if (guess < num)
                {
                    BackColor = Color.Aqua;
                }
                if (guess > num)
                {
                    BackColor = Color.Red;
                }

                if (guess == num)
                {
                    BackColor = DefaultBackColor;
                    entryButton.Hide();
                    RandomButton.Show();
                    guessTxt.Clear();
                    guessTxt.Enabled = false;
                    p2score++;
                    p2Label.Text = p2score.ToString();
                    MessageBox.Show("You have guessed the correct number of " + num + ". It took you " + p2guesses + " attempts.", "Congratulations", MessageBoxButtons.OK);
                    p2guesses = 0;
                    
                }     
                    
            }
            else
            {
                MessageBox.Show("Error: Input is not a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                counter--;
                return;
            }
            if (p2score == 3)
            {
                turnLabel.Text = "Player 2 has won the game";
                RandomButton.Enabled = false;
                mainMenuButton.Show();
                return;
            }
            turnLabel.Text = "Player 1's Turn";

        }
        private void entryButton_Click( object sender, EventArgs e)
        {

            
            counter++;
            if (counter % 2 == 0)
            {
                p2Turn();
            }
            else
            {
                p1Turn();
            }
            


        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
