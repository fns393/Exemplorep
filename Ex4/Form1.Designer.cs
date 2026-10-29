namespace Ex4
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
            this.btnCriarPessoa = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.Mulher_foto = new System.Windows.Forms.PictureBox();
            this.Homem_foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mulher_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Homem_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarPessoa
            // 
            this.btnCriarPessoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCriarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPessoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCriarPessoa.Location = new System.Drawing.Point(77, 190);
            this.btnCriarPessoa.Name = "btnCriarPessoa";
            this.btnCriarPessoa.Size = new System.Drawing.Size(259, 34);
            this.btnCriarPessoa.TabIndex = 1;
            this.btnCriarPessoa.Text = "Criar e Exibir Pessoa";
            this.btnCriarPessoa.UseVisualStyleBackColor = false;
            this.btnCriarPessoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(107, 240);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(188, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Os Dados da Pessoa Aparecerão aqui";
            // 
            // Mulher_foto
            // 
            this.Mulher_foto.Location = new System.Drawing.Point(417, 29);
            this.Mulher_foto.Name = "Mulher_foto";
            this.Mulher_foto.Size = new System.Drawing.Size(306, 344);
            this.Mulher_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mulher_foto.TabIndex = 3;
            this.Mulher_foto.TabStop = false;
            // 
            // Homem_foto
            // 
            this.Homem_foto.Location = new System.Drawing.Point(417, 29);
            this.Homem_foto.Name = "Homem_foto";
            this.Homem_foto.Size = new System.Drawing.Size(306, 344);
            this.Homem_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Homem_foto.TabIndex = 4;
            this.Homem_foto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Homem_foto);
            this.Controls.Add(this.Mulher_foto);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCriarPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mulher_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Homem_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPessoa;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox Mulher_foto;
        private System.Windows.Forms.PictureBox Homem_foto;
    }
}

