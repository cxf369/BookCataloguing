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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        public Form5()
        {
            InitializeComponent();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.awards' table. You can move, or remove it, as needed.
            this.awardsTableAdapter.Fill(this.database1DataSet.awards);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("awd_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@awards", comboBox1.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<<INVALID SQL OPERATION>>> \n" + ex);

                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;




            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
