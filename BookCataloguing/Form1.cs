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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlpanel.Controls.Add(UserControlbooks.instance);
            UserControlbooks.instance.Dock = DockStyle.Fill;
            UserControlbooks.instance.BringToFront();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            controlpanel.Controls.Add(UserControlbooks.instance);
            UserControlbooks.instance.Dock = DockStyle.Fill;
            UserControlbooks.instance.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database1DataSet.book);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
