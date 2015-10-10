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

        //global variable declaration
        bool isXTurn = true;
        string winner;
        Square[,] squares = new Square[NUMBER_OF_ROWS, NUMBER_OF_COLUMNS];

        /// <summary>
        /// Initializes game form, creates grid of squares
        /// </summary>
        public TicTacToe()
        {
            int x = LEFT;
            int y = TOP;

            InitializeComponent();
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
                {
                    squares[i, j] = new Square(HEIGHT, WIDTH, x, y, i, j);
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
            PictureBox selectedButton = sender as PictureBox;

            string buttonName = selectedButton.Name.Replace("pbx", "");
            string[] position = buttonName.Split(new char[] { '_' });
            int row = int.Parse(position[0]);
            int column = int.Parse(position[1]);

            if (squares[row, column].isFull == false)
            {
                if (isXTurn)
                {
                    squares[row, column].selectSquare("X");
                    btnFillRandom.Enabled = true;
                }
                else
                {
                    squares[row, column].selectSquare("O");
                    btnFillRandom.Enabled = false;
                }
                checkWinner();
                isXTurn = !isXTurn;
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

            if ((winner != null) || allFull())
            {
                endGame();
            }
        }
        /// <summary>
        /// Checks if the current player has won
        /// </summary>
        private void checkWinner()
        {
            string xOrO = (isXTurn)?"X":"O";

            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                if (squares[i, 0].xOrO == xOrO && squares[i, 1].xOrO == xOrO && squares[i, 2].xOrO == xOrO)
                {
                    winner = xOrO;
                    return;
                }
            }
            for (int i = 0; i < NUMBER_OF_COLUMNS; i++)
            {
                if (squares[0, i].xOrO == xOrO && squares[1, i].xOrO == xOrO && squares[2, i].xOrO == xOrO)
                {
                    winner = xOrO;
                    return;
                }
            }
            if (squares[0, 0].xOrO == xOrO && squares[1, 1].xOrO == xOrO && squares[2, 2].xOrO == xOrO)
            {
                winner = xOrO;
                return;
            }
            if (squares[0, 2].xOrO == xOrO && squares[1, 1].xOrO == xOrO && squares[2, 0].xOrO == xOrO)
            {
                winner = xOrO;
                return;
            }
        }
        /// <summary>
        /// Shows winner, if there is one
        /// </summary>
        private void endGame()
        {
            if (winner != null)
            {
                MessageBox.Show(winner + " wins!");
            }
            else
            {
                MessageBox.Show("Game Over!");
            }
            foreach (Square square in squares)
            {
                square.Enabled = false;
            }
            btnFillRandom.Enabled = false;
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
        }

    }
}