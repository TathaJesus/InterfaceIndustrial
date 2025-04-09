using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AtividadeControleDeTrafego
{
    public partial class Form1 : Form
    {
        private bool sistemaLigado = false;
        private bool emergenciaAtiva = false;
        private int estadoSemaforo = 0;
        private DateTime tempoEstado;

        public Form1()
        {
            InitializeComponent();
            InicializarTimers();
            ConfigurarBotoes();
            AtualizarDataHora();
            DesligarSemaforos();
        }

        private void InicializarTimers()
        {
            timerDataHora.Tick += timerDataHora_Tick;
            timerDataHora.Start();
            timerSemaforo.Tick += timerSemaforo_Tick;
        }

        private void ConfigurarBotoes()
        {
            btnLiga.BackColor = sistemaLigado ? Color.Lime : Color.Silver;
            btnDesliga.BackColor = sistemaLigado ? Color.Silver : Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarDataHora();
        }

        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            if (!sistemaLigado)
            {
                MessageBox.Show("O sistema precisa estar ligado para ativar a emergência!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AtivarModoEmergencia();
        }

        private void AtivarModoEmergencia()
        {
            emergenciaAtiva = true;
            timerSemaforo.Stop();
            MessageBox.Show("Protocolo de emergência ativado! Todos os semáforos ficarão amarelos por 10 segundos.", "Emergência", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            AtivarTodosAmarelos();
            IniciarTimerEmergencia();
        }

        private void AtivarTodosAmarelos()
        {
            AvRed.BackColor = Color.Maroon;
            AvYellow.BackColor = Color.Yellow;
            AvGreen.BackColor = Color.Green;
            RuaRed.BackColor = Color.Maroon;
            RuaYellow.BackColor = Color.Yellow;
            RuaGreen.BackColor = Color.Green;
        }

        private void IniciarTimerEmergencia()
        {
            timerEmergencia.Interval = 10000;
            timerEmergencia.Tick += (s, ev) => {
                FinalizarEmergencia();
                timerEmergencia.Stop();
            };
            timerEmergencia.Start();
        }

        private void FinalizarEmergencia()
        {
            emergenciaAtiva = false;
            if (sistemaLigado)
            {
                timerSemaforo.Start();
                tempoEstado = DateTime.Now;
            }
            MessageBox.Show("Emergência desativada. Sistema retomando operação normal.", "Emergência", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLiga_Click(object sender, EventArgs e)
        {
            if (sistemaLigado)
            {
                MessageBox.Show("O sistema já está ligado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LigarSistema();
        }

        private void LigarSistema()
        {
            sistemaLigado = true;
            estadoSemaforo = 0;
            tempoEstado = DateTime.Now;
            timerSemaforo.Start();
            ConfigurarBotoes();
            MessageBox.Show("Sistema ligado com sucesso!", "Ligar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarSemaforo();
        }

        private void btnDesliga_Click(object sender, EventArgs e)
        {
            if (!sistemaLigado)
            {
                MessageBox.Show("O sistema já está desligado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ConfirmarDesligamento();
        }

        private void ConfirmarDesligamento()
        {
            DialogResult result = MessageBox.Show("Deseja realmente desligar o sistema?", "Desligar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DesligarSistema();
            }
        }

        private void DesligarSistema()
        {
            sistemaLigado = false;
            timerSemaforo.Stop();
            ConfigurarBotoes();
            MessageBox.Show("Sistema desligado!", "Desligado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesligarSemaforos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConfirmarSaida();
        }

        private void ConfirmarSaida()
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLinkPolicia_Click(object sender, EventArgs e)
        {
            AbrirSitePolicia();
        }

        private void AbrirSitePolicia()
        {
            try
            {
                Process.Start("https://www.policiamilitar.sp.gov.br/");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o site: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDataHora_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Data e Hora Atual: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", "Data/Hora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            AtualizarDataHora();
        }

        private void timerSemaforo_Tick(object sender, EventArgs e)
        {
            VerificarMudancaEstado();
        }

        private void VerificarMudancaEstado()
        {
            TimeSpan tempoDecorrido = DateTime.Now - tempoEstado;
            bool mudarEstado = false;

            switch (estadoSemaforo)
            {
                case 0: mudarEstado = tempoDecorrido.TotalSeconds >= 3; break; // Avenida Verde (3s)
                case 1: mudarEstado = tempoDecorrido.TotalSeconds >= 2; break; // Avenida Amarelo (1s)
                case 2: mudarEstado = tempoDecorrido.TotalSeconds >= 3; break; // Rua Verde (3s)
                case 3: mudarEstado = tempoDecorrido.TotalSeconds >= 2; break; // Rua Amarelo (1s)
            }

            if (mudarEstado)
            {
                estadoSemaforo = (estadoSemaforo + 1) % 4;
                tempoEstado = DateTime.Now;
                AtualizarSemaforo();
            }
        }

        private void AtualizarDataHora()
        {
            lblDataHora.Text = $"Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        private void AtualizarSemaforo()
        {
            if (!sistemaLigado || emergenciaAtiva) return;

            ResetarCoresSemaforos();

            switch (estadoSemaforo)
            {
                case 0: // Rua Vermelho / Avenida Verde
                    RuaRed.BackColor = Color.Red;
                    AvGreen.BackColor = Color.Lime;
                    break;
                case 1: // Rua Vermelho / Avenida Amarelo
                    RuaRed.BackColor = Color.Red;
                    AvYellow.BackColor = Color.Yellow;
                    break;
                case 2: // Rua Verde / Avenida Vermelho
                    RuaGreen.BackColor = Color.Lime;
                    AvRed.BackColor = Color.Red;
                    break;
                case 3: // Rua Amarelo / Avenida Vermelho
                    RuaYellow.BackColor = Color.Yellow;
                    AvRed.BackColor = Color.Red;
                    break;
            }
        }

        private void ResetarCoresSemaforos()
        {
            AvRed.BackColor = Color.Maroon;
            AvYellow.BackColor = Color.Olive;
            AvGreen.BackColor = Color.Green;
            RuaRed.BackColor = Color.Maroon;
            RuaYellow.BackColor = Color.Olive;
            RuaGreen.BackColor = Color.Green;
        }

        private void DesligarSemaforos()
        {
            AvRed.BackColor = Color.DarkRed;
            AvYellow.BackColor = Color.Olive;
            AvGreen.BackColor = Color.DarkGreen;
            RuaRed.BackColor = Color.DarkRed;
            RuaYellow.BackColor = Color.Olive;
            RuaGreen.BackColor = Color.DarkGreen;
        }
    }
}