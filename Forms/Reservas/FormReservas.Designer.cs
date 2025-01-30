namespace SistemadeGestãodeSalas.Forms.Reservas
{
    partial class FormReservas
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
            this.BtnCadastrarReserva = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnListarReservas = new System.Windows.Forms.Button();
            this.BtnCancelarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCadastrarReserva
            // 
            this.BtnCadastrarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrarReserva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCadastrarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrarReserva.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCadastrarReserva.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrarReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarReserva.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarReserva.Location = new System.Drawing.Point(104, 120);
            this.BtnCadastrarReserva.Name = "BtnCadastrarReserva";
            this.BtnCadastrarReserva.Size = new System.Drawing.Size(446, 35);
            this.BtnCadastrarReserva.TabIndex = 9;
            this.BtnCadastrarReserva.Text = "Cadastrar Reserva";
            this.BtnCadastrarReserva.UseVisualStyleBackColor = false;
            this.BtnCadastrarReserva.UseWaitCursor = true;
            this.BtnCadastrarReserva.Click += new System.EventHandler(this.BtnCadastrarReserva_Click);
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
            this.LblTitulo.Size = new System.Drawing.Size(275, 32);
            this.LblTitulo.TabIndex = 10;
            this.LblTitulo.Text = "Gestão de Reservas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnListarReservas
            // 
            this.BtnListarReservas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarReservas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnListarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListarReservas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnListarReservas.ForeColor = System.Drawing.Color.White;
            this.BtnListarReservas.Location = new System.Drawing.Point(104, 280);
            this.BtnListarReservas.Name = "BtnListarReservas";
            this.BtnListarReservas.Size = new System.Drawing.Size(446, 35);
            this.BtnListarReservas.TabIndex = 12;
            this.BtnListarReservas.Text = "Listar Reservas";
            this.BtnListarReservas.UseVisualStyleBackColor = false;
            this.BtnListarReservas.Click += new System.EventHandler(this.BtnListarReservas_Click);
            // 
            // BtnCancelarReserva
            // 
            this.BtnCancelarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarReserva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelarReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancelarReserva.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarReserva.Location = new System.Drawing.Point(104, 200);
            this.BtnCancelarReserva.Name = "BtnCancelarReserva";
            this.BtnCancelarReserva.Size = new System.Drawing.Size(446, 35);
            this.BtnCancelarReserva.TabIndex = 11;
            this.BtnCancelarReserva.Text = "Cancelar Reserva";
            this.BtnCancelarReserva.UseVisualStyleBackColor = false;
            this.BtnCancelarReserva.Click += new System.EventHandler(this.BtnCancelarReserva_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.BtnCadastrarReserva);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnListarReservas);
            this.Controls.Add(this.BtnCancelarReserva);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrarReserva;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnListarReservas;
        private System.Windows.Forms.Button BtnCancelarReserva;
    }
}