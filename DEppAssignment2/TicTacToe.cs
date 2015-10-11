/* Tic Tac Toe
 * A simple C# Windows Forms game
 * 
 * Revision History: 
 *  2015/10/02 - Created, Doug Epp
 *  2015/10/08 - Changed grid to be created programatically;
 *             - Added images to project
 *             - Added code to update value of squares
 *  2015/10/09 - Added win condition checking
 *             - Fixed bugs
 *             - Added randomized computer opponent
 *             - Completed, Doug Epp
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEppAssignment2
{
    /// <summary>
    /// A class to create the Tic Tac Toe game form
    /// </summary>
    public partial class TicTacToe : Form
    {
        //constant declaration
        const int TOP = 20;
        const int LEFT = 20;
        const int HEIGHT = 70;
        const int WIDTH = 70;
        const int NUMBER_OF_ROWS = 3;
        const int NUMBER_OF_COLUMNS = 3;
        const int WIN_STREAK = 3;

        //global variable declaration
        bool isXTurn = true;
        string winner;
        Square[,] squares = new Square[NUMBER_OF_ROWS, NUMBER_OF_COLUMNS];
        int xWins = 0;
        int oWins = 0;

        /// <summary>
        /// Initializes game form, creates grid of squares
        /// </summary>
        public TicTacToe()
        {
            int x = LEFT;
            int y = TOP;

            InitializeComponent();

            //creates grid of squares and adds them to the form
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
                {
                    squares[i, j] = new Square(HEIGHT, WIDTH, x, y);
                    squares[i, j].Click += changeValue;
                    this.Controls.Add(squares[i, j]);
                    x += WIDTH;
                }
                y += HEIGHT;
                x = LEFT;
            }
            btnFillRandom.Enabled = false;
            
        }

        /// <summary>
        /// Sets value of the clicked square to "X" or "O"
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments for the click event</param>
        public void changeValue(object sender, EventArgs e)
        {
            Square selectedButton = (Square)sender;

            if (selectedButton.isFull == false)//the square has not been clicked
            {
                if (isXTurn)
                {
                    selectedButton.selectSquare("X");
                    btnFillRandom.Enabled = true;
                }
                else
                {
                    selectedButton.selectSquare("O");
                    btnFillRandom.Enabled = false;
                }
                checkWinner();
                isXTurn = !isXTurn;
                lblXOrO.Text = (isXTurn) ? "X" : "O";
            }
            else
            {
                MessageBox.Show("Already full");
            }
            if ((winner != null) || allFull())
            {
                endGame();
            }
        }
        /// <summary>
        /// Checks if all squares are full
        /// </summary>
        /// <returns>True if all squares are full; else false</returns>
        private bool allFull()
        {
            foreach (Square square in squares)
            {
                if (!square.isFull)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Fills a random square with "O"
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Event arguments for the click event</param>
        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            if (!allFull())
            {
                bool success = false;
                Random rand = new Random();

                while (success == false)
                {
                    int row = rand.Next(NUMBER_OF_ROWS);
                    int col = rand.Next(NUMBER_OF_COLUMNS);

                    if (!squares[row, col].isFull)
                    {
                        squares[row, col].selectSquare("O");
                        success = true;
                        btnFillRandom.Enabled = false;
                    }
                }
                checkWinner();
                isXTurn = !isXTurn;
                lblXOrO.Text = (isXTurn) ? "X" : "O";

                if ((winner != null) || allFull())
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("All squares full!");
            }
        }
        /// <summary>
        /// Checks if the current player has won
        /// </summary>
        private void checkWinner()
        {
            string xOrO = (isXTurn) ? "X" : "O";
            int counter = 0;
            //Check all rows
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
                {
                    if (squares[i, j].xOrO == xOrO)
                    {
                        counter++;
                    }
                    if (counter == WIN_STREAK)
                    {
                        winner = xOrO;
                        return;
                    }
                }
                counter = 0;
            }
            //check all columns
            for (int i = 0; i < NUMBER_OF_COLUMNS; i++)
            {
                for (int j = 0; j < NUMBER_OF_ROWS; j++)
                {
                    if (squares[j, i].xOrO == xOrO)
                    {
                        counter++;
                    }
                    if (counter == WIN_STREAK)
                    {
                        winner = xOrO;
                        return;
                    }
                }
                counter = 0;
            }
            //check diagonal down-right
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                if (squares[i, i].xOrO == xOrO)
                {
                    counter++;
                }
                if (counter == WIN_STREAK)
                {
                    winner = xOrO;
                    return;
                }
            }
            counter = 0;
            //check diagonal down-left
            int col = 0;
            for (int i = NUMBER_OF_ROWS - 1; i >= 0; i--)
            {
                if (squares[i, col].xOrO == xOrO)
                {
                    counter++;
                }
                if (counter == WIN_STREAK)
                {
                    winner = xOrO;
                    return;
                }
                col++;
            }
        }
        /// <summary>
        /// Shows winner, if there is one
        /// </summary>
        private void endGame()
        {
            if (winner != null)//a player has won
            {
                if (winner == "X")
                {
                    xWins++;
                }
                else
                {
                    oWins++;
                }
                MessageBox.Show(winner + " wins!", "Game Over");
            }
            else //game is over with no winner
            {
                MessageBox.Show("No winner.", "Game Over");
            }

            foreach (Square square in squares)
            {
                square.Enabled = false;
            }
            btnFillRandom.Enabled = false;

            lblXScore.Text = xWins.ToString();
            lblOScore.Text = oWins.ToString();
        }
        /// <summary>
        /// calls the ResetForm method
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Event arguments for the click event</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        /// <summary>
        /// Resets the form so another game can be played
        /// </summary>
        private void resetForm()
        {
            foreach (Square square in squares)
            {
                square.clearSquare();
                square.Enabled = true;
            }
            winner = null;
            isXTurn = true;
            btnFillRandom.Enabled = false;
            lblXOrO.Text = "X";
        }
    }
}