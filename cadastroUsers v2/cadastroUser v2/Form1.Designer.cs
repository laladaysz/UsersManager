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
            this.labelDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dados
            // 
            this.dados.AutoSize = true;
            this.dados.Location = new System.Drawing.Point(450, 586);
            this.dados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dados.Name = "dados";
            this.dados.Size = new System.Drawing.Size(64, 20);
            this.dados.TabIndex = 17;
            this.dados.Text = "Dados: ";
            // 
            // cadastrar_button
            // 
            this.cadastrar_button.Location = new System.Drawing.Point(484, 451);
            this.cadastrar_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cadastrar_button.Name = "cadastrar_button";
            this.cadastrar_button.Size = new System.Drawing.Size(94, 43);
            this.cadastrar_button.TabIndex = 16;
            this.cadastrar_button.Text = "Cadastrar";
            this.cadastrar_button.UseVisualStyleBackColor = true;
            this.cadastrar_button.Click += new System.EventHandler(this.cadastrar_button_Click);
            // 
            // placa_label
            // 
            this.placa_label.AutoSize = true;
            this.placa_label.Location = new System.Drawing.Point(471, 362);
            this.placa_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placa_label.Name = "placa_label";
            this.placa_label.Size = new System.Drawing.Size(126, 20);
            this.placa_label.TabIndex = 15;
            this.placa_label.Text = "Placa do veículo:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(471, 258);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(52, 20);
            this.email_label.TabIndex = 14;
            this.email_label.Text = "Email:";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(471, 162);
            this.nome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(120, 20);
            this.nome_label.TabIndex = 13;
            this.nome_label.Text = "Nome completo";
            // 
            // placa_textbox
            // 
            this.placa_textbox.Location = new System.Drawing.Point(476, 386);
            this.placa_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placa_textbox.Name = "placa_textbox";
            this.placa_textbox.Size = new System.Drawing.Size(216, 26);
            this.placa_textbox.TabIndex = 12;
            this.placa_textbox.Text = "Insira a placa do veículo aqui";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(476, 283);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(216, 26);
            this.email_textbox.TabIndex = 11;
            this.email_textbox.Text = "Insira seu email aqui";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(476, 186);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(216, 26);
            this.nome_textbox.TabIndex = 10;
            this.nome_textbox.Text = "Insira seu nome aqui";
            // 
            // Cadastro
            // 
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Cadastro.Location = new System.Drawing.Point(428, 88);
            this.Cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(346, 43);
            this.Cadastro.TabIndex = 9;
            this.Cadastro.Text = "Cadastro de motorista";
            // 
            // salvar_button
            // 
            this.salvar_button.Location = new System.Drawing.Point(588, 451);
            this.salvar_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(92, 43);
            this.salvar_button.TabIndex = 18;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDados
            // 
            this.labelDados.AutoSize = true;
            this.labelDados.Location = new System.Drawing.Point(450, 617);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(14, 30);
            this.labelDados.TabIndex = 19;
            this.labelDados.Text = "\r\n";
            this.labelDados.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.labelDados);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label labelDados;
    }
}

