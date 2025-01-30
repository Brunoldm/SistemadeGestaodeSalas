using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SistemadeGestãodeSalas.Data;
using SistemadeGestãodeSalas.Models;


namespace SistemadeGestaoDeSalas.Repositories
{
    public class ProfessorRepository
    {
        private readonly string _connectionString;

        public ProfessorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        /// Adiciona um professor ao banco de dados.
        public int AdicionarProfessor(Professor professor)
        {
            int codigoGerado = 0; 

            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = @"INSERT INTO Professores (Nome, CPF, DataNascimento)
                         VALUES (@Nome, @CPF, @DataNascimento);
                         SELECT SCOPE_IDENTITY();"; // Retorna o último código gerado

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", professor.Nome);
                    command.Parameters.AddWithValue("@CPF", professor.CPF);
                    command.Parameters.AddWithValue("@DataNascimento", professor.DataNascimento);

                    connection.Open();
                    
                    codigoGerado = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return codigoGerado; 
        }


        /// Lista todos os professores cadastrados no banco de dados.
        public List<Professor> ListarProfessores()
        {
            List<Professor> listaProfessores = new List<Professor>();


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Codigo, Nome, CPF, DataNascimento FROM Professores";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Professor professor = new Professor
                            {
                                Codigo = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                CPF = reader.GetString(2),
                                DataNascimento = reader.GetDateTime(3)
                            };
                            listaProfessores.Add(professor);
                        }
                    }
                }
            }
            return listaProfessores;
        }


        /// Atualiza os dados de um professor existente no banco de dados.
        public bool AtualizarProfessor(Professor professor)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Professores SET Nome = @Nome, CPF = @CPF, DataNascimento = @DataNascimento WHERE Codigo = @Codigo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", professor.Codigo);
                    command.Parameters.AddWithValue("@Nome", professor.Nome);
                    command.Parameters.AddWithValue("@CPF", professor.CPF);
                    command.Parameters.AddWithValue("@DataNascimento", professor.DataNascimento);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); 
                    return rowsAffected > 0; 
                }
            }
        }


        /// Exclui um professor do banco de dados.
        public bool ExcluirProfessor(int codigo, string cpf)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Professores WHERE Codigo = @Codigo AND CPF = @CPF";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    command.Parameters.AddWithValue("@CPF", cpf);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); 
                    return rowsAffected > 0; 
                }
            }
        }

        /// Busca um professor pelo código.
        public Professor BuscarProfessor(int codigo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Codigo, Nome, CPF, DataNascimento FROM Professores WHERE Codigo = @Codigo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", codigo);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Professor
                    {
                        Codigo = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        CPF = reader.GetString(2),
                        DataNascimento = reader.GetDateTime(3)
                    };
                }
            }

            return null;
        }
    }
}