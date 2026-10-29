namespace Ex5
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCriarPessoa = new System.Windows.Forms.Button();
            this.Gerente = new System.Windows.Forms.PictureBox();
            this.Assistente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gerente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assistente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(51, 63);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(307, 109);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Os Dados da Pessoa Aparecerão aqui";
            // 
            // btnCriarPessoa
            // 
            this.btnCriarPessoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCriarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPessoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCriarPessoa.Location = new System.Drawing.Point(72, 195);
            this.btnCriarPessoa.Name = "btnCriarPessoa";
            this.btnCriarPessoa.Size = new System.Drawing.Size(259, 34);
            this.btnCriarPessoa.TabIndex = 3;
            this.btnCriarPessoa.Text = "Criar e Exibir Funcionario";
            this.btnCriarPessoa.UseVisualStyleBackColor = false;
            this.btnCriarPessoa.Click += new System.EventHandler(this.btnCriarPessoa_Click);
            // 
            // Gerente
            // 
            this.Gerente.Location = new System.Drawing.Point(457, 31);
            this.Gerente.Name = "Gerente";
            this.Gerente.Size = new System.Drawing.Size(278, 376);
            this.Gerente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gerente.TabIndex = 5;
            this.Gerente.TabStop = false;
            // 
            // Assistente
            // 
            this.Assistente.Location = new System.Drawing.Point(457, 31);
            this.Assistente.Name = "Assistente";
            this.Assistente.Size = new System.Drawing.Size(278, 376);
            this.Assistente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Assistente.TabIndex = 6;
            this.Assistente.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Assistente);
            this.Controls.Add(this.Gerente);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCriarPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gerente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assistente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCriarPessoa;
        private System.Windows.Forms.PictureBox Gerente;
        private System.Windows.Forms.PictureBox Assistente;
    }
}

