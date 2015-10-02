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
        const int NUMBER_OF_ROWS = 3;
        const int NUMBER_OF_COLUMNS = 3;
        bool x = true;

        public TicTacToe()
        {
            InitializeComponent();
        }


        private void changeValue(object sender)
        {
            Button selectedButton = sender as Button;

            string buttonName = selectedButton.Name;
            buttonName = buttonName.Replace("btn", "");
            string[] position = buttonName.Split(new char[] { '_' });
            MessageBox.Show(position[0] + ", " + position[1]);

            if  (selectedButton.Text == "")
            {
                if (x)
                {
                    selectedButton.Text = "X";
                }
                else
                {
                    selectedButton.Text = "O";
                }
                x = !x;
            }
            else
            {
                MessageBox.Show("Already full");
            }
        }

        private void btn0_0_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn0_1_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn0_2_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn1_0_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn1_1_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn1_2_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn2_0_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn2_1_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
        private void btn2_2_Click(object sender, EventArgs e)
        {
            changeValue(sender);
        }
    }
}
