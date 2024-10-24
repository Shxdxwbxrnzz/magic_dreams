using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form1 : Form
    {
        private int hp;
        private int cns;
        private int pwr;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            coins.Visible = true;
            health.Visible = true;
            power.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hp = 100;
            cns = 10;
            pwr = 25;
            health.Text = "Health: " + hp.ToString();
            coins.Text = "Coins: " + cns.ToString();
            power.Text = "Power: " + pwr.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            hp -= 10;
            cns -= 5;
            pwr -= 7;


            health.Text = "Health: " + hp.ToString();
            coins.Text = "Coins: " + cns.ToString();
            power.Text = "Power: " + pwr.ToString();


            if (hp <= 0)
            {
                health.Text = "Health: 0 (Game Over)";
            }
        }



        private void health_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
