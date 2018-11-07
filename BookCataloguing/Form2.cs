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

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //if(! controlpanel.Controls.Contains(UserControlbooks.instance))
            //{
                controlpanel.Controls.Add(UserControlbooks.instance);
                UserControlbooks.instance.Dock = DockStyle.Fill;
                UserControlbooks.instance.BringToFront();
         //   }
           // else
           // {
           //     UserControlbooks.instance.BringToFront();
          //  }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
