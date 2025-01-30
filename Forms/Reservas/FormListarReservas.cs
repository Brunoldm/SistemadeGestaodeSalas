using SistemadeGestãodeSalas.Data;
using SistemadeGestãodeSalas.Models;
using SistemadeGestaoDeSalas.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeGestãodeSalas.Forms.Reservas
{
    public partial class FormListarReservas : Form
    {
        public FormListarReservas()
        {
            InitializeComponent();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormListarReservas_Load(object sender, EventArgs e)
        {
            try
            {
                ReservaRepository reservaRepository = new ReservaRepository(Conexao.GetConnection().ConnectionString);
                List<Reserva> reservas = reservaRepository.ListarReservas();

                if (reservas.Count == 0)
                {
                    MessageBox.Show("Nenhuma reserva encontrada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Configurar DataGridView
                DgvReservas.DataSource = null;
                DgvReservas.AutoGenerateColumns = true;
                DgvReservas.DataSource = reservas;
                DgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvReservas.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
