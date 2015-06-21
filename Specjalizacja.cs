using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rejestracja_wizyt
{
    public partial class Specjalizacja : Form
    {
        
        public Specjalizacja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
    new System.Data.SqlClient.SqlConnection(@"Data Source=WIN-LIH4U0O24UN;Initial Catalog=Kurs;Integrated Security=True");
            sqlConnection1.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Specjalizacja (Nazwa) values ('" + textBox1.Text + "')";
            cmd.Connection = sqlConnection1;

            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}
