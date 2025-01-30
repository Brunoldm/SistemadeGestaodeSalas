using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemadeGestãodeSalas.Data
{
    public static class Conexao
    {

        /// Método para obter a conexão com o banco de dados.
        /// <returns>Instância de SqlConnection.</returns>
        public static SqlConnection GetConnection()
        {
            // String de conexão para o banco de dados.
            string connectionString = "Server=DESKTOP-BPIN0DO;Database=GestaoSalas;Trusted_Connection=True;";
            return new SqlConnection(connectionString);
        }


        /// Método para testar a conexão com o banco de dados.
        public static void TestarConexao()
        {

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexão com o banco de dados realizada com sucesso!", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
