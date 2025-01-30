namespace SistemadeGestãodeSalas.Forms.Reservas
{
    partial class FormReservarSala
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
            this.LblCadastro = new System.Windows.Forms.Label();
            this.LblSalas = new System.Windows.Forms.Label();
            this.LblCodigodoProfessor = new System.Windows.Forms.Label();
            this.TxtCodigoProfessor = new System.Windows.Forms.TextBox();
            this.LblData = new System.Windows.Forms.Label();
            this.DtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.DtpHoraInicial = new System.Windows.Forms.DateTimePicker();
            this.LblHoraInicial = new System.Windows.Forms.Label();
            this.DtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.LblHoraFinal = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtCodigoSala = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(40, 40);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(202, 33);
            this.LblCadastro.TabIndex = 9;
            this.LblCadastro.Text = "Reservar Sala";
            this.LblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSalas
            // 
            this.LblSalas.AutoSize = true;
            this.LblSalas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalas.Location = new System.Drawing.Point(40, 100);
            this.LblSalas.Name = "LblSalas";
            this.LblSalas.Size = new System.Drawing.Size(151, 23);
            this.LblSalas.TabIndex = 10;
            this.LblSalas.Text = "Código da Sala:";
            this.LblSalas.Click += new System.EventHandler(this.LblSalas_Click);
            // 
            // LblCodigodoProfessor
            // 
            this.LblCodigodoProfessor.AutoSize = true;
            this.LblCodigodoProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigodoProfessor.Location = new System.Drawing.Point(40, 200);
            this.LblCodigodoProfessor.Name = "LblCodigodoProfessor";
            this.LblCodigodoProfessor.Size = new System.Drawing.Size(198, 23);
            this.LblCodigodoProfessor.TabIndex = 12;
            this.LblCodigodoProfessor.Text = "Código do Professor:";
            // 
            // TxtCodigoProfessor
            // 
            this.TxtCodigoProfessor.Location = new System.Drawing.Point(46, 240);
            this.TxtCodigoProfessor.Name = "TxtCodigoProfessor";
            this.TxtCodigoProfessor.Size = new System.Drawing.Size(400, 22);
            this.TxtCodigoProfessor.TabIndex = 13;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(40, 300);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(165, 23);
            this.LblData.TabIndex = 14;
            this.LblData.Text = "Data da Reserva:";
            // 
            // DtpDataReserva
            // 
            this.DtpDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataReserva.Location = new System.Drawing.Point(46, 340);
            this.DtpDataReserva.Name = "DtpDataReserva";
            this.DtpDataReserva.Size = new System.Drawing.Size(157, 22);
            this.DtpDataReserva.TabIndex = 15;
            // 
            // DtpHoraInicial
            // 
            this.DtpHoraInicial.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraInicial.Location = new System.Drawing.Point(48, 440);
            this.DtpHoraInicial.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.DtpHoraInicial.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.DtpHoraInicial.Name = "DtpHoraInicial";
            this.DtpHoraInicial.ShowUpDown = true;
            this.DtpHoraInicial.Size = new System.Drawing.Size(107, 22);
            this.DtpHoraInicial.TabIndex = 17;
            // 
            // LblHoraInicial
            // 
            this.LblHoraInicial.AutoSize = true;
            this.LblHoraInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraInicial.Location = new System.Drawing.Point(42, 400);
            this.LblHoraInicial.Name = "LblHoraInicial";
            this.LblHoraInicial.Size = new System.Drawing.Size(113, 23);
            this.LblHoraInicial.TabIndex = 16;
            this.LblHoraInicial.Text = "Hora Inicial:";
            // 
            // DtpHoraFinal
            // 
            this.DtpHoraFinal.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraFinal.Location = new System.Drawing.Point(230, 440);
            this.DtpHoraFinal.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.DtpHoraFinal.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.DtpHoraFinal.Name = "DtpHoraFinal";
            this.DtpHoraFinal.ShowUpDown = true;
            this.DtpHoraFinal.Size = new System.Drawing.Size(107, 22);
            this.DtpHoraFinal.TabIndex = 19;
            // 
            // LblHoraFinal
            // 
            this.LblHoraFinal.AutoSize = true;
            this.LblHoraFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraFinal.Location = new System.Drawing.Point(224, 400);
            this.LblHoraFinal.Name = "LblHoraFinal";
            this.LblHoraFinal.Size = new System.Drawing.Size(105, 23);
            this.LblHoraFinal.TabIndex = 18;
            this.LblHoraFinal.Text = "Hora Final:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(40, 500);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(116, 40);
            this.BtnSalvar.TabIndex = 20;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtCodigoSala
            // 
            this.TxtCodigoSala.Location = new System.Drawing.Point(46, 140);
            this.TxtCodigoSala.Name = "TxtCodigoSala";
            this.TxtCodigoSala.Size = new System.Drawing.Size(400, 22);
            this.TxtCodigoSala.TabIndex = 21;
            // 
            // FormReservarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.TxtCodigoSala);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DtpHoraFinal);
            this.Controls.Add(this.LblHoraFinal);
            this.Controls.Add(this.DtpHoraInicial);
            this.Controls.Add(this.LblHoraInicial);
            this.Controls.Add(this.DtpDataReserva);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.TxtCodigoProfessor);
            this.Controls.Add(this.LblCodigodoProfessor);
            this.Controls.Add(this.LblSalas);
            this.Controls.Add(this.LblCadastro);
            this.Name = "FormReservarSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Label LblSalas;
        private System.Windows.Forms.Label LblCodigodoProfessor;
        private System.Windows.Forms.TextBox TxtCodigoProfessor;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.DateTimePicker DtpDataReserva;
        private System.Windows.Forms.DateTimePicker DtpHoraInicial;
        private System.Windows.Forms.Label LblHoraInicial;
        private System.Windows.Forms.DateTimePicker DtpHoraFinal;
        private System.Windows.Forms.Label LblHoraFinal;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtCodigoSala;
    }
}