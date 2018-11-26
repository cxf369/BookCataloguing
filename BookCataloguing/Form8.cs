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
            try
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
                cmd.Parameters.AddWithValue("@authimgurl", textBox7.Text);
                cmd.Parameters.AddWithValue("@authname", textBox6.Text);
                cmd.Parameters.AddWithValue("@awards", textBox5.Text);
                cmd.Parameters.AddWithValue("@gname", textBox3.Text);
                cmd.Parameters.AddWithValue("@agepref", textBox13.Text);
                cmd.Parameters.AddWithValue("@buylink", textBox12.Text);
                cmd.Parameters.AddWithValue("@location", textBox11.Text);
                //  cmd.Parameters.AddWithValue("@", maskedTextBox13.Text);
                //  cmd.Parameters.AddWithValue("@rating", maskedTextBox13.Text);
                float rat = float.Parse(textBox2.Text);
                if (rat > 5)
                {
                    MessageBox.Show("ENTER RATING LESS THAN 5");
                }

                con.Open();
                try
                {
                    if (rat > 5)
                    {
                        // Form8 f8 = new Form8();
                        MessageBox.Show("ENTER RATING LESS THAN 5");

                        new Form8().ShowDialog();
                        this.Close();
                        return;
                    }
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<<<INVALID SQL OPERATION>>>\n" + ex);
                }
                con.Close();
            }
            catch(Exception te)
            {
                MessageBox.Show("Enter the details properly");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
