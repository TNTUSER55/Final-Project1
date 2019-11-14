using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double salery = double.Parse(SaleryBox.Text);
                groupBox2.Visible = false;
                groupBox1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string[] name = {};
            string[] job = {};
            name[counter] = textBox1.Text;
            if (radioButton1.Checked)
            {
                job[counter] = "Lawyer";
            }
            else if (radioButton2.Checked)
            {
                job[counter] = "Personal Assistant";
            }
            else if (radioButton3.Checked)
            {
                job[counter] = "Agent";
            }
            else if (   radioButton4.Checked)
            {
                job[counter] = "Trainer";
            }

            listBox1.Items.Add(name[counter] + ": " + job[counter]);

        }
    }
}
