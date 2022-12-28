using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prj27bThickWpfNF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string connetionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        SqlConnection con = new SqlConnection(connetionString);
        //con.Open();
        public MainWindow()
        {
            InitializeComponent();
        }    

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        { 
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();    
            String sql = "INSERT INTO Table1 (name, salary) VALUES ('Jen2', 22222);";
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            //ExecuteNonQuery is used in C# to issue any DML: insert, delete, and update operation..

            con.Close();
            MessageBox.Show("INSERT done!");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "delete Table1 where name ='Jen2';";          
            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.ExecuteNonQuery();      
            con.Close();
            MessageBox.Show("Delete done!");
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            con.Open(); 
            SqlDataAdapter adapter = new SqlDataAdapter();     
            String sql = "UPDATE Table1 SET name = 'Nancy3', salary= 33333  WHERE name='Jen2';";            
            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();       
            con.Close();
            MessageBox.Show("Update done!");
        }
    }
}
