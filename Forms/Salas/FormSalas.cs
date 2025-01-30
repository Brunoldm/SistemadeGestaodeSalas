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
    public partial class FormSalas : Form
    {
        private Panel _panelConteudo;
        public FormSalas(Panel panelConteudo)
        {
            InitializeComponent();
            _panelConteudo = panelConteudo;

            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
        }

        private void BtnCadastrarSala_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormCadastrarSala formCadastrarSala = new FormCadastrarSala
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formCadastrarSala);
            formCadastrarSala.Show();

        }

        private void BtnModificarSala_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormModificarSala formModificarSala = new FormModificarSala
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formModificarSala);
            formModificarSala.Show();
        }

        private void BtnExcluirSala_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormExcluirSala formExcluirSala = new FormExcluirSala
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formExcluirSala);
            formExcluirSala.Show();

        }

        private void BtnListarSala_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormListarSala formListarSala = new FormListarSala
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formListarSala);
            formListarSala.Show();
        }

        private void BtnListarSala_Click_1(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormListarSala formListarSala = new FormListarSala
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formListarSala);
            formListarSala.Show();
        }
    }
}
