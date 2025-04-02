using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objetivo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLiga_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O sistema foi ligado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDesliga_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O sistema foi desligado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ocorreu um erro no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
