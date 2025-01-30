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
    public partial class FormProfessores : Form
    {
        private Panel _panelConteudo;
        public FormProfessores(Panel panelConteudo)
        {
            InitializeComponent();
            _panelConteudo = panelConteudo;

            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScaleDimensions = new SizeF(96F, 96F);

        }

        private void BtnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            // Limpa o painel e carrega o FormCadastrarProfessor
            _panelConteudo.Controls.Clear();

            FormCadastrarProfessor formCadastrarProfessor = new FormCadastrarProfessor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formCadastrarProfessor);
            formCadastrarProfessor.Show();
        }


        private void PanelProfessor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormProfessores_Load(object sender, EventArgs e)
        {

        }

        private void BtnModificarProfessor_Click(object sender, EventArgs e)
        {
            // Limpa os controles existentes no painel
            _panelConteudo.Controls.Clear();

            // Instancia o FormModificarProfessor
            FormModificarProfessor formModificarProfessor = new FormModificarProfessor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Adiciona ao painel e exibe
            _panelConteudo.Controls.Add(formModificarProfessor);
            formModificarProfessor.Show();
        }

        private void BtnExcluirProfessor_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormExcluirProfessor formExcluirProfessor = new FormExcluirProfessor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formExcluirProfessor);
            formExcluirProfessor.Show();
        }

        private void BtnListarProfessor_Click(object sender, EventArgs e)
        {
            _panelConteudo.Controls.Clear();

            FormListarProfessor formListarProfessor = new FormListarProfessor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            _panelConteudo.Controls.Add(formListarProfessor);
            formListarProfessor.Show();
        }

    }
}
