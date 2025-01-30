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
    public partial class FormCadastrarProfessor : Form
    {
        public FormCadastrarProfessor()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(TxtCPF.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cpf = TxtCPF.Text.Trim();

            // Criar um novo objeto Professor com os valores preenchidos no formulário
            Professor professor = new Professor
            {
                Nome = TxtNome.Text,
                CPF = cpf,
                DataNascimento = DtpDataNascimento.Value
            };

            try
            {
                // Criar a conexão com o banco e salvar o professor
                ProfessorRepository professorRepository = new ProfessorRepository("Server=DESKTOP-BPIN0DO;Database=GestaoSalas;Trusted_Connection=True;");
                int codigoGerado = professorRepository.AdicionarProfessor(professor);

                MessageBox.Show($"Professor cadastrado com sucesso!\nCodigo: {codigoGerado}\nNome: {professor.Nome}\nCPF: {professor.CPF}\nData de Nascimento: {professor.DataNascimento.ToShortDateString()}",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtNome.Clear();
                TxtCPF.Clear();
                DtpDataNascimento.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar professor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LblCadastro_Click(object sender, EventArgs e)
        {

        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCpf_Click(object sender, EventArgs e)
        {

        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastrarProfessor_Load(object sender, EventArgs e)
        {

        }

        private void TxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }
    }
}
