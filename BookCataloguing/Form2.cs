﻿using System;
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
    public partial class Form2 : Form
    {
        

        
        public Form2()
        {
            InitializeComponent();
        }

       public void img(object sender, EventArgs e)
        {
            string a = label7.Text;
            pictureBox1.ImageLocation = a;
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
