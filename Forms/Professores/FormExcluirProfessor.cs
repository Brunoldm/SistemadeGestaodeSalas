using SistemadeGestãodeSalas.Data;
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
    public partial class FormExcluirProfessor : Form
    {
        public FormExcluirProfessor()
        {
            InitializeComponent();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (!int.TryParse(TxtCodigo.Text, out codigo))
            {
                MessageBox.Show("Código inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cpf = TxtCPF.Text.Trim();
            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("CPF inválido! O campo não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfessorRepository professorRepository = new ProfessorRepository(Conexao.GetConnection().ConnectionString);

            try
            {
                
                bool sucesso = professorRepository.ExcluirProfessor(codigo, cpf);

                if (sucesso)
                {
                    MessageBox.Show("Professor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtCodigo.Clear();
                    TxtCPF.Clear();
                }
                else
                {
                    MessageBox.Show("Nenhum professor encontrado com esse código e CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir professor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

