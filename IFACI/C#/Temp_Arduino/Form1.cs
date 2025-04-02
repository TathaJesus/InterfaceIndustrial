using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;

namespace Temp_Arduino
{
    public partial class Termômetro : Form
    {
        public Termômetro()
        {
            InitializeComponent();//Inicializa componentes do formulário
        }
        private void lerTemperatura(object sender, EventArgs e)
        {
            byte[] dados = new byte[2];//Buffer para dados (não utilizados)
            string valor; //Váriavel para armazenamento de leitura
            valor = serialPort1.ReadExisting();//Lê todos os dados que serão disponibilizados pela porta serial
            if (valor != "")//Se recebeu dados
            {
                thermControl1.UpdateControl(Convert.ToInt32(valor));//Atualiza controle de temperatura

                //Limpa buffer da porta serial
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
        
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemperatura));//Chama ler temperatura na thread da UI
        }
        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (txPorta.Text != "")//Verifica se foi informado uma porta
                serialPort1.PortName = txPorta.Text;//Configura a porta serial que foi informada
            if (!serialPort1.IsOpen)
                serialPort1.Open();//Abre a conexão serial
        }
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();//Fecha a conexão serial

            Application.Exit();//Encerra a aplicação
        }
    }
}
