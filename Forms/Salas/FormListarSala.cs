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

namespace SistemadeGestãodeSalas.Forms.Salas
{
    public partial class FormListarSala : Form
    {
        public FormListarSala()
        {
            InitializeComponent();
        }

        private void DgvSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormListarSala_Load(object sender, EventArgs e)
        {
            try
            {
                SalaRepository salaRepository = new SalaRepository(Conexao.GetConnection().ConnectionString);
                List<Sala> salas = salaRepository.ListarSalas();

                if (salas == null || salas.Count == 0)
                {
                    MessageBox.Show("Nenhuma sala encontrada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DgvSalas.DataSource = null;
                DgvSalas.AutoGenerateColumns = true;
                DgvSalas.DataSource = salas;
                DgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvSalas.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar salas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
