using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cadastroUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dados_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Defina o caminho do arquivo onde os dados serão salvos
            string filePath = "dados.txt";

            // Obtenha os valores das caixas de texto
            string texto1 = nome_textbox.Text;
            string texto2 = email_textbox.Text;
            string texto3 = placa_textbox.Text;

            // Crie uma lista de strings para armazenar as linhas do arquivo
            List<string> linhas = new List<string>
    {
        "Nome: " + texto1,
        "Email: " + texto2,
        "Placa: " + texto3
    };

            // Salve as linhas no arquivo de texto
            File.WriteAllLines(filePath, linhas);

            // Informe ao usuário que os dados foram salvos
            MessageBox.Show("Dados salvos com sucesso em " + filePath);
        }
    }
}
