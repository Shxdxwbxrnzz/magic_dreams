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
        private void playbutton_Click(object sender, EventArgs e)
        {
            coins.Visible = true;
            health.Visible = true;
            power.Visible = true;
            playbutton.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            CNP.Visible = true;
            PWP.Visible = true;
            HPP.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hp = 100;
            cns = 10;
            pwr = 25;

        }
        private void button2_Click(object sender, EventArgs e)
        {

            hp -= 10;
            cns -= 5;
            pwr -= 7;


            UpdateStats();
        }

        private void UpdateStats()
        {
            if (hp <= 0)
            {
                hp = 0;
            }

            health.Text = hp.ToString();
            coins.Text = cns.ToString();
            power.Text = pwr.ToString();
        }



        private void health_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playbutton_MouseEnter(object sender, EventArgs e)
        {
            playbutton.Cursor = Cursors.Hand;
        }

        private void playbutton_MouseLeave(object sender, EventArgs e)
        {
            playbutton.Cursor = Cursors.Default;
        }
    }
}
