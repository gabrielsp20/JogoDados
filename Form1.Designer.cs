
namespace JogoDados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dado1 = new System.Windows.Forms.PictureBox();
            this.Dados2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jogar1 = new System.Windows.Forms.Button();
            this.jogar2 = new System.Windows.Forms.Button();
            this.reiniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ponto1 = new System.Windows.Forms.Label();
            this.ponto2 = new System.Windows.Forms.Label();
            this.vencedor = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.valorPartida = new System.Windows.Forms.TextBox();
            this.nome1 = new System.Windows.Forms.TextBox();
            this.nome2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dados2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dado1
            // 
            this.Dado1.Image = ((System.Drawing.Image)(resources.GetObject("Dado1.Image")));
            this.Dado1.Location = new System.Drawing.Point(76, 77);
            this.Dado1.Name = "Dado1";
            this.Dado1.Size = new System.Drawing.Size(88, 83);
            this.Dado1.TabIndex = 0;
            this.Dado1.TabStop = false;
            // 
            // Dados2
            // 
            this.Dados2.Image = ((System.Drawing.Image)(resources.GetObject("Dados2.Image")));
            this.Dados2.Location = new System.Drawing.Point(317, 77);
            this.Dados2.Name = "Dados2";
            this.Dados2.Size = new System.Drawing.Size(84, 83);
            this.Dados2.TabIndex = 1;
            this.Dados2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "JOGADOR1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "JOGADOR2";
            // 
            // jogar1
            // 
            this.jogar1.Location = new System.Drawing.Point(92, 253);
            this.jogar1.Name = "jogar1";
            this.jogar1.Size = new System.Drawing.Size(86, 38);
            this.jogar1.TabIndex = 4;
            this.jogar1.Text = "JOGAR";
            this.jogar1.UseVisualStyleBackColor = true;
            this.jogar1.Click += new System.EventHandler(this.jogar1_Click);
            // 
            // jogar2
            // 
            this.jogar2.Location = new System.Drawing.Point(317, 253);
            this.jogar2.Name = "jogar2";
            this.jogar2.Size = new System.Drawing.Size(88, 38);
            this.jogar2.TabIndex = 5;
            this.jogar2.Text = "JOGAR";
            this.jogar2.UseVisualStyleBackColor = true;
            this.jogar2.Click += new System.EventHandler(this.jogar2_Click);
            // 
            // reiniciar
            // 
            this.reiniciar.Location = new System.Drawing.Point(180, 354);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(129, 23);
            this.reiniciar.TabIndex = 6;
            this.reiniciar.Text = "REINICIAR";
            this.reiniciar.UseVisualStyleBackColor = true;
            this.reiniciar.Click += new System.EventHandler(this.reiniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "PONTOS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "PONTOS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "VENCEDOR:";
            // 
            // ponto1
            // 
            this.ponto1.AutoSize = true;
            this.ponto1.Location = new System.Drawing.Point(135, 9);
            this.ponto1.Name = "ponto1";
            this.ponto1.Size = new System.Drawing.Size(13, 15);
            this.ponto1.TabIndex = 10;
            this.ponto1.Text = "0";
            // 
            // ponto2
            // 
            this.ponto2.AutoSize = true;
            this.ponto2.Location = new System.Drawing.Point(378, 9);
            this.ponto2.Name = "ponto2";
            this.ponto2.Size = new System.Drawing.Size(13, 15);
            this.ponto2.TabIndex = 11;
            this.ponto2.Text = "0";
            // 
            // vencedor
            // 
            this.vencedor.AutoSize = true;
            this.vencedor.Location = new System.Drawing.Point(256, 322);
            this.vencedor.Name = "vencedor";
            this.vencedor.Size = new System.Drawing.Size(13, 15);
            this.vencedor.TabIndex = 12;
            this.vencedor.Text = "0";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(40, 322);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(89, 15);
            this.valor.TabIndex = 13;
            this.valor.Text = "Valor da Partida";
            // 
            // valorPartida
            // 
            this.valorPartida.Location = new System.Drawing.Point(40, 340);
            this.valorPartida.Name = "valorPartida";
            this.valorPartida.Size = new System.Drawing.Size(100, 23);
            this.valorPartida.TabIndex = 14;
            this.valorPartida.TextChanged += new System.EventHandler(this.valorPartida_TextChanged);
            // 
            // nome1
            // 
            this.nome1.Location = new System.Drawing.Point(76, 166);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(100, 23);
            this.nome1.TabIndex = 15;
            // 
            // nome2
            // 
            this.nome2.Location = new System.Drawing.Point(313, 166);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(100, 23);
            this.nome2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 389);
            this.Controls.Add(this.nome2);
            this.Controls.Add(this.nome1);
            this.Controls.Add(this.valorPartida);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.vencedor);
            this.Controls.Add(this.ponto2);
            this.Controls.Add(this.ponto1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.jogar2);
            this.Controls.Add(this.jogar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dados2);
            this.Controls.Add(this.Dado1);
            this.Name = "Form1";
            this.Text = "Jogo de Dados Simples";
            ((System.ComponentModel.ISupportInitialize)(this.Dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dados2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dado1;
        private System.Windows.Forms.PictureBox Dados2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button jogar1;
        private System.Windows.Forms.Button jogar2;
        private System.Windows.Forms.Button reiniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ponto1;
        private System.Windows.Forms.Label ponto2;
        private System.Windows.Forms.Label vencedor;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.TextBox valorPartida;
        private System.Windows.Forms.TextBox nome1;
        private System.Windows.Forms.TextBox nome2;
    }
}

