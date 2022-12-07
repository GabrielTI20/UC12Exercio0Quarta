namespace PrimeiraAulaGabriel
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
            this.Vermelho1 = new System.Windows.Forms.Button();
            this.Mensagem1 = new System.Windows.Forms.Label();
            this.Verde1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mensagemAmarela = new System.Windows.Forms.Label();
            this.mensagemVerde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vermelho1
            // 
            this.Vermelho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Vermelho1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vermelho1.Location = new System.Drawing.Point(12, 12);
            this.Vermelho1.Name = "Vermelho1";
            this.Vermelho1.Size = new System.Drawing.Size(180, 84);
            this.Vermelho1.TabIndex = 0;
            this.Vermelho1.Text = "Vermelho";
            this.Vermelho1.UseVisualStyleBackColor = false;
            this.Vermelho1.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Mensagem1
            // 
            this.Mensagem1.AutoSize = true;
            this.Mensagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mensagem1.Location = new System.Drawing.Point(198, 42);
            this.Mensagem1.Name = "Mensagem1";
            this.Mensagem1.Size = new System.Drawing.Size(154, 25);
            this.Mensagem1.TabIndex = 1;
            this.Mensagem1.Text = "Sinal vermelho";
            // 
            // Verde1
            // 
            this.Verde1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Verde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verde1.Location = new System.Drawing.Point(12, 256);
            this.Verde1.Name = "Verde1";
            this.Verde1.Size = new System.Drawing.Size(180, 89);
            this.Verde1.TabIndex = 2;
            this.Verde1.Text = "Verde";
            this.Verde1.UseVisualStyleBackColor = false;
            this.Verde1.Click += new System.EventHandler(this.Verde1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 87);
            this.button1.TabIndex = 3;
            this.button1.Text = "Amarelo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Amarelo);
            // 
            // mensagemAmarela
            // 
            this.mensagemAmarela.AutoSize = true;
            this.mensagemAmarela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemAmarela.ForeColor = System.Drawing.Color.Goldenrod;
            this.mensagemAmarela.Location = new System.Drawing.Point(198, 164);
            this.mensagemAmarela.Name = "mensagemAmarela";
            this.mensagemAmarela.Size = new System.Drawing.Size(145, 25);
            this.mensagemAmarela.TabIndex = 4;
            this.mensagemAmarela.Text = "Sinal Amarelo";
            this.mensagemAmarela.Click += new System.EventHandler(this.label1_Click);
            // 
            // mensagemVerde
            // 
            this.mensagemVerde.AutoSize = true;
            this.mensagemVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemVerde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mensagemVerde.Location = new System.Drawing.Point(198, 288);
            this.mensagemVerde.Name = "mensagemVerde";
            this.mensagemVerde.Size = new System.Drawing.Size(123, 25);
            this.mensagemVerde.TabIndex = 5;
            this.mensagemVerde.Text = "Sinal Verde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.mensagemVerde);
            this.Controls.Add(this.mensagemAmarela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Verde1);
            this.Controls.Add(this.Mensagem1);
            this.Controls.Add(this.Vermelho1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vermelho1;
        private System.Windows.Forms.Label Mensagem1;
        private System.Windows.Forms.Button Verde1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mensagemAmarela;
        private System.Windows.Forms.Label mensagemVerde;
    }
}

