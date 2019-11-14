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
        string[] name = new string[5000];
        string[] job = new string[5000];
        public Form1()
        {
            InitializeComponent();
            if(counter >= 5000)
            {
                MessageBox.Show("From this point on this application will not run due to way too many people in the fields. Please delete some to contune use.");
            }
            
        }
        private string[] removeItemFromArray(int RemoveAt, string[] IndicesArray)
        {
            string[] newIndicesArray = new string[IndicesArray.Length - 1];

            int i = 0;
            int j = 0;
            while (i < IndicesArray.Length)
            {
                if (i != RemoveAt)
                {
                    newIndicesArray[j] = IndicesArray[i];
                    j++;
                }

                i++;
            }

            return newIndicesArray;
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
            
            name[counter] = textBox1.Text;
            if (radioButton1.Checked)
            {
                job[counter] = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                job[counter] = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                job[counter] = radioButton3.Text;
            }
            if(radioButton4.Checked)
            {
                job[counter] = radioButton4.Text;
            }
            try
            {
                listBox1.Items.Add(name[counter] + ": " + job[counter]);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Please enter a job");
            }
            ++counter;

            
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedIndex.ToString());
            removeItemFromArray(listBox1.SelectedIndex, name);
            removeItemFromArray(listBox1.SelectedIndex, job);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
