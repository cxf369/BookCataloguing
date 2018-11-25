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
using System.Diagnostics;
namespace BookCataloguing
{
    public partial class Form2 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader Dr1;

        

        public void getauthrat()


        {
           
            
            con.Open();
             String b = label8.Text;

            string syntax = "SELECT a.authname, r.rating FROM authors a, rating r WHERE a.bid="+b+" and r.bid="+b;
            cmd = new SqlCommand(syntax, con);
            
            
                Dr1 = cmd.ExecuteReader();
                Dr1.Read();
                
            
           // catch(Exception e)
           // {
              //  MessageBox.Show("sql injection error");
            //}
            label3.Text = Dr1[0].ToString();
            label4.Text = Dr1[1].ToString();
            con.Close();
            // syntax = "";
        }

        public Form2()
        {
            InitializeComponent();
        }

       public void img()
        {
            string a = label7.Text;
            pictureBox1.ImageLocation = a;
            
        }
       public int Readevent(string loc)
        {
            if (loc.Length < 10)
            {
                MessageBox.Show(loc);
                return 0;
            }
            else return 1;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.database1DataSet.location);

            // TODO: This line of code loads data into the 'database1DataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database1DataSet.book);
           
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();

            String b = label8.Text;
            string syntax = "SELECT buylink FROM link WHERE bid="+b;
            cmd = new SqlCommand(syntax, con);
            Dr1 = cmd.ExecuteReader();
            Dr1.Read();
            Process.Start(Dr1[0].ToString());
            
            con.Close();

        }

        

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            img();
            getauthrat();
            Dr1.Equals("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataReader Dr1;
            con.Open();

            String bidlink = label8.Text;
            string syntax = "SELECT location FROM location WHERE bid=" + bidlink;
            cmd = new SqlCommand(syntax, con);
            Dr1 = cmd.ExecuteReader();
            Dr1.Read();
            string loc = Dr1[0].ToString();
            loc.Trim();
            int a = Readevent(loc);
            if (a == 1)
            {
                Process.Start(Dr1[0].ToString());
            }
            con.Close();
            return;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
