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

namespace BookCataloguing
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bid", textBox14.Text);
            cmd.Parameters.AddWithValue("@bname", textBox1.Text);
            cmd.Parameters.AddWithValue("@bimgurl", textBox4.Text);
            cmd.Parameters.AddWithValue("@bpub", textBox9.Text);
            cmd.Parameters.AddWithValue("@bpubyr", textBox10.Text);
            cmd.Parameters.AddWithValue("@breview", textBox8.Text);
            cmd.Parameters.AddWithValue("@rating", textBox2.Text);

            cmd.Parameters.AddWithValue("@authname", textBox6.Text);
            cmd.Parameters.AddWithValue("@awards", textBox5.Text);
            cmd.Parameters.AddWithValue("@gname", textBox3.Text);
            cmd.Parameters.AddWithValue("@agepref", textBox13.Text);
            cmd.Parameters.AddWithValue("@buylink", textBox12.Text);
            cmd.Parameters.AddWithValue("@location", textBox11.Text);
          //  cmd.Parameters.AddWithValue("@", maskedTextBox13.Text);
          //  cmd.Parameters.AddWithValue("@rating", maskedTextBox13.Text);


            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("    <<<<<INVALID SQL OPERATION>>>\n" + ex);
            }
            con.Close();
        }
    }
}
