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
    public class ReservaRepository
    {
        private readonly string _connectionString;

        public ReservaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// Método para Adicionar Reserva**
        public int AdicionarReserva(Reserva reserva)
        {
            int codigoGerado = 0;

            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = @"
                 INSERT INTO Reservas (CodigoProfessor, CodigoSala, DataReserva, HoraInicio, HoraFim)
                 VALUES (@CodigoProfessor, @CodigoSala, @DataReserva, @HoraInicio, @HoraFim);
                  SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoProfessor", reserva.ProfessorCodigo);
                    command.Parameters.AddWithValue("@CodigoSala", reserva.SalaCodigo);
                    command.Parameters.AddWithValue("@DataReserva", reserva.DataReserva);
                    command.Parameters.AddWithValue("@HoraInicio", reserva.HoraInicio);
                    command.Parameters.AddWithValue("@HoraFim", reserva.HoraFim);

                    connection.Open();
                    codigoGerado = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return codigoGerado;
        }

        ///Método para Listar todas as Reservas**
        public List<Reserva> ListarReservas()
        {
            List<Reserva> listaReservas = new List<Reserva>();

            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = "SELECT Codigo, ProfessorCodigo, SalaCodigo, DataReserva, HoraInicio, HoraFim FROM Reservas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reserva reserva = new Reserva
                            {
                                Codigo = reader.GetInt32(0),
                                ProfessorCodigo = reader.GetInt32(1),
                                SalaCodigo = reader.GetInt32(2),
                                DataReserva = reader.GetDateTime(3),
                                HoraInicio = reader.GetTimeSpan(4),
                                HoraFim = reader.GetTimeSpan(5)
                            };
                            listaReservas.Add(reserva);
                        }
                    }
                }
            }

            return listaReservas;
        }

        ///Método para Cancelar uma Reserva**
        public bool CancelarReserva(int codigoReserva)
        {
            using (SqlConnection connection = Conexao.GetConnection())
            {
                string query = "DELETE FROM Reservas WHERE Codigo = @Codigo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", codigoReserva);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
