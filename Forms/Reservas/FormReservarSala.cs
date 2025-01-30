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
    public partial class FormReservarSala : Form
    {
        public FormReservarSala()
        {
            InitializeComponent();
        }

        private void FormReservarSala_Load(object sender, EventArgs e)
        {
            ConfigurarCampos();
        }

        private void ConfigurarCampos()
        {
            if (DtpHoraInicial != null && DtpHoraFinal != null)
            {
                DtpHoraInicial.Format = DateTimePickerFormat.Time;
                DtpHoraInicial.ShowUpDown = true;
                DtpHoraFinal.Format = DateTimePickerFormat.Time;
                DtpHoraFinal.ShowUpDown = true;

                DtpHoraInicial.Value = DateTime.Now;
                DtpHoraFinal.Value = DateTime.Now.AddHours(1);
            }
        }
        
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtCodigoSala.Text, out int codigoSala))
            {
                MessageBox.Show("Código da sala inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação do código do professor digitado
            if (!int.TryParse(TxtCodigoProfessor.Text, out int codigoProfessor))
            {
                MessageBox.Show("Código do professor inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação dos horários
            TimeSpan horaInicio = DtpHoraInicial.Value.TimeOfDay;
            TimeSpan horaFim = DtpHoraFinal.Value.TimeOfDay;

            if (horaFim <= horaInicio)
            {
                MessageBox.Show("Horário final deve ser maior que o horário inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar o objeto de reserva
            Reserva reserva = new Reserva
            {
                ProfessorCodigo = codigoProfessor,
                SalaCodigo = codigoSala,
                DataReserva = DtpDataReserva.Value.Date,
                HoraInicio = horaInicio,
                HoraFim = horaFim
            };

            try
            {
                // Salvar a reserva no banco de dados
                ReservaRepository reservaRepository = new ReservaRepository(Conexao.GetConnection().ConnectionString);
                int codigoGerado = reservaRepository.AdicionarReserva(reserva);

                MessageBox.Show($"Reserva efetuada com sucesso!\nCódigo: {codigoGerado}",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar os campos após a reserva
                TxtCodigoSala.Clear();
                TxtCodigoProfessor.Clear();
                DtpDataReserva.Value = DateTime.Now;
                DtpHoraInicial.Value = DateTime.Now;
                DtpHoraFinal.Value = DateTime.Now.AddHours(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao reservar sala: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LblSalas_Click(object sender, EventArgs e)
        {

        }
    }
}