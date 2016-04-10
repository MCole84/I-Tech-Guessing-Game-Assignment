using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private GuessingGame newGame;

        public Form1()
        {
            InitializeComponent();
            newGame = new GuessingGame();
            lblGuessResult.Text = "";
            newGame.StartRound();
        }

        private void btnCheckGuess_Click(object sender, EventArgs e)
        {
            try
            {
                if (newGame.CheckAnswer(int.Parse(txtUserGuess.Text)))
                {
                    lblGuessResult.Text = $"Congratulations you guessed the number in {newGame.NumberOfGuesses} attempts.";
                    newGame.StartRound();
                }
                else
                {
                    lblGuessResult.Text = newGame.CheckGreaterThanLessThan();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data in the text box. Please input integer values only", "Error on input");
            }
        }
    }
}