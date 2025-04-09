namespace ATIVIDADE4_Interface
{
    partial class Atividade4
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnEmergencia = new System.Windows.Forms.Button();
            this.timerEnchimento = new System.Windows.Forms.Timer(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxTanque = new System.Windows.Forms.PictureBox();
            this.timerEsvaziamento = new System.Windows.Forms.Timer(this.components);
            this.lblNivelTanque = new System.Windows.Forms.Label();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.btnBlocoNotas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.progressNivelTanque = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanque)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 298);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(56, 76);
            this.btnLigar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(104, 47);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(56, 146);
            this.btnDesligar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(104, 47);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnEmergencia
            // 
            this.btnEmergencia.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencia.Location = new System.Drawing.Point(56, 212);
            this.btnEmergencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmergencia.Name = "btnEmergencia";
            this.btnEmergencia.Size = new System.Drawing.Size(104, 47);
            this.btnEmergencia.TabIndex = 3;
            this.btnEmergencia.Text = "Emergência";
            this.btnEmergencia.UseVisualStyleBackColor = true;
            this.btnEmergencia.Click += new System.EventHandler(this.btnEmergencia_Click);
            // 
            // timerEnchimento
            // 
            this.timerEnchimento.Tick += new System.EventHandler(this.timerEnchimento_Tick);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(10, 327);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(66, 19);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(231, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 23);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Controle do nível de tanque";
            // 
            // pictureBoxTanque
            // 
            this.pictureBoxTanque.InitialImage = null;
            this.pictureBoxTanque.Location = new System.Drawing.Point(245, 76);
            this.pictureBoxTanque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxTanque.Name = "pictureBoxTanque";
            this.pictureBoxTanque.Size = new System.Drawing.Size(139, 211);
            this.pictureBoxTanque.TabIndex = 4;
            this.pictureBoxTanque.TabStop = false;
            this.pictureBoxTanque.Click += new System.EventHandler(this.pictureBoxTanque_Click);
            // 
            // timerEsvaziamento
            // 
            this.timerEsvaziamento.Tick += new System.EventHandler(this.timerEsvaziamento_Tick);
            // 
            // lblNivelTanque
            // 
            this.lblNivelTanque.AutoSize = true;
            this.lblNivelTanque.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelTanque.Location = new System.Drawing.Point(242, 35);
            this.lblNivelTanque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivelTanque.Name = "lblNivelTanque";
            this.lblNivelTanque.Size = new System.Drawing.Size(88, 18);
            this.lblNivelTanque.TabIndex = 7;
            this.lblNivelTanque.Text = "Nível do Tanque:";
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Location = new System.Drawing.Point(470, 76);
            this.btnCalculadora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(104, 47);
            this.btnCalculadora.TabIndex = 8;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(467, 392);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(45, 18);
            this.lblDataHora.TabIndex = 9;
            this.lblDataHora.Text = "Horário";
            this.lblDataHora.Click += new System.EventHandler(this.lblDataHora_Click);
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            this.timerDataHora.Interval = 1000;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // btnBlocoNotas
            // 
            this.btnBlocoNotas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlocoNotas.Location = new System.Drawing.Point(470, 146);
            this.btnBlocoNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBlocoNotas.Name = "btnBlocoNotas";
            this.btnBlocoNotas.Size = new System.Drawing.Size(104, 47);
            this.btnBlocoNotas.TabIndex = 10;
            this.btnBlocoNotas.Text = "Bloco de Notas";
            this.btnBlocoNotas.UseVisualStyleBackColor = true;
            this.btnBlocoNotas.Click += new System.EventHandler(this.btnBlocoNotas_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(470, 212);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 47);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(10, 359);
            this.lblMaximo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(79, 19);
            this.lblMaximo.TabIndex = 12;
            this.lblMaximo.Text = "Nivel Maximo";
            this.lblMaximo.Click += new System.EventHandler(this.lblMaximo_Click);
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(10, 392);
            this.lblMinimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(76, 19);
            this.lblMinimo.TabIndex = 13;
            this.lblMinimo.Text = "Nivel Minimo";
            this.lblMinimo.Click += new System.EventHandler(this.lblMinimo_Click);
            // 
            // progressNivelTanque
            // 
            this.progressNivelTanque.Location = new System.Drawing.Point(246, 58);
            this.progressNivelTanque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressNivelTanque.Name = "progressNivelTanque";
            this.progressNivelTanque.Size = new System.Drawing.Size(133, 19);
            this.progressNivelTanque.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressNivelTanque.TabIndex = 14;
            this.progressNivelTanque.Click += new System.EventHandler(this.progressNivelTanque_Click);
            // 
            // Atividade4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(634, 422);
            this.Controls.Add(this.progressNivelTanque);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnBlocoNotas);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.lblNivelTanque);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pictureBoxTanque);
            this.Controls.Add(this.btnEmergencia);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Atividade4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade 4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnEmergencia;
        private System.Windows.Forms.PictureBox pictureBoxTanque;
        private System.Windows.Forms.Timer timerEnchimento;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer timerEsvaziamento;
        private System.Windows.Forms.Label lblNivelTanque;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Button btnBlocoNotas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.ProgressBar progressNivelTanque;
    }
}

