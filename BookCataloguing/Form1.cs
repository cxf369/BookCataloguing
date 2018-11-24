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
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        Form7 f7 = new Form7();
        Form8 f8 = new Form8();
        Form9 f9 = new Form9();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                f2.ShowDialog();
            }
            catch(Exception exception)
            {
                new Form2().ShowDialog();
            }
           

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                f3.ShowDialog();
            }
            catch (Exception exceptio)
            {
                new Form3().ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                f4.ShowDialog();
            }
            catch (Exception exceptin)
            {
                new Form4().ShowDialog();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                f5.ShowDialog();
            }
            catch (Exception excepton)
            {
                new Form5().ShowDialog();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                f6.ShowDialog();
            }
            catch (Exception exception)
            {
                new Form6().ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                f8.ShowDialog();
            }
            catch (Exception xceptio)
            {
                new Form8().ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                f9.ShowDialog();
            }
            catch (Exception xceptio)
            {
                new Form9().ShowDialog();
            }
        }
    }
}
