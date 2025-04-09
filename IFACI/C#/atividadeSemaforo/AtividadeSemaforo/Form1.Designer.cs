namespace AtividadeControleDeTrafego
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.btnEmergencia = new System.Windows.Forms.Button();
            this.btnLiga = new System.Windows.Forms.Button();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLinkPolicia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AvRed = new System.Windows.Forms.Button();
            this.AvYellow = new System.Windows.Forms.Button();
            this.AvGreen = new System.Windows.Forms.Button();
            this.RuaRed = new System.Windows.Forms.Button();
            this.RuaYellow = new System.Windows.Forms.Button();
            this.RuaGreen = new System.Windows.Forms.Button();
            this.timerSemaforo = new System.Windows.Forms.Timer(this.components);
            this.timerEmergencia = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(259, 421);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(121, 25);
            this.lblDataHora.TabIndex = 0;
            this.lblDataHora.Text = "Data/Hora: ";
            this.lblDataHora.Click += new System.EventHandler(this.lblDataHora_Click);
            // 
            // timerDataHora
            // 
            this.timerDataHora.Interval = 1000;
            // 
            // btnEmergencia
            // 
            this.btnEmergencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmergencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmergencia.Location = new System.Drawing.Point(687, 392);
            this.btnEmergencia.Name = "btnEmergencia";
            this.btnEmergencia.Size = new System.Drawing.Size(178, 89);
            this.btnEmergencia.TabIndex = 1;
            this.btnEmergencia.Text = "Emergência";
            this.btnEmergencia.UseVisualStyleBackColor = false;
            this.btnEmergencia.Click += new System.EventHandler(this.btnEmergencia_Click);
            // 
            // btnLiga
            // 
            this.btnLiga.BackColor = System.Drawing.Color.Silver;
            this.btnLiga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLiga.Location = new System.Drawing.Point(30, 352);
            this.btnLiga.Name = "btnLiga";
            this.btnLiga.Size = new System.Drawing.Size(137, 66);
            this.btnLiga.TabIndex = 1;
            this.btnLiga.Text = "Ligar";
            this.btnLiga.UseVisualStyleBackColor = false;
            this.btnLiga.Click += new System.EventHandler(this.btnLiga_Click);
            // 
            // btnDesliga
            // 
            this.btnDesliga.BackColor = System.Drawing.Color.Gray;
            this.btnDesliga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesliga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesliga.Location = new System.Drawing.Point(30, 441);
            this.btnDesliga.Name = "btnDesliga";
            this.btnDesliga.Size = new System.Drawing.Size(137, 66);
            this.btnDesliga.TabIndex = 1;
            this.btnDesliga.Text = "Desligar";
            this.btnDesliga.UseVisualStyleBackColor = false;
            this.btnDesliga.Click += new System.EventHandler(this.btnDesliga_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Silver;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(30, 534);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(137, 66);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLinkPolicia
            // 
            this.btnLinkPolicia.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLinkPolicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkPolicia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLinkPolicia.Location = new System.Drawing.Point(687, 511);
            this.btnLinkPolicia.Name = "btnLinkPolicia";
            this.btnLinkPolicia.Size = new System.Drawing.Size(178, 89);
            this.btnLinkPolicia.TabIndex = 1;
            this.btnLinkPolicia.Text = "Site Polícia/Bombeiros";
            this.btnLinkPolicia.UseVisualStyleBackColor = false;
            this.btnLinkPolicia.Click += new System.EventHandler(this.btnLinkPolicia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AtividadeControleDeTrafego.Properties.Resources.SEMAFORO;
            this.pictureBox1.Location = new System.Drawing.Point(195, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 348);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AvRed
            // 
            this.AvRed.BackColor = System.Drawing.Color.DarkRed;
            this.AvRed.Location = new System.Drawing.Point(541, 61);
            this.AvRed.Name = "AvRed";
            this.AvRed.Size = new System.Drawing.Size(29, 27);
            this.AvRed.TabIndex = 3;
            this.AvRed.UseVisualStyleBackColor = false;
            // 
            // AvYellow
            // 
            this.AvYellow.BackColor = System.Drawing.Color.Olive;
            this.AvYellow.Location = new System.Drawing.Point(541, 94);
            this.AvYellow.Name = "AvYellow";
            this.AvYellow.Size = new System.Drawing.Size(29, 27);
            this.AvYellow.TabIndex = 3;
            this.AvYellow.UseVisualStyleBackColor = false;
            // 
            // AvGreen
            // 
            this.AvGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.AvGreen.Location = new System.Drawing.Point(541, 127);
            this.AvGreen.Name = "AvGreen";
            this.AvGreen.Size = new System.Drawing.Size(29, 27);
            this.AvGreen.TabIndex = 3;
            this.AvGreen.UseVisualStyleBackColor = false;
            // 
            // RuaRed
            // 
            this.RuaRed.BackColor = System.Drawing.Color.DarkRed;
            this.RuaRed.Location = new System.Drawing.Point(285, 286);
            this.RuaRed.Name = "RuaRed";
            this.RuaRed.Size = new System.Drawing.Size(29, 27);
            this.RuaRed.TabIndex = 3;
            this.RuaRed.UseVisualStyleBackColor = false;
            // 
            // RuaYellow
            // 
            this.RuaYellow.BackColor = System.Drawing.Color.Olive;
            this.RuaYellow.Location = new System.Drawing.Point(285, 319);
            this.RuaYellow.Name = "RuaYellow";
            this.RuaYellow.Size = new System.Drawing.Size(29, 27);
            this.RuaYellow.TabIndex = 3;
            this.RuaYellow.UseVisualStyleBackColor = false;
            // 
            // RuaGreen
            // 
            this.RuaGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.RuaGreen.Location = new System.Drawing.Point(285, 352);
            this.RuaGreen.Name = "RuaGreen";
            this.RuaGreen.Size = new System.Drawing.Size(29, 27);
            this.RuaGreen.TabIndex = 3;
            this.RuaGreen.UseVisualStyleBackColor = false;
            // 
            // timerEmergencia
            // 
            this.timerEmergencia.Interval = 5000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 632);
            this.Controls.Add(this.RuaGreen);
            this.Controls.Add(this.AvGreen);
            this.Controls.Add(this.RuaYellow);
            this.Controls.Add(this.AvYellow);
            this.Controls.Add(this.RuaRed);
            this.Controls.Add(this.AvRed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLinkPolicia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDesliga);
            this.Controls.Add(this.btnLiga);
            this.Controls.Add(this.btnEmergencia);
            this.Controls.Add(this.lblDataHora);
            this.Name = "Form1";
            this.Text = "Controle de Tráfego";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Button btnEmergencia;
        private System.Windows.Forms.Button btnLiga;
        private System.Windows.Forms.Button btnDesliga;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLinkPolicia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AvRed;
        private System.Windows.Forms.Button AvYellow;
        private System.Windows.Forms.Button AvGreen;
        private System.Windows.Forms.Button RuaRed;
        private System.Windows.Forms.Button RuaYellow;
        private System.Windows.Forms.Button RuaGreen;
        private System.Windows.Forms.Timer timerSemaforo;
        private System.Windows.Forms.Timer timerEmergencia;
    }
}