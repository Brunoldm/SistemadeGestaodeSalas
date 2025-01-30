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

namespace SistemadeGestãodeSalas.Forms.Reservas
{
    public partial class FormCancelarReserva : Form
    {
        public FormCancelarReserva()
        {
            InitializeComponent();
        }

        private void BtnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCodigoReserva.Text) || !int.TryParse(TxtCodigoReserva.Text, out int codigoReserva))
            {
                MessageBox.Show("Código da reserva inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja cancelar esta reserva?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No)
            {
                return;
            }

            ReservaRepository reservaRepository = new ReservaRepository(Conexao.GetConnection().ConnectionString);
            bool sucesso = reservaRepository.CancelarReserva(codigoReserva);

            if (sucesso)
            {
                MessageBox.Show("Reserva cancelada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCodigoReserva.Clear();
            }
            else
            {
                MessageBox.Show("Reserva não encontrada! Verifique o código digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
