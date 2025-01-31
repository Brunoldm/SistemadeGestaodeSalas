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

namespace SistemadeGestãodeSalas
{
    public partial class FormListarProfessor : Form
    {
        public FormListarProfessor()
        {
            InitializeComponent();
        }


        
        private void DgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListarProfessor_Load(object sender, EventArgs e)
        {
            AtualizarListaProfessores();
        }

        private void AtualizarListaProfessores()
        {
            try
            {
                ProfessorRepository professorRepository = new ProfessorRepository(Conexao.GetConnection().ConnectionString);
                List<Professor> professores = professorRepository.ListarProfessores();

                if (professores.Count > 0)
                {
                    DgvProfessores.DataSource = null;  // Garante que os dados são atualizados corretamente
                    DgvProfessores.DataSource = professores;
                    DgvProfessores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DgvProfessores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DgvProfessores.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Nenhum professor cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
