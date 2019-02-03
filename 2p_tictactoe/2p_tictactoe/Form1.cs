using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2p_tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string wincheck()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")) return "X";
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")) return "O";
            else return "0";
        }
        void win(string wnr)
        {
            won = 1;
            if (wnr == "X") label7.Text = Convert.ToString(Convert.ToInt32(label7.Text) + 1);
            else label8.Text = Convert.ToString(Convert.ToInt32(label8.Text) + 1);
            if (wnr == "X") label1.Text = textBox2.Text + " Won";
            else label1.Text = textBox3.Text + " Won";
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
        bool drawcheck()
        {
            if (won == 0 && button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" &&
                button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" &&
                button9.Text != "") return true;
            else return false;
        }
        void draw()
        {
            label1.Text = "Game Drawn";
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
        bool adm = false;
        string sira, fp;
        int won = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                textBox1.Visible = true;
                button11.Visible = true;
                if (adm == true)
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    button12.Visible = true;
                    label4.Visible = true;
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                }
            }
            else
            {
                textBox1.Visible = false;
                button11.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                button12.Visible = false;
                label4.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="pass123")
            {
                adm = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                button12.Visible = true;
                label4.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            adm = false;
            textBox1.Text = "";
            textBox1.Visible = false;
            button11.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button12.Visible = false;
            label4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            won = 0;
            button14.Visible = true;
            label7.Visible=true;
            label8.Visible = true;
            label5.Text = textBox2.Text;
            label6.Text = textBox3.Text;
            if (radioButton2.Checked == true)
            {
                label1.Text = textBox2.Text + "'s Turn";
                sira = "X";
                fp = "X";
            }
            else if (radioButton3.Checked == true)
            {
                label1.Text = textBox3.Text + "'s Turn";
                sira = "O";
                fp = "O";
            }
            else
            {
                if(fp=="X")
                {
                    fp = "O";
                    sira = "O";
                    label1.Text = textBox3.Text + "'s Turn";
                }
                else
                {
                    fp = "X";
                    sira = "X";
                    label1.Text = textBox2.Text + "'s Turn";
                }
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label7.Text = "0";
            label8.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="")
            {
                button1.Text = sira;
                if (sira == "X") sira = "O";
                else sira = "X";
                if (wincheck() == "X") win("X");
                if (wincheck() == "O") win("O");
                if (won == 0)
                {
                    if (sira == "X") label1.Text = textBox2.Text + "'s Turn";
                    else label1.Text = textBox3.Text + "'s Turn";
                }
                if (drawcheck() == true) draw();
            }
        }
    }
}
