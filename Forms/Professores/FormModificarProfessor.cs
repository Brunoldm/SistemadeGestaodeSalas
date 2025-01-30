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
    public partial class FormModificarProfessor : Form
    {
        public FormModificarProfessor()
        {
            InitializeComponent();
        }

        private void LblModificarProfessor_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(TxtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(TxtCPF.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Professor professor = new Professor
            {
                Codigo = codigo,
                Nome = TxtNome.Text,
                CPF = TxtCPF.Text,
                DataNascimento = DtpDataNascimento.Value
            };

            ProfessorRepository professorRepository = new ProfessorRepository(Conexao.GetConnection().ConnectionString);
            bool sucesso = professorRepository.AtualizarProfessor(professor);

            if (sucesso)
            {
                MessageBox.Show("Professor modificado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                TxtCodigo.Clear();
                TxtNome.Clear();
                TxtCPF.Clear();
                DtpDataNascimento.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Nenhum professor encontrado com esse código!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBuscarProfessor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfessorRepository professorRepository = new ProfessorRepository(Conexao.GetConnection().ConnectionString);
            Professor professor = professorRepository.BuscarProfessor(codigo);

            if (professor != null)
            {
                TxtNome.Text = professor.Nome;
                TxtCPF.Text = professor.CPF;
                DtpDataNascimento.Value = professor.DataNascimento;
            }
            else
            {
                MessageBox.Show("Professor não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
