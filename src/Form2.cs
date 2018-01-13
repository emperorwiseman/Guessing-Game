//Kyle Opland Program 3 Guessing Game 11/5/14

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; //To simulate thinking time of computer. http://rosettacode.org/wiki/Guess_the_number/With_feedback_(player)

namespace Guess
{
    public partial class Form1P : Form
    {
        public Form1P()
        {
            InitializeComponent();
        }

        int num = 0;
        int counter = 0;
        int p1guesses = 0;
        int p2guesses = 0;
        int p1score = 0;
        int p2score = 0;
        int max = 100;
        int min = 0;

        private void randomButton_Click(object sender, EventArgs e)
        {
            
            randomButton.Hide();
            Random r = new Random();
            num = r.Next(0, 100);
            entryButton.Show();
            guessTxt.Enabled = true;
        }

        private void entryButton_Click(object sender, EventArgs e)
        {   
             p1Turn();
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
                    if (guess > min)
                    {
                        min = guess;
                    }
                    
                }
                if (guess > num)
                {
                    BackColor = Color.Red;
                    if (guess < max)
                    { 
                        max = guess;
                    }
                    
                }
                if (guess == num)
                {
                    BackColor = DefaultBackColor;
                    entryButton.Hide();
                    randomButton.Show();
                    guessTxt.Clear();
                    guessTxt.Enabled = false;
                    p1score++;
                    p1Score.Text = p1score.ToString();
                    MessageBox.Show("You have guessed the correct number of " + num + ". It took you " + p1guesses + " attempts.", "Congratulations", MessageBoxButtons.OK);
                    p1guesses = 0;
                    p2guesses = 0;
                    min = 0;
                    max = 100;
                    if (p1score == 3)
                    {
                        turnsLabel.Text = "Player 1 has won the game";
                        randomButton.Enabled = false;
                        guessTxt.Enabled = false;
                        mainMenuButton.Show();
                        return;
                    }
                    return;
                }

            }

            else
            {
                MessageBox.Show("Error: Input is not a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                counter--;
                return;
            }
            

         

            
            turnsLabel.Text = "Computer's Turn";
            this.Refresh();
            Thread.Sleep(2500);//Gives time to see the color from your choice before computer goes.

            computerLogic(guess);
        }
        private void computerLogic(int p1Guess)
        {
            int x;
            p2guesses++;
            Random number = new Random();

            if (BackColor == Color.Aqua)
            {
                x = number.Next(min + 1, max);

               
            }
            else if (BackColor == Color.Red)
            {
                x = number.Next(min, max-1);
            }
            else
            {
                x = number.Next(0, 100);

            }

            

            guessTxt.Text = x.ToString();

            if (x < num)
            {
                BackColor = Color.Aqua;
                min = x;
            }

            if (x > num)
            {
                BackColor = Color.Red;
                max = x;
            }
            if (x == num)
            {
                BackColor = DefaultBackColor;
                entryButton.Hide();
                randomButton.Show();
                guessTxt.Clear();
                guessTxt.Enabled = false;
                p2score++;
                CPUScore.Text = p2score.ToString();
                MessageBox.Show("The computer has guessed the correct number of " + num + ". It took " + p2guesses + " attempts.", "You lost", MessageBoxButtons.OK);
                p2guesses = 0;
                p1guesses = 0;
                min = 0;
                max = 100;

            }
            if (p2score == 3)
            {
                turnsLabel.Text = "Computer has won the game";
                guessTxt.Enabled = false;
                randomButton.Enabled = false;
                mainMenuButton.Show();
                return;
            }
            turnsLabel.Text = "Player 1's Turn";
            
        
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        }
    
}
