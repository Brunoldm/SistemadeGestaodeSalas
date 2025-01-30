namespace SistemadeGestãodeSalas
{
    partial class FormProfessores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PanelProfessor = new System.Windows.Forms.Panel();
            this.BtnCadastrarProfessor = new System.Windows.Forms.Button();
            this.BtnListarProfessor = new System.Windows.Forms.Button();
            this.BtnExcluirProfessor = new System.Windows.Forms.Button();
            this.BtnModificarProfessor = new System.Windows.Forms.Button();
            this.PanelProfessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.LblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(40, 40);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(312, 32);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Gestão de Professores";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelProfessor
            // 
            this.PanelProfessor.AutoSize = true;
            this.PanelProfessor.BackColor = System.Drawing.Color.DarkGray;
            this.PanelProfessor.Controls.Add(this.BtnCadastrarProfessor);
            this.PanelProfessor.Controls.Add(this.BtnListarProfessor);
            this.PanelProfessor.Controls.Add(this.BtnExcluirProfessor);
            this.PanelProfessor.Controls.Add(this.BtnModificarProfessor);
            this.PanelProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProfessor.Location = new System.Drawing.Point(0, 0);
            this.PanelProfessor.Name = "PanelProfessor";
            this.PanelProfessor.Size = new System.Drawing.Size(736, 721);
            this.PanelProfessor.TabIndex = 6;
            this.PanelProfessor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProfessor_Paint);
            // 
            // BtnCadastrarProfessor
            // 
            this.BtnCadastrarProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrarProfessor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCadastrarProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrarProfessor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCadastrarProfessor.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarProfessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCadastrarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrarProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarProfessor.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarProfessor.Location = new System.Drawing.Point(104, 120);
            this.BtnCadastrarProfessor.Name = "BtnCadastrarProfessor";
            this.BtnCadastrarProfessor.Size = new System.Drawing.Size(528, 35);
            this.BtnCadastrarProfessor.TabIndex = 1;
            this.BtnCadastrarProfessor.Text = "Cadastrar";
            this.BtnCadastrarProfessor.UseVisualStyleBackColor = false;
            this.BtnCadastrarProfessor.UseWaitCursor = true;
            this.BtnCadastrarProfessor.Click += new System.EventHandler(this.BtnCadastrarProfessor_Click);
            // 
            // BtnListarProfessor
            // 
            this.BtnListarProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarProfessor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnListarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListarProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnListarProfessor.ForeColor = System.Drawing.Color.White;
            this.BtnListarProfessor.Location = new System.Drawing.Point(104, 360);
            this.BtnListarProfessor.Name = "BtnListarProfessor";
            this.BtnListarProfessor.Size = new System.Drawing.Size(528, 35);
            this.BtnListarProfessor.TabIndex = 4;
            this.BtnListarProfessor.Text = "Listar";
            this.BtnListarProfessor.UseVisualStyleBackColor = false;
            this.BtnListarProfessor.Click += new System.EventHandler(this.BtnListarProfessor_Click);
            // 
            // BtnExcluirProfessor
            // 
            this.BtnExcluirProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluirProfessor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnExcluirProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluirProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnExcluirProfessor.ForeColor = System.Drawing.Color.White;
            this.BtnExcluirProfessor.Location = new System.Drawing.Point(104, 280);
            this.BtnExcluirProfessor.Name = "BtnExcluirProfessor";
            this.BtnExcluirProfessor.Size = new System.Drawing.Size(528, 35);
            this.BtnExcluirProfessor.TabIndex = 3;
            this.BtnExcluirProfessor.Text = "Excluir";
            this.BtnExcluirProfessor.UseVisualStyleBackColor = false;
            this.BtnExcluirProfessor.Click += new System.EventHandler(this.BtnExcluirProfessor_Click);
            // 
            // BtnModificarProfessor
            // 
            this.BtnModificarProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarProfessor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnModificarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnModificarProfessor.ForeColor = System.Drawing.Color.White;
            this.BtnModificarProfessor.Location = new System.Drawing.Point(104, 200);
            this.BtnModificarProfessor.Name = "BtnModificarProfessor";
            this.BtnModificarProfessor.Size = new System.Drawing.Size(528, 35);
            this.BtnModificarProfessor.TabIndex = 2;
            this.BtnModificarProfessor.Text = "Modificar";
            this.BtnModificarProfessor.UseVisualStyleBackColor = false;
            this.BtnModificarProfessor.Click += new System.EventHandler(this.BtnModificarProfessor_Click);
            // 
            // FormProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 721);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PanelProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfessores";
            this.Load += new System.EventHandler(this.FormProfessores_Load);
            this.PanelProfessor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PanelProfessor;
        private System.Windows.Forms.Button BtnCadastrarProfessor;
        private System.Windows.Forms.Button BtnListarProfessor;
        private System.Windows.Forms.Button BtnExcluirProfessor;
        private System.Windows.Forms.Button BtnModificarProfessor;
    }
}