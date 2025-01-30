using SistemadeGestãodeSalas.Forms.Reservas;
using SistemadeGestãodeSalas.Forms.Salas;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Abrir maximizado
            this.WindowState = FormWindowState.Maximized;

            // Definir escala automática
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScaleDimensions = new SizeF(96F, 96F);


            BtnProfessores.MouseEnter += Btn_MouseEnter;
            BtnProfessores.MouseLeave += Btn_MouseLeave;

            BtnSalas.MouseEnter += Btn_MouseEnter;
            BtnSalas.MouseLeave += Btn_MouseLeave;

            BtnReservas.MouseEnter += Btn_MouseEnter;
            BtnReservas.MouseLeave += Btn_MouseLeave;
        }
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightBlue; // Cor ao passar o mouse
            }
        }
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.White; // Cor padrão ou original
            }
        }

        private void PanelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnProfessores_Click(object sender, EventArgs e)
        {
            // Limpa os controles existentes no painel
            PanelConteudo.Controls.Clear();

            // Instancia o formulário de Professores, passando o painel de conteúdo
            FormProfessores formProfessores = new FormProfessores(PanelConteudo);

            // Configura o formulário como filho do painel
            formProfessores.TopLevel = false;
            formProfessores.FormBorderStyle = FormBorderStyle.None;
            formProfessores.Dock = DockStyle.Fill;

            // Adiciona o formulário ao painel
            PanelConteudo.Controls.Add(formProfessores);
            formProfessores.Show();
        }
        


        private void BtnSalas_Click(object sender, EventArgs e)
        {
            // Limpa os controles existentes no painel
            PanelConteudo.Controls.Clear();

            // Instancia o formulário de Salas, passando o painel de conteúdo
            FormSalas formSalas = new FormSalas(PanelConteudo);

            // Configura o formulário como filho do painel
            formSalas.TopLevel = false;
            formSalas.FormBorderStyle = FormBorderStyle.None;
            formSalas.Dock = DockStyle.Fill;

            // Adiciona o formulário ao painel e exibe
            PanelConteudo.Controls.Add(formSalas);
            formSalas.Show();
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            // Limpa os controles existentes no painel
            PanelConteudo.Controls.Clear();

            // Instancia o formulário de Salas, passando o painel de conteúdo
            FormReservas formReservas = new FormReservas(PanelConteudo);

            // Configura o formulário como filho do painel
            formReservas.TopLevel = false;
            formReservas.FormBorderStyle = FormBorderStyle.None;
            formReservas.Dock = DockStyle.Fill;

            // Adiciona o formulário ao painel e exibe
            PanelConteudo.Controls.Add(formReservas);
            formReservas.Show();
        }

        private void TituloGestao_Click(object sender, EventArgs e)
        {

        }


    }
}
