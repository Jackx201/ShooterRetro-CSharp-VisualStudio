using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Text = "~ SPACE ~\n~SURVIVAL~";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Survive Survive = new Survive();
            Survive.Show(this);
            this.Hide();
        }




    }
}
