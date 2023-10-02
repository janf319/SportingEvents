using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jan_SportingEventsApp
{
    public partial class Form1 : Form
    {
        private string[] sports = { "Skiing", "Baseball", "Basketball",
                                    "Football", "Soccer" };
        private string[] sportsMessage = {"Remember to Dress Warmly",
            "BaseBall Begins in June", "This class will take place indoors",
            "Helmet is required for this class", "Physicals are due Aug 1st" };
        public Form1()
        {
            
            InitializeComponent();
            
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Skiing.Visible = true;
                BaseBall.Visible = false;
                BasketBall.Visible = false;
                football.Visible = false;
                Soccer.Visible = false;
                label6.Text = sportsMessage[0];
            }
            else if (radioButton2.Checked)
            {
                Skiing.Visible = false;
                BaseBall.Visible = true;
                BasketBall.Visible = false;
                football.Visible = false;
                Soccer.Visible = false;
                label6.Text = sportsMessage[1];
            }
            else if (radioButton3.Checked)
            {
                Skiing.Visible = false;
                BaseBall.Visible = false;
                BasketBall.Visible = true;
                football.Visible = false;
                Soccer.Visible = false;
                label6.Text = sportsMessage[2];
            }
            else if (radioButton4.Checked)
            {
                Skiing.Visible = false;
                BaseBall.Visible = false;
                BasketBall.Visible = false;
                football.Visible = true;
                Soccer.Visible = false;
                label6.Text = sportsMessage[3];
            }
            else if (radioButton4.Checked)
            {
                Skiing.Visible = false;
                BaseBall.Visible = false;
                BasketBall.Visible = false;
                football.Visible = false;
                Soccer.Visible = true;
                label6.Text = sportsMessage[4];
            }
            else 
            {
                Skiing.Visible = false;
                BaseBall.Visible = false;
                BasketBall.Visible = false;
                football.Visible = false;
                Soccer.Visible = false;
                label6.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;
            
        }
    }
}
