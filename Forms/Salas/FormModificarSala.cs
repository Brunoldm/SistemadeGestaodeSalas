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
    public partial class FormModificarSala : Form
    {
        public FormModificarSala()
        {
            InitializeComponent();
        }

        private void FormModificarSala_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            // Verifica se a sala foi buscada antes de editar
            if (string.IsNullOrWhiteSpace(TxtCodigoSala.Text))
            {
                MessageBox.Show("Busque uma sala antes de modificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Captura os dados alterados
            string nome = TxtNomeSala.Text;
            string tipo = CmbTipoSala.SelectedItem?.ToString();
            int capacidade = (int)NumCapacidade.Value;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simula a atualização (substituir por código real de banco de dados)
            MessageBox.Show($"Sala {TxtCodigoSala.Text} modificada com sucesso!\n\nNovo Nome: {nome}\nTipo: {tipo}\nCapacidade: {capacidade}",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa os campos após a modificação
            TxtCodigoSala.Clear();
            TxtNomeSala.Clear();
            CmbTipoSala.SelectedIndex = -1;
            NumCapacidade.Value = NumCapacidade.Minimum;
        }

        private void BtnBuscarSala_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtCodigoSala.Text, out int codigo))
            {
                MessageBox.Show("Código inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SalaRepository salaRepository = new SalaRepository(Conexao.GetConnection().ConnectionString);
            Sala salaEncontrada = salaRepository.BuscarSala(codigo); // Agora usa int

            if (salaEncontrada != null)
            {
                TxtNomeSala.Text = salaEncontrada.Nome;
                CmbTipoSala.SelectedItem = salaEncontrada.Tipo;
                NumCapacidade.Value = salaEncontrada.Capacidade;
            }
            else
            {
                MessageBox.Show("Sala não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
