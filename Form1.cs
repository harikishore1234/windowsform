using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegateconcepts_windows_form
{
    public delegate void sampleapplications(int firstnumber, int secondnumber);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creating first method
        public void summethod(int firstnumber,int secondnumber)
        {
            int resultvalue = firstnumber + secondnumber;
            MessageBox.Show("sumvalue:" + resultvalue);
        }
        // creating second method 
        public void multiplicationmethod(int firstnumber, int secondnumber)
        {
            int resultvalue = firstnumber * secondnumber;
            MessageBox.Show("mulvalue:" + resultvalue);
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            // assigning methods to delegates
            sampleapplications s = new sampleapplications(summethod);
            s += multiplicationmethod;
            // calling delegate
            s(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
