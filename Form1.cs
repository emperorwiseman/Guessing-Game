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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            Form1P onePlayer = new Form1P();
            this.Hide();
            onePlayer.ShowDialog();
            this.Show();
            
        }

        private void twoPlayerButton_Click(object sender, EventArgs e)
        {
            Form2P twoPlayer = new Form2P();
            this.Hide();
            twoPlayer.ShowDialog();
            this.Show();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
