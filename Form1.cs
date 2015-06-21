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

namespace rejestracja_wizyt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fillcombo();
        }

        private void specjalizacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Specjalizacja s = new Specjalizacja();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursDataSet.Lekarz' table. You can move, or remove it, as needed.
            this.lekarzTableAdapter.Fill(this.kursDataSet.Lekarz);
            // TODO: This line of code loads data into the 'kursDataSet.Specjalizacja' table. You can move, or remove it, as needed.
            this.specjalizacjaTableAdapter.Fill(this.kursDataSet.Specjalizacja);

        }
        void Fillcombo()
        {
            SqlConnection con = new SqlConnection(@"Data Source=WIN-LIH4U0O24UN;Initial Catalog=Kurs;Integrated Security=True");
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select nazwa from Specjalizacja ", con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                comboBox2.Items.Add((string)myReader["nazwa"]);
            }
            myReader.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
    //        System.Data.SqlClient.SqlConnection sqlConnection1 =
    //new System.Data.SqlClient.SqlConnection(@"Data Source=WIN-LIH4U0O24UN;Initial Catalog=Kurs;Integrated Security=True");
    //        sqlConnection1.Open();
    //        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
    //        cmd.CommandType = System.Data.CommandType.Text;
    //        cmd.CommandText = "insert into Lekarz (imie, nazwisko, id_specjalizacja) values ('" + textBox1.Text + "' + '" + textBox2.Text + "'+ '"+ comboBox2.Text +"')";
    //        cmd.Connection = sqlConnection1;

    //        cmd.ExecuteNonQuery();
    //        sqlConnection1.Close();
        }
    }
}
