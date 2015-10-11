using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEppAssignment2
{
    /// <summary>
    /// A class to model a square in a tic-tac-toe grid
    /// </summary>
    class Square : PictureBox
    {
        public bool isFull;
        public string xOrO;
        /// <summary>
        /// constructor for the Square picturebox object
        /// </summary>
        /// <param name="height">The height of the square</param>
        /// <param name="width">the width of the square</param>
        /// <param name="x">the distance from the left of the window</param>
        /// <param name="y">the distance from the top of the window</param>
        /// <param name="row">the row of the square</param>
        /// <param name="column">the columen of the square</param>
        public Square(int height, int width, int x, int y)
        {
            this.Height = height;
            this.Width = width;
            this.Top = y;
            this.Left = x;
            this.Image = DEppAssignment2.Properties.Resources.square_outline_xxl1;
        }
        /// <summary>
        /// Sets the value of this square to X or O
        /// </summary>
        /// <param name="xOrO">The value to be assigned to this square</param>
        public void selectSquare(string xOrO)
        {
            this.isFull = true;
            this.xOrO = xOrO;
            this.Image = (xOrO == "X") ? DEppAssignment2.Properties.Resources.blue_x : DEppAssignment2.Properties.Resources.blue_o;
        }
        /// <summary>
        /// clears the value of the square
        /// </summary>
        public void clearSquare()
        {
            this.isFull = false;
            this.xOrO = null;
            this.Image = DEppAssignment2.Properties.Resources.square_outline_xxl1;
        }
    }
}
