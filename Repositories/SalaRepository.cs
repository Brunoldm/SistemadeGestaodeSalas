using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemadeGestãodeSalas.Data;
using SistemadeGestãodeSalas.Models;

namespace SistemadeGestaoDeSalas.Repositories
{
    public class SalaRepository
    {
        private readonly string _connectionString;

        public SalaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// Método para Adicionar Sala
        public int AdicionarSala(Sala sala)
        {
            int codigoGerado = 0;

            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = @"
            INSERT INTO Salas (Nome, Tipo, Capacidade)
            VALUES (@Nome, @Tipo, @Capacidade);
            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", sala.Nome);
                    command.Parameters.AddWithValue("@Tipo", sala.Tipo);
                    command.Parameters.AddWithValue("@Capacidade", sala.Capacidade);

                    connection.Open();
                    codigoGerado = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return codigoGerado;
        }


        ///Método para Listar todas as Salas
        public List<Sala> ListarSalas()
        {
            List<Sala> listaSalas = new List<Sala>();

            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = "SELECT Codigo, Nome, Tipo, Capacidade FROM Salas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sala sala = new Sala
                            {
                                Codigo = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Tipo = reader.GetString(2),
                                Capacidade = reader.GetInt32(3)
                            };
                            listaSalas.Add(sala);
                        }
                    }
                }
            }

            return listaSalas;
        }

        ///Método para Modificar uma Sala
        public bool ModificarSala(Sala sala)
        {
            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = "UPDATE Salas SET Nome = @Nome, Tipo = @Tipo, Capacidade = @Capacidade WHERE Codigo = @Codigo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", sala.Codigo);
                    command.Parameters.AddWithValue("@Nome", sala.Nome);
                    command.Parameters.AddWithValue("@Tipo", sala.Tipo);
                    command.Parameters.AddWithValue("@Capacidade", sala.Capacidade);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        ///Método para Excluir uma Sala
        public bool ExcluirSala(int codigo)
        {
            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = "DELETE FROM Salas WHERE Codigo = @Codigo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        ///Método para Buscar uma Sala pelo Código
        public Sala BuscarSala(int codigo)
        {
            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = "SELECT Codigo, Nome, Tipo, Capacidade FROM Salas WHERE Codigo = @Codigo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", codigo);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Sala
                    {
                        Codigo = reader.GetInt32(0), 
                        Nome = reader.GetString(1),
                        Tipo = reader.GetString(2),
                        Capacidade = reader.GetInt32(3)
                    };
                }
            }

            return null;
        }

    }
}