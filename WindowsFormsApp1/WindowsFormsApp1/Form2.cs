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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();// abre o formulario novo
            frm.Show();// aparece o formulário
            this.Hide();//esconde a tela anterior
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();// abre o formulario novo
            frm.Show();// aparece o formulário
            this.Hide();//esconde a tela anterior
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();// abre o formulario novo
            frm.Show();// aparece o formulário
            this.Hide();//esconde a tela anterior

        }
    }
}
