using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guesser
{
    public partial class Form1 : Form
    {
        double lastGuess,
               lowerBound = 0,
               upperBound,
               guessCount;

        public Form1()
        {
            InitializeComponent();
        }

        private double MakeGuess(bool lower = true)
        {
            lblGuessCount.Text = "Guess Count: " + (++guessCount);
            if (lower)
            {
                upperBound = lastGuess;
                lastGuess = Math.Round((lastGuess + lowerBound) / 2);
            }
            else
            {
                lowerBound = lastGuess;
                lastGuess = Math.Round((lastGuess + upperBound) / 2);
            }
            
            return lastGuess;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Do you have your number picked?", "Pick Your Number", MessageBoxButtons.YesNo))
                return;

            if (lastGuess == 0)
            {
                if (double.TryParse(txtLimit.Text, out lastGuess))
                {
                    txtLimit.ReadOnly = true;
                    btnGuess.Enabled = false;
                    btnGotIt.Enabled = true;
                    btnHigher.Enabled = true;
                    btnLower.Enabled = true;
                    upperBound = lastGuess;
                    lblGuess.Text = MakeGuess().ToString();
                }
                else
                {
                    txtLimit.ReadOnly = false;
                    btnGuess.Enabled = true;
                    btnGotIt.Enabled = false;
                    btnHigher.Enabled = false;
                    btnLower.Enabled = false;
                    MessageBox.Show("Please enter a valid number for the Limit.");
                }
            }
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            lblGuess.Text = MakeGuess(sender == btnLower).ToString();
        }

        private void btnGotIt_Click(object sender, EventArgs e)
        {
            txtLimit.ReadOnly = false;
            btnGuess.Enabled = true;
            btnGotIt.Enabled = false;
            btnHigher.Enabled = false;
            btnLower.Enabled = false;
            txtLimit.Focus();
            lastGuess = upperBound = lowerBound = guessCount = 0;
        }
    }
}
