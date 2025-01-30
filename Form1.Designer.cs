namespace SistemadeGestãodeSalas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.BtnReservas = new System.Windows.Forms.Button();
            this.BtnSalas = new System.Windows.Forms.Button();
            this.TituloGestao = new System.Windows.Forms.Label();
            this.BtnProfessores = new System.Windows.Forms.Button();
            this.PanelConteudo = new System.Windows.Forms.Panel();
            this.PanelMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.BackColor = System.Drawing.Color.Navy;
            this.PanelMenuLateral.Controls.Add(this.BtnReservas);
            this.PanelMenuLateral.Controls.Add(this.BtnSalas);
            this.PanelMenuLateral.Controls.Add(this.TituloGestao);
            this.PanelMenuLateral.Controls.Add(this.BtnProfessores);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(270, 721);
            this.PanelMenuLateral.TabIndex = 0;
            this.PanelMenuLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenuLateral_Paint);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReservas.AutoSize = true;
            this.BtnReservas.BackColor = System.Drawing.Color.White;
            this.BtnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservas.Location = new System.Drawing.Point(15, 150);
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Size = new System.Drawing.Size(170, 35);
            this.BtnReservas.TabIndex = 4;
            this.BtnReservas.Text = "Reservas";
            this.BtnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReservas.UseVisualStyleBackColor = false;
            this.BtnReservas.Click += new System.EventHandler(this.BtnReservas_Click);
            // 
            // BtnSalas
            // 
            this.BtnSalas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalas.AutoSize = true;
            this.BtnSalas.BackColor = System.Drawing.Color.White;
            this.BtnSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalas.Location = new System.Drawing.Point(15, 100);
            this.BtnSalas.Name = "BtnSalas";
            this.BtnSalas.Size = new System.Drawing.Size(170, 35);
            this.BtnSalas.TabIndex = 3;
            this.BtnSalas.Text = "Salas";
            this.BtnSalas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalas.UseVisualStyleBackColor = false;
            this.BtnSalas.Click += new System.EventHandler(this.BtnSalas_Click);
            // 
            // TituloGestao
            // 
            this.TituloGestao.AutoSize = true;
            this.TituloGestao.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.TituloGestao.ForeColor = System.Drawing.Color.White;
            this.TituloGestao.Location = new System.Drawing.Point(10, 10);
            this.TituloGestao.Name = "TituloGestao";
            this.TituloGestao.Size = new System.Drawing.Size(240, 29);
            this.TituloGestao.TabIndex = 2;
            this.TituloGestao.Text = "Gestão de Reservas";
            this.TituloGestao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloGestao.Click += new System.EventHandler(this.TituloGestao_Click);
            // 
            // BtnProfessores
            // 
            this.BtnProfessores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProfessores.AutoSize = true;
            this.BtnProfessores.BackColor = System.Drawing.Color.White;
            this.BtnProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfessores.Location = new System.Drawing.Point(15, 50);
            this.BtnProfessores.Name = "BtnProfessores";
            this.BtnProfessores.Size = new System.Drawing.Size(170, 35);
            this.BtnProfessores.TabIndex = 1;
            this.BtnProfessores.Text = "Professores";
            this.BtnProfessores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProfessores.UseVisualStyleBackColor = false;
            this.BtnProfessores.Click += new System.EventHandler(this.BtnProfessores_Click);
            // 
            // PanelConteudo
            // 
            this.PanelConteudo.BackColor = System.Drawing.Color.White;
            this.PanelConteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelConteudo.Location = new System.Drawing.Point(270, 0);
            this.PanelConteudo.Name = "PanelConteudo";
            this.PanelConteudo.Size = new System.Drawing.Size(736, 721);
            this.PanelConteudo.TabIndex = 1;
            this.PanelConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelConteudo_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.PanelConteudo);
            this.Controls.Add(this.PanelMenuLateral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenuLateral.ResumeLayout(false);
            this.PanelMenuLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Label TituloGestao;
        private System.Windows.Forms.Button BtnProfessores;
        private System.Windows.Forms.Button BtnReservas;
        private System.Windows.Forms.Button BtnSalas;
        private System.Windows.Forms.Panel PanelConteudo;
    }
}

