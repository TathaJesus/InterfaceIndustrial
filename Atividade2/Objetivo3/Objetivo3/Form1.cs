using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objetivo3
{
    public partial class Form1 : Form
    {
        private bool ligado = false;
        public Form1()
        {
            InitializeComponent();
            AtualizarInterface();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ligado = true;
            AtualizarInterface();
            textBox1.Text = "Sistema ligado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ligado = false;
            AtualizarInterface();
            textBox1.Text = "Sistema desligado";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void AtualizarInterface()
        {
            if (ligado)
            {
                pictureBox1.Image = Image.FromFile(@"C:/imagens/verde.bmp"); // Bitmap da imagem verde
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:/imagens/vermelho.bmp"); // Bitmap da imagem vermelha
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
