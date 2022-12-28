using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj27aThickWindowsFormsNF
{
    public partial class Form3 : Form
    {
        internal Form2 frm2;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2 frm)
        {
            InitializeComponent();
            frm2 = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.masterDataSet.Table1);

        }
    }
}
