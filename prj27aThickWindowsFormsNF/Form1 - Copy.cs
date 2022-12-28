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
            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            // Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;

            //Trusted Connection:
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("DB connection open!");
            cnn.Close();
        }
    }
}
