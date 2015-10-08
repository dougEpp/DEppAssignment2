using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEppAssignment2
{
    class Square : PictureBox
    {
        public bool isFull;
        public string xOrO;
        public static int numXes;
        public static int numOs;
        public Square(int height, int width, int x, int y, int row, int column)
        {
            this.Height = height;
            this.Width = width;
            this.Top = y;
            this.Left = x;
            this.Name = "pbx" + row + "_" + column;
            this.Image = DEppAssignment2.Properties.Resources.square_outline_xxl1;
        }
        public Square()
        {
            this.isFull = false;
            this.xOrO = "";
        }

        public void selectSquare(string xOrO)
        {
            this.isFull = true;
            this.xOrO = xOrO;
        }
    }
}
