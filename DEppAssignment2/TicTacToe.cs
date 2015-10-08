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
    public partial class TicTacToe : Form
    {
        const int TOP = 20;
        const int LEFT = 20;
        const int HEIGHT = 70;
        const int WIDTH = 70;
        const int NUMBER_OF_ROWS = 3;
        const int NUMBER_OF_COLUMNS = 3;
        const int VICTORY_STREAK = 3;
        bool isXTurn = true;
        Square[,] squares = new Square[NUMBER_OF_ROWS, NUMBER_OF_COLUMNS];

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
        }


        public void changeValue(object sender, EventArgs e)
        {
            PictureBox selectedButton = sender as PictureBox;

            string buttonName = selectedButton.Name;
            buttonName = buttonName.Replace("pbx", "");
            string[] position = buttonName.Split(new char[] { '_' });
            //MessageBox.Show(position[0] + ", " + position[1]);

            if  (selectedButton.Text == "")
            {
                if (isXTurn)
                {
                    squares[int.Parse(position[0]), int.Parse(position[1])].selectSquare("X");
                    selectedButton.Text = "X";
                    Square.numXes++;
                    //MessageBox.Show(Square.numXes.ToString());
                }
                else
                {
                    squares[int.Parse(position[0]), int.Parse(position[1])].selectSquare("X");
                    selectedButton.Text = "O";
                    Square.numOs++;
                    //MessageBox.Show(Square.numOs.ToString());
                }
                isXTurn = !isXTurn;
            }
            else
            {
                MessageBox.Show("Already full");
            }
            if (allFull())
            {
                MessageBox.Show("Game Over!");
            }
        }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}