namespace cadastroUser_v2
{
    partial class CadastroMotoristaView
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
            this.cadastrar_button = new System.Windows.Forms.Button();
            this.placa_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.placa_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.Cadastro = new System.Windows.Forms.Label();
            this.listaMotoristas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar_button
            // 
            this.cadastrar_button.Location = new System.Drawing.Point(475, 446);
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
            // listaMotoristas
            // 
            this.listaMotoristas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listaMotoristas.FormattingEnabled = true;
            this.listaMotoristas.ItemHeight = 20;
            this.listaMotoristas.Location = new System.Drawing.Point(476, 515);
            this.listaMotoristas.Name = "listaMotoristas";
            this.listaMotoristas.Size = new System.Drawing.Size(227, 124);
            this.listaMotoristas.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ver motoristas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CadastroMotoristaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 770);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaMotoristas);
            this.Controls.Add(this.cadastrar_button);
            this.Controls.Add(this.placa_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.placa_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.Cadastro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroMotoristaView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cadastrar_button;
        private System.Windows.Forms.Label placa_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox placa_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.ListBox listaMotoristas;
        private System.Windows.Forms.Button button1;
    }
}

