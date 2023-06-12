namespace calculo_ideal
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.text_altura = new System.Windows.Forms.TextBox();
            this.radio_homem = new System.Windows.Forms.RadioButton();
            this.radio_mulher = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.text_peso_atual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DO PESO IDEAL";
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmd_calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmd_calcular.Location = new System.Drawing.Point(150, 265);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(118, 56);
            this.cmd_calcular.TabIndex = 1;
            this.cmd_calcular.Text = "CALCULAR";
            this.cmd_calcular.UseVisualStyleBackColor = false;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // text_altura
            // 
            this.text_altura.Location = new System.Drawing.Point(78, 219);
            this.text_altura.Name = "text_altura";
            this.text_altura.Size = new System.Drawing.Size(100, 22);
            this.text_altura.TabIndex = 2;
            this.text_altura.TextChanged += new System.EventHandler(this.text_altura_TextChanged);
            // 
            // radio_homem
            // 
            this.radio_homem.AutoSize = true;
            this.radio_homem.Location = new System.Drawing.Point(60, 111);
            this.radio_homem.Name = "radio_homem";
            this.radio_homem.Size = new System.Drawing.Size(79, 20);
            this.radio_homem.TabIndex = 3;
            this.radio_homem.TabStop = true;
            this.radio_homem.Text = "HOMEM";
            this.radio_homem.UseVisualStyleBackColor = true;
            // 
            // radio_mulher
            // 
            this.radio_mulher.AutoSize = true;
            this.radio_mulher.Location = new System.Drawing.Point(167, 111);
            this.radio_mulher.Name = "radio_mulher";
            this.radio_mulher.Size = new System.Drawing.Size(85, 20);
            this.radio_mulher.TabIndex = 4;
            this.radio_mulher.TabStop = true;
            this.radio_mulher.Text = "MULHER";
            this.radio_mulher.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(75, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura (metros):";
            // 
            // text_peso_atual
            // 
            this.text_peso_atual.Location = new System.Drawing.Point(240, 219);
            this.text_peso_atual.Name = "text_peso_atual";
            this.text_peso_atual.Size = new System.Drawing.Size(109, 22);
            this.text_peso_atual.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(237, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Peso atual(Kg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "3 periodo ads: André Luiz e Rangel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_peso_atual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio_mulher);
            this.Controls.Add(this.radio_homem);
            this.Controls.Add(this.text_altura);
            this.Controls.Add(this.cmd_calcular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.TextBox text_altura;
        private System.Windows.Forms.RadioButton radio_homem;
        private System.Windows.Forms.RadioButton radio_mulher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_peso_atual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

