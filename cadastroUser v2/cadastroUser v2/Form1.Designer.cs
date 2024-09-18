namespace cadastroUser_v2
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
            this.dados = new System.Windows.Forms.Label();
            this.cadastrar_button = new System.Windows.Forms.Button();
            this.placa_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.placa_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.Cadastro = new System.Windows.Forms.Label();
            this.salvar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dados
            // 
            this.dados.AutoSize = true;
            this.dados.Location = new System.Drawing.Point(300, 381);
            this.dados.Name = "dados";
            this.dados.Size = new System.Drawing.Size(44, 13);
            this.dados.TabIndex = 17;
            this.dados.Text = "Dados: ";
            // 
            // cadastrar_button
            // 
            this.cadastrar_button.Location = new System.Drawing.Point(323, 293);
            this.cadastrar_button.Name = "cadastrar_button";
            this.cadastrar_button.Size = new System.Drawing.Size(63, 28);
            this.cadastrar_button.TabIndex = 16;
            this.cadastrar_button.Text = "Cadastrar";
            this.cadastrar_button.UseVisualStyleBackColor = true;
            this.cadastrar_button.Click += new System.EventHandler(this.cadastrar_button_Click);
            // 
            // placa_label
            // 
            this.placa_label.AutoSize = true;
            this.placa_label.Location = new System.Drawing.Point(314, 235);
            this.placa_label.Name = "placa_label";
            this.placa_label.Size = new System.Drawing.Size(91, 13);
            this.placa_label.TabIndex = 15;
            this.placa_label.Text = "Placa do veículo:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(314, 168);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(35, 13);
            this.email_label.TabIndex = 14;
            this.email_label.Text = "Email:";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(314, 105);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(81, 13);
            this.nome_label.TabIndex = 13;
            this.nome_label.Text = "Nome completo";
            // 
            // placa_textbox
            // 
            this.placa_textbox.Location = new System.Drawing.Point(317, 251);
            this.placa_textbox.Name = "placa_textbox";
            this.placa_textbox.Size = new System.Drawing.Size(145, 20);
            this.placa_textbox.TabIndex = 12;
            this.placa_textbox.Text = "Insira a placa do veículo aqui";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(317, 184);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(145, 20);
            this.email_textbox.TabIndex = 11;
            this.email_textbox.Text = "Insira seu email aqui";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(317, 121);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(145, 20);
            this.nome_textbox.TabIndex = 10;
            this.nome_textbox.Text = "Insira seu nome aqui";
            // 
            // Cadastro
            // 
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Cadastro.Location = new System.Drawing.Point(285, 57);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(231, 28);
            this.Cadastro.TabIndex = 9;
            this.Cadastro.Text = "Cadastro de motorista";
            // 
            // salvar_button
            // 
            this.salvar_button.Location = new System.Drawing.Point(392, 293);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(61, 28);
            this.salvar_button.TabIndex = 18;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salvar_button);
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
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dados;
        private System.Windows.Forms.Button cadastrar_button;
        private System.Windows.Forms.Label placa_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox placa_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Button salvar_button;
    }
}

