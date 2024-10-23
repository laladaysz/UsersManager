using Newtonsoft.Json;
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

namespace cadastroUser_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrar_button_Click(object sender, EventArgs e)
        {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.json");

                Usuario usuario = new Usuario
                {
                    Nome = nome_textbox.Text,
                    Email = email_textbox.Text,
                    Placa = placa_textbox.Text
                };

                string json = JsonConvert.SerializeObject(usuario, Formatting.Indented);
                
                File.WriteAllText(filePath, json);

                MessageBox.Show("Dados salvos com sucesso em " + filePath);
            }


            private void button1_Click(object sender, EventArgs e)
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.json");

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    Usuario usuario = JsonConvert.DeserializeObject<Usuario>(json);

                    nome_textbox.Text = usuario.Nome;
                    email_textbox.Text = usuario.Email;
                    placa_textbox.Text = usuario.Placa;


                labelDados.Text = "Nome: " + usuario.Nome + "\nEmail: " + usuario.Email + "\nPlaca: " + usuario.Placa;
                
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    } 
