namespace SistemadeGestãodeSalas
{
    partial class FormModificarProfessor
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.DtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblDatadenascimento = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblModificarProfessor = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnBuscarProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(40, 520);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(116, 40);
            this.BtnModificar.TabIndex = 15;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // DtpDataNascimento
            // 
            this.DtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataNascimento.Location = new System.Drawing.Point(46, 460);
            this.DtpDataNascimento.Name = "DtpDataNascimento";
            this.DtpDataNascimento.Size = new System.Drawing.Size(153, 22);
            this.DtpDataNascimento.TabIndex = 14;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(46, 360);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(400, 22);
            this.TxtCPF.TabIndex = 13;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(46, 260);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(400, 22);
            this.TxtNome.TabIndex = 12;
            // 
            // LblDatadenascimento
            // 
            this.LblDatadenascimento.AutoSize = true;
            this.LblDatadenascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatadenascimento.Location = new System.Drawing.Point(40, 420);
            this.LblDatadenascimento.Name = "LblDatadenascimento";
            this.LblDatadenascimento.Size = new System.Drawing.Size(194, 23);
            this.LblDatadenascimento.TabIndex = 11;
            this.LblDatadenascimento.Text = "Data de Nascimento:";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(40, 320);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(55, 23);
            this.LblCpf.TabIndex = 10;
            this.LblCpf.Text = "CPF:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(40, 220);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(67, 23);
            this.LblName.TabIndex = 9;
            this.LblName.Text = "Nome:";
            // 
            // LblModificarProfessor
            // 
            this.LblModificarProfessor.AutoSize = true;
            this.LblModificarProfessor.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificarProfessor.Location = new System.Drawing.Point(40, 40);
            this.LblModificarProfessor.Name = "LblModificarProfessor";
            this.LblModificarProfessor.Size = new System.Drawing.Size(279, 33);
            this.LblModificarProfessor.TabIndex = 8;
            this.LblModificarProfessor.Text = "Modificar Professor";
            this.LblModificarProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblModificarProfessor.Click += new System.EventHandler(this.LblModificarProfessor_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(40, 120);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(198, 23);
            this.LblCodigo.TabIndex = 16;
            this.LblCodigo.Text = "Código do Professor:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(46, 160);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(400, 22);
            this.TxtCodigo.TabIndex = 17;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // BtnBuscarProfessor
            // 
            this.BtnBuscarProfessor.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnBuscarProfessor.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnBuscarProfessor.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProfessor.Location = new System.Drawing.Point(509, 148);
            this.BtnBuscarProfessor.Name = "BtnBuscarProfessor";
            this.BtnBuscarProfessor.Size = new System.Drawing.Size(116, 40);
            this.BtnBuscarProfessor.TabIndex = 26;
            this.BtnBuscarProfessor.Text = "Buscar";
            this.BtnBuscarProfessor.UseVisualStyleBackColor = false;
            this.BtnBuscarProfessor.Click += new System.EventHandler(this.BtnBuscarProfessor_Click);
            // 
            // FormModificarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.BtnBuscarProfessor);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DtpDataNascimento);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblDatadenascimento);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblModificarProfessor);
            this.Name = "FormModificarProfessor";
            this.Text = "FormModificarProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DateTimePicker DtpDataNascimento;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblDatadenascimento;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblModificarProfessor;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnBuscarProfessor;
    }
}