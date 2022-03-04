using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        int winX = 0;
        int winO = 0;
        string onMove = "X";
        int noOfMoves = 0;

        private void NewGame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            NewGame.Enabled = false;
            noOfMoves = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            button1.Enabled = false;
            if (onMove == "X")
            {
                onMove = "O";
                button1.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button1.BackgroundImage = Properties.Resources.O;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button2.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button2.BackgroundImage = Properties.Resources.O;
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button3.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button3.BackgroundImage = Properties.Resources.O;
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button4.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button4.BackgroundImage = Properties.Resources.O;
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button5.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button5.BackgroundImage = Properties.Resources.O;
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button6.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button6.BackgroundImage = Properties.Resources.O;
            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button7.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button7.BackgroundImage = Properties.Resources.O;
            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button8.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button8.BackgroundImage = Properties.Resources.O;
            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                onMove = "O";
                button9.BackgroundImage = Properties.Resources.X;
            }
            else
            {
                onMove = "X";
                button9.BackgroundImage = Properties.Resources.O;
            }
            button9.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
