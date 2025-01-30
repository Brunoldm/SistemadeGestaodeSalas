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
    public partial class FormReservas : Form
    {
        private Panel _panelConteudo;
        public FormReservas(Panel panelConteudo)
        {
            InitializeComponent();
            _panelConteudo = panelConteudo;

            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
        }

        private void BtnCadastrarReserva_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormReservarSala formReservarSala = new FormReservarSala
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formReservarSala);
            formReservarSala.Show();
        }

        private void BtnCancelarReserva_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormCancelarReserva formCancelarReserva = new FormCancelarReserva
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formCancelarReserva);
            formCancelarReserva.Show();
        }

        private void BtnListarReservas_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormListarReservas formListarReservas = new FormListarReservas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formListarReservas);
            formListarReservas.Show();
        }
    }
}
