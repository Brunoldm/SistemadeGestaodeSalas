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
    public partial class FormExcluirSala : Form
    {
        public FormExcluirSala()
        {
            InitializeComponent();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(TxtCodigoSala.Text, out int codigo))
            {
                MessageBox.Show("Código inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exibir caixa de diálogo de confirmação
            var confirmResult = MessageBox.Show(
                "Tem certeza que deseja excluir esta sala?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                SalaRepository salaRepository = new SalaRepository(Conexao.GetConnection().ConnectionString);
                bool sucesso = salaRepository.ExcluirSala(codigo);

                if (sucesso)
                {
                    MessageBox.Show("Sala excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtCodigoSala.Clear();
                }
                else
                {
                    MessageBox.Show("Sala não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A exclusão foi cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
