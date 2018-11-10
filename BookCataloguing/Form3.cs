using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCataloguing
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.database1DataSet.genre);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
