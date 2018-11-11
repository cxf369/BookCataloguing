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
    public partial class Form2 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
     
        public void getauthrat()


        {
            con.Open();
             String b = label8.Text;

            string syntax = "SELECT a.authname, r.rating FROM authors a, rating r WHERE a.bid="+b+" and r.bid="+b;
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label3.Text = dr[0].ToString();
            label4.Text = dr[1].ToString();
            con.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

       public void img(object sender, EventArgs e)
        {
            string a = label7.Text;
            pictureBox1.ImageLocation = a;
            getauthrat();
        }
       
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database1DataSet.book);
           
           

        }
    }
}
