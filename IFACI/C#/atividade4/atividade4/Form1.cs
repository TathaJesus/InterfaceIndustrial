using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ATIVIDADE4_Interface
{
    public partial class Atividade4 : Form
    {
        private int nivelTanque = 0;

        public Atividade4()
        {
            InitializeComponent();
        }

        private void AtualizarNivelTanque()
        {
            lblNivelTanque.Text = $"Nível do Tanque: {nivelTanque}%";
            progressNivelTanque.Value = nivelTanque; 
            AtualizarSensores(); 
        }

        private void AtualizarTanque()
        {
            lblNivelTanque.Text = $"Nível do Tanque: {nivelTanque}%";
        }

        private void AtualizarSensores()
        {
            if (nivelTanque >= 100)
            {
                lblMaximo.ForeColor = Color.Green;
                lblMaximo.Text = "🔵 Nível Máximo";
            }
            else
            {
                lblMaximo.ForeColor = Color.Gray; 
                lblMaximo.Text = "⚪ Nível Máximo";
            }

            if (nivelTanque <= 0)
            {
                lblMinimo.ForeColor = Color.Red;
                lblMinimo.Text = "🔴 Nível Mínimo";
            }
            else
            {
                lblMinimo.ForeColor = Color.Gray; 
                lblMinimo.Text = "⚪ Nível Mínimo";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerDataHora.Start(); 
        }

        private void pictureBoxTanque_Click(object sender, EventArgs e)
        {

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            pictureBoxTanque.Image = Properties.Resources.Tanque_de_Mistura_On2;
            lblStatus.Text = "Ligado";
            lblStatus.ForeColor = Color.Green;

            lblMensagem.Text = "Tanque ativado com sucesso.";
            lblMensagem.ForeColor = Color.Blue;

            timerEsvaziamento.Stop(); 
            timerEnchimento.Start();  

            MessageBox.Show("O sistema foi ligado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnDesligar_Click(object sender, EventArgs e)
        {
            pictureBoxTanque.Image = Properties.Resources.Tanque_de_Mistura_Off2;
            lblStatus.Text = "Desligado";
            lblStatus.ForeColor = Color.Red;

            lblMensagem.Text = "Tanque desligado.";
            lblMensagem.ForeColor = Color.Gray;

            timerEnchimento.Stop();   
            timerEsvaziamento.Start(); 

            MessageBox.Show("O sistema foi desligado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            pictureBoxTanque.Image = Properties.Resources.Tanque_de_Mistura_Off2;
            lblStatus.Text = "EMERGÊNCIA!";
            lblStatus.ForeColor = Color.DarkRed;

            lblMensagem.Text = "ERRO! Emergência ativada.";
            lblMensagem.ForeColor = Color.DarkRed;

            timerEnchimento.Stop();    
            timerEsvaziamento.Stop();  

            MessageBox.Show("Emergência acionada! O sistema foi desligado por segurança.", "Emergência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblDataHora_Click(object sender, EventArgs e)
        {

        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou no título!");
        }

        private void timerEnchimento_Tick(object sender, EventArgs e)
        {
            if (nivelTanque < 100)
            {
                nivelTanque += 2; 
                lblNivelTanque.Text = $"Nível do Tanque: {nivelTanque}%";
                AtualizarSensores();
                AtualizarNivelTanque();
            }
            else
            {
                timerEnchimento.Stop(); 
            }
        }

        private void timerEsvaziamento_Tick(object sender, EventArgs e)
        {
            if (nivelTanque > 0)
            {
                nivelTanque -= 2; 
                lblNivelTanque.Text = $"Nível do Tanque: {nivelTanque}%";
                AtualizarSensores();
                AtualizarNivelTanque();
            }
            else
            {
                timerEsvaziamento.Stop(); 
            }
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("calc"); 
        }
        private void btnBlocoNotas_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void lblMaximo_Click(object sender, EventArgs e)
        {

        }

        private void lblMinimo_Click(object sender, EventArgs e)
        {

        }

        private void progressNivelTanque_Click(object sender, EventArgs e)
        {

        }
    }
}