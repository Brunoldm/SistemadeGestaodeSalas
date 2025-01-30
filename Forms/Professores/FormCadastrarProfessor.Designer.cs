using System.Drawing;

namespace SistemadeGestãodeSalas
{
    partial class FormCadastrarProfessor
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblDatadenascimento = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.DtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(40, 40);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(283, 33);
            this.LblCadastro.TabIndex = 0;
            this.LblCadastro.Text = "Cadastrar Professor";
            this.LblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCadastro.Click += new System.EventHandler(this.LblCadastro_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(40, 100);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(67, 23);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nome:";
            this.LblName.Click += new System.EventHandler(this.LblName_Click);
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(40, 200);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(55, 23);
            this.LblCpf.TabIndex = 2;
            this.LblCpf.Text = "CPF:";
            this.LblCpf.Click += new System.EventHandler(this.LblCpf_Click);
            // 
            // LblDatadenascimento
            // 
            this.LblDatadenascimento.AutoSize = true;
            this.LblDatadenascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatadenascimento.Location = new System.Drawing.Point(40, 300);
            this.LblDatadenascimento.Name = "LblDatadenascimento";
            this.LblDatadenascimento.Size = new System.Drawing.Size(194, 23);
            this.LblDatadenascimento.TabIndex = 3;
            this.LblDatadenascimento.Text = "Data de Nascimento:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(46, 140);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(400, 22);
            this.TxtNome.TabIndex = 4;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(46, 240);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(400, 22);
            this.TxtCPF.TabIndex = 5;
            this.TxtCPF.TextChanged += new System.EventHandler(this.TxtCPF_TextChanged);
            this.TxtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCPF_KeyPress);
            // 
            // DtpDataNascimento
            // 
            this.DtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataNascimento.Location = new System.Drawing.Point(46, 340);
            this.DtpDataNascimento.Name = "DtpDataNascimento";
            this.DtpDataNascimento.Size = new System.Drawing.Size(153, 22);
            this.DtpDataNascimento.TabIndex = 6;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(40, 400);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(116, 40);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FormCadastrarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(736, 721);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DtpDataNascimento);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblDatadenascimento);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormCadastrarProfessor";
            this.Text = "FormCadastrarProfessor";
            this.Load += new System.EventHandler(this.FormCadastrarProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblDatadenascimento;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.DateTimePicker DtpDataNascimento;
        private System.Windows.Forms.Button BtnSalvar;
    }
}