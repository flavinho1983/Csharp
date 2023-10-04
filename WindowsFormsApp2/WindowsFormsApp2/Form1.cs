using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "flavio"  && textBox2.Text == "123") 
            { 
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Login ou senha errados!");
            }

        }
        
        

    
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
