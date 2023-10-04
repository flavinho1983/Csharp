using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "flavio" && textBox2.Text == "123") //condição de login e senha
            {
                Form2 frm = new Form2(); // abre o formulario novo
                frm.Show(); // aparece o formulário
                this.Hide(); //esconde a tela anterior
            }
            else
            {
                MessageBox.Show("Login ou senha errados!"); // senão da negativa de splashscreen
            }
            




        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
