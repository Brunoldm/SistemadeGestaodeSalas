namespace SistemadeGestãodeSalas.Forms.Salas
{
    partial class FormSalas
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
            this.BtnCadastrarSala = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnListarSala = new System.Windows.Forms.Button();
            this.BtnExcluirSala = new System.Windows.Forms.Button();
            this.BtnModificarSala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCadastrarSala
            // 
            this.BtnCadastrarSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrarSala.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCadastrarSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrarSala.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCadastrarSala.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarSala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCadastrarSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrarSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarSala.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarSala.Location = new System.Drawing.Point(104, 120);
            this.BtnCadastrarSala.Name = "BtnCadastrarSala";
            this.BtnCadastrarSala.Size = new System.Drawing.Size(446, 35);
            this.BtnCadastrarSala.TabIndex = 5;
            this.BtnCadastrarSala.Text = "Cadastrar";
            this.BtnCadastrarSala.UseVisualStyleBackColor = false;
            this.BtnCadastrarSala.UseWaitCursor = true;
            this.BtnCadastrarSala.Click += new System.EventHandler(this.BtnCadastrarSala_Click);
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
            this.LblTitulo.Size = new System.Drawing.Size(225, 32);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Gestão de Salas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnListarSala
            // 
            this.BtnListarSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarSala.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnListarSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListarSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnListarSala.ForeColor = System.Drawing.Color.White;
            this.BtnListarSala.Location = new System.Drawing.Point(104, 360);
            this.BtnListarSala.Name = "BtnListarSala";
            this.BtnListarSala.Size = new System.Drawing.Size(446, 35);
            this.BtnListarSala.TabIndex = 9;
            this.BtnListarSala.Text = "Listar";
            this.BtnListarSala.UseVisualStyleBackColor = false;
            this.BtnListarSala.Click += new System.EventHandler(this.BtnListarSala_Click_1);
            // 
            // BtnExcluirSala
            // 
            this.BtnExcluirSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluirSala.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnExcluirSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluirSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnExcluirSala.ForeColor = System.Drawing.Color.White;
            this.BtnExcluirSala.Location = new System.Drawing.Point(104, 280);
            this.BtnExcluirSala.Name = "BtnExcluirSala";
            this.BtnExcluirSala.Size = new System.Drawing.Size(446, 35);
            this.BtnExcluirSala.TabIndex = 8;
            this.BtnExcluirSala.Text = "Excluir";
            this.BtnExcluirSala.UseVisualStyleBackColor = false;
            this.BtnExcluirSala.Click += new System.EventHandler(this.BtnExcluirSala_Click);
            // 
            // BtnModificarSala
            // 
            this.BtnModificarSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarSala.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnModificarSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnModificarSala.ForeColor = System.Drawing.Color.White;
            this.BtnModificarSala.Location = new System.Drawing.Point(104, 200);
            this.BtnModificarSala.Name = "BtnModificarSala";
            this.BtnModificarSala.Size = new System.Drawing.Size(446, 35);
            this.BtnModificarSala.TabIndex = 7;
            this.BtnModificarSala.Text = "Modificar";
            this.BtnModificarSala.UseVisualStyleBackColor = false;
            this.BtnModificarSala.Click += new System.EventHandler(this.BtnModificarSala_Click);
            // 
            // FormSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.BtnCadastrarSala);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnListarSala);
            this.Controls.Add(this.BtnExcluirSala);
            this.Controls.Add(this.BtnModificarSala);
            this.Name = "FormSalas";
            this.Text = "FormSalas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrarSala;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnListarSala;
        private System.Windows.Forms.Button BtnExcluirSala;
        private System.Windows.Forms.Button BtnModificarSala;
    }
}