namespace SistemadeGestãodeSalas.Forms.Reservas
{
    partial class FormCancelarReserva
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
            this.TxtCodigoReserva = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnCancelarReserva = new System.Windows.Forms.Button();
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
            this.LblTitulo.Size = new System.Drawing.Size(244, 32);
            this.LblTitulo.TabIndex = 11;
            this.LblTitulo.Text = "Cancelar Reserva";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoReserva
            // 
            this.TxtCodigoReserva.Location = new System.Drawing.Point(46, 140);
            this.TxtCodigoReserva.Name = "TxtCodigoReserva";
            this.TxtCodigoReserva.Size = new System.Drawing.Size(400, 22);
            this.TxtCodigoReserva.TabIndex = 32;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(40, 100);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(185, 23);
            this.LblCodigo.TabIndex = 31;
            this.LblCodigo.Text = "Código da Reserva:";
            // 
            // BtnCancelarReserva
            // 
            this.BtnCancelarReserva.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnCancelarReserva.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnCancelarReserva.FlatAppearance.BorderSize = 0;
            this.BtnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarReserva.Location = new System.Drawing.Point(40, 200);
            this.BtnCancelarReserva.Name = "BtnCancelarReserva";
            this.BtnCancelarReserva.Size = new System.Drawing.Size(203, 40);
            this.BtnCancelarReserva.TabIndex = 33;
            this.BtnCancelarReserva.Text = "Cancelar Reserva";
            this.BtnCancelarReserva.UseVisualStyleBackColor = false;
            this.BtnCancelarReserva.Click += new System.EventHandler(this.BtnCancelarReserva_Click);
            // 
            // FormCancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.BtnCancelarReserva);
            this.Controls.Add(this.TxtCodigoReserva);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FormCancelarReserva";
            this.Text = "FormCancelarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtCodigoReserva;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnCancelarReserva;
    }
}