namespace cadastroUsers
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
            this.Cadastro = new System.Windows.Forms.Label();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.placa_textbox = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.placa_label = new System.Windows.Forms.Label();
            this.cadastrar_button = new System.Windows.Forms.Button();
            this.dados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Cadastro.Location = new System.Drawing.Point(294, 52);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(231, 28);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro de motorista";
            this.Cadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(326, 116);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(145, 20);
            this.nome_textbox.TabIndex = 1;
            this.nome_textbox.Text = "Insira seu nome aqui";
            this.nome_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(326, 179);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(145, 20);
            this.email_textbox.TabIndex = 2;
            this.email_textbox.Text = "Insira seu email aqui";
            this.email_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // placa_textbox
            // 
            this.placa_textbox.Location = new System.Drawing.Point(326, 246);
            this.placa_textbox.Name = "placa_textbox";
            this.placa_textbox.Size = new System.Drawing.Size(145, 20);
            this.placa_textbox.TabIndex = 3;
            this.placa_textbox.Text = "Insira a placa do veículo aqui";
            this.placa_textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(323, 100);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(81, 13);
            this.nome_label.TabIndex = 4;
            this.nome_label.Text = "Nome completo";
            this.nome_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(323, 163);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(35, 13);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email:";
            // 
            // placa_label
            // 
            this.placa_label.AutoSize = true;
            this.placa_label.Location = new System.Drawing.Point(323, 230);
            this.placa_label.Name = "placa_label";
            this.placa_label.Size = new System.Drawing.Size(91, 13);
            this.placa_label.TabIndex = 6;
            this.placa_label.Text = "Placa do veículo:";
            // 
            // cadastrar_button
            // 
            this.cadastrar_button.Location = new System.Drawing.Point(342, 305);
            this.cadastrar_button.Name = "cadastrar_button";
            this.cadastrar_button.Size = new System.Drawing.Size(111, 28);
            this.cadastrar_button.TabIndex = 7;
            this.cadastrar_button.Text = "Cadastrar";
            this.cadastrar_button.UseVisualStyleBackColor = true;
            this.cadastrar_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dados
            // 
            this.dados.AutoSize = true;
            this.dados.Location = new System.Drawing.Point(309, 376);
            this.dados.Name = "dados";
            this.dados.Size = new System.Drawing.Size(44, 13);
            this.dados.TabIndex = 8;
            this.dados.Text = "Dados: ";
            this.dados.Click += new System.EventHandler(this.dados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dados);
            this.Controls.Add(this.cadastrar_button);
            this.Controls.Add(this.placa_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.placa_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.Cadastro);
            this.Name = "Form1";
            this.Text = "nome_label1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox placa_textbox;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label placa_label;
        private System.Windows.Forms.Button cadastrar_button;
        private System.Windows.Forms.Label dados;
    }
}

