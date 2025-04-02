namespace Objetivo2
{
    partial class Form1
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
            this.btnLiga = new System.Windows.Forms.Button();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.btnErro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLiga
            // 
            this.btnLiga.BackColor = System.Drawing.Color.Lime;
            this.btnLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnLiga.Location = new System.Drawing.Point(67, 89);
            this.btnLiga.Name = "btnLiga";
            this.btnLiga.Size = new System.Drawing.Size(216, 97);
            this.btnLiga.TabIndex = 0;
            this.btnLiga.Text = "LIGA";
            this.btnLiga.UseVisualStyleBackColor = false;
            this.btnLiga.Click += new System.EventHandler(this.btnLiga_Click);
            // 
            // btnDesliga
            // 
            this.btnDesliga.BackColor = System.Drawing.Color.Red;
            this.btnDesliga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDesliga.Location = new System.Drawing.Point(475, 89);
            this.btnDesliga.Name = "btnDesliga";
            this.btnDesliga.Size = new System.Drawing.Size(236, 97);
            this.btnDesliga.TabIndex = 1;
            this.btnDesliga.Text = "DESLIGA";
            this.btnDesliga.UseVisualStyleBackColor = false;
            this.btnDesliga.Click += new System.EventHandler(this.btnDesliga_Click);
            // 
            // btnErro
            // 
            this.btnErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnErro.Location = new System.Drawing.Point(67, 277);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(216, 97);
            this.btnErro.TabIndex = 2;
            this.btnErro.Text = "ERRO";
            this.btnErro.UseVisualStyleBackColor = false;
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSair.Location = new System.Drawing.Point(475, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(236, 97);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnErro);
            this.Controls.Add(this.btnDesliga);
            this.Controls.Add(this.btnLiga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLiga;
        private System.Windows.Forms.Button btnDesliga;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.Button btnSair;
    }
}

