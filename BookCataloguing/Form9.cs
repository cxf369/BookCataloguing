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

namespace BookCataloguing
{
    public partial class Form9 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader Dr1;

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.database1DataSet.book);
            // TODO: This line of code loads data into the 'database1DataSet1.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database1DataSet1.book);
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("delete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@bid", label3.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("  <<<<<<<INVALID SQL OPERATION\n" + ex);
                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            this.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
