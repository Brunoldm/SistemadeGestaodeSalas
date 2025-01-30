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
    public partial class FormCadastrarSala : Form
    {
        public FormCadastrarSala()
        {
            InitializeComponent();
        }

        private void CmbTipoSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNomeSala.Text))
            {
                MessageBox.Show("O nome da sala é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CmbTipoSala.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o tipo de sala.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sala sala = new Sala
            {
                Nome = TxtNomeSala.Text,
                Tipo = CmbTipoSala.SelectedItem.ToString(),
                Capacidade = (int)NumCapacidade.Value
            };

            SalaRepository salaRepository = new SalaRepository(Conexao.GetConnection().ConnectionString);
            int codigoGerado = salaRepository.AdicionarSala(sala);

            if (codigoGerado > 0)
            {
                MessageBox.Show($"Sala cadastrada com sucesso!\nCódigo: {codigoGerado}\nNome: {sala.Nome}\nTipo: {sala.Tipo}\nCapacidade: {sala.Capacidade}",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos
                TxtNomeSala.Clear();
                CmbTipoSala.SelectedIndex = -1;
                NumCapacidade.Value = NumCapacidade.Minimum;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar sala!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
