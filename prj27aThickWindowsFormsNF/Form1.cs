using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj27aThickWindowsFormsNF
{
    public partial class Form1 : Form
    {
        private int ct = 0;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ct++;
            textBox1.Text = ct.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var frm2 = new Form2();   
            Form2 frm2 = new Form2(this);
            frm2.Show();
            this.Hide();
        }
    }
}
