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
    public partial class Form2 : Form
    {
        internal Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 frm)
        {
            InitializeComponent();  //without this, there will show no component on the form.
            frm1 = frm;
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

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.masterDataSet.Table1);

        }
    }
}
