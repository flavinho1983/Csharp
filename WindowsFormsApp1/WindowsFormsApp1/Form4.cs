using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Acender")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                button3.Text = "Apagar";
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                button3.Text = "Acender";

            }
        }
    }
}
