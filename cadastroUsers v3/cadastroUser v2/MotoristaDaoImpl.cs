using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cadastroUser_v2; 
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace cadastroUser_v2
{
    internal class MotoristaDao : IMotoristaDao
    {
        private string connectionString = "server=localhost;database=EasyPark;user=root";

        public void AddMotorista(Motorista motorista)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Motorista (Nome, Email, Placa) VALUES (@Nome, @Email, @Placa)", connection);
                command.Parameters.AddWithValue("@Nome", motorista.Nome);
                command.Parameters.AddWithValue("@Email", motorista.Email);
                command.Parameters.AddWithValue("@Placa", motorista.Placa);
                command.ExecuteNonQuery();
            }

        }

        public List<Motorista> GetMotoristas()
        {
            var motoristas = new List<Motorista>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Motorista", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        motoristas.Add(new Motorista
                        {
                            Nome = reader.GetString("Nome"),
                            Email = reader.GetString("Email"),
                            Placa = reader.GetString("Placa")
                        });
                    }
                }
            }
            return motoristas;
        }

        public Motorista GetMotorista(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Motorista WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Motorista
                        {
                            Id = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Email = reader.GetString("Email"),
                            Placa = reader.GetString("Placa")
                        };
                    }
                }
            }
            return null;
        }

        
    }
}


