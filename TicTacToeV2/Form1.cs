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
        string[] occupiedFields = new string[9];
        bool togglePanel = false;
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
            button1.BackgroundImage = base.BackgroundImage;
            button2.BackgroundImage = base.BackgroundImage;
            button3.BackgroundImage = base.BackgroundImage;
            button4.BackgroundImage = base.BackgroundImage;
            button5.BackgroundImage = base.BackgroundImage;
            button6.BackgroundImage = base.BackgroundImage;
            button7.BackgroundImage = base.BackgroundImage;
            button8.BackgroundImage = base.BackgroundImage;
            button9.BackgroundImage = base.BackgroundImage;
            for (int i = 0; i < occupiedFields.Length; i++)
            {
                occupiedFields[i] = "";
            }
            noOfMoves = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noOfMoves++;          
            button1.Enabled = false;
            if (onMove == "X")
            {               
                button1.BackgroundImage = Properties.Resources.X;
                occupiedFields[0] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {                
                button1.BackgroundImage = Properties.Resources.O;
                occupiedFields[0] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {              
                button2.BackgroundImage = Properties.Resources.X;
                occupiedFields[1] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {            
                button2.BackgroundImage = Properties.Resources.O;
                occupiedFields[1] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                button3.BackgroundImage = Properties.Resources.X;
                occupiedFields[2] = "X";
                    if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {
                button3.BackgroundImage = Properties.Resources.O;
                occupiedFields[2] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                button4.BackgroundImage = Properties.Resources.X;
                occupiedFields[3] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {
                button4.BackgroundImage = Properties.Resources.O;
                occupiedFields[3] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                button5.BackgroundImage = Properties.Resources.X;
                occupiedFields[4] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.O;
                occupiedFields[4] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                button6.BackgroundImage = Properties.Resources.X;
                occupiedFields[5] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {
                button6.BackgroundImage = Properties.Resources.O;
                occupiedFields[5] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                button7.BackgroundImage = Properties.Resources.X;
                occupiedFields[6] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.O;
                occupiedFields[6] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                button8.BackgroundImage = Properties.Resources.X;
                occupiedFields[7] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {
                button8.BackgroundImage = Properties.Resources.O;
                occupiedFields[7] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            noOfMoves++;
            if (onMove == "X")
            {
                button9.BackgroundImage = Properties.Resources.X;
                occupiedFields[8] = "X";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "O";
            }
            else
            {
                button9.BackgroundImage = Properties.Resources.O;
                occupiedFields[8] = "O";
                if (noOfMoves > 4)
                {
                    CheckVictory();
                }
                onMove = "X";
            }
            button9.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CheckVictory()
        {
            if ((occupiedFields[0] == onMove && occupiedFields[1] == onMove && occupiedFields[2] == onMove)||
                (occupiedFields[3] == onMove && occupiedFields[4] == onMove && occupiedFields[5] == onMove)||
                (occupiedFields[6] == onMove && occupiedFields[7] == onMove && occupiedFields[8] == onMove)||
                (occupiedFields[0] == onMove && occupiedFields[3] == onMove && occupiedFields[6] == onMove)||
                (occupiedFields[1] == onMove && occupiedFields[4] == onMove && occupiedFields[7] == onMove)||
                (occupiedFields[2] == onMove && occupiedFields[5] == onMove && occupiedFields[8] == onMove)||
                (occupiedFields[0] == onMove && occupiedFields[4] == onMove && occupiedFields[8] == onMove)||
                (occupiedFields[2] == onMove && occupiedFields[4] == onMove && occupiedFields[6] == onMove))
            {
                if (onMove == "X")
                {
                    winX++;
                    if (player1.Text != "") player1Label.Text = player1.Text + ": " + winX;
                    else player1Label.Text = "Player 1: " + winX;
                    onMove = "O";
                    NewGame.Enabled = true;
                }
                else
                {
                    winO++;
                    if (player2.Text != "") player2Label.Text = player2.Text + ": " + winO;
                    else player2Label.Text = "Player 2: " + winO;
                    onMove = "X";
                    NewGame.Enabled = true;
                }

            }
            else if (noOfMoves == 9)
            {
                //Draw
                if (onMove == "X")
                {
                    onMove = "O";
                    NewGame.Enabled = true;
                }
                else
                {
                    onMove = "X";
                }
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (togglePanel == false)
            {
                togglePanel = true;
                panel3.Visible = true;
            }
            else
            {
                togglePanel = false;
                panel3.Visible = false;
            }

        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (player1.Text != "") player1Label.Text = player1.Text + ": " + winX;
            if (player2.Text != "") player2Label.Text = player2.Text + ": " + winO;
        }
    }
}
