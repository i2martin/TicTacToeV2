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
        int pobjedaX = 0;
        int PobjedaO = 0;
        string naPotezu = "x";
        int brojPoteza = 0;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
