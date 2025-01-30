namespace SistemadeGestãodeSalas.Forms.Salas
{
    partial class FormCadastrarSala
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtNomeSala = new System.Windows.Forms.TextBox();
            this.LblNomedaSala = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.LblTipodeSala = new System.Windows.Forms.Label();
            this.CmbTipoSala = new System.Windows.Forms.ComboBox();
            this.LblCapacidade = new System.Windows.Forms.Label();
            this.NumCapacidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumCapacidade)).BeginInit();
            this.SuspendLayout();
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
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtNomeSala
            // 
            this.TxtNomeSala.Location = new System.Drawing.Point(46, 140);
            this.TxtNomeSala.Name = "TxtNomeSala";
            this.TxtNomeSala.Size = new System.Drawing.Size(400, 22);
            this.TxtNomeSala.TabIndex = 10;
            // 
            // LblNomedaSala
            // 
            this.LblNomedaSala.AutoSize = true;
            this.LblNomedaSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomedaSala.Location = new System.Drawing.Point(40, 100);
            this.LblNomedaSala.Name = "LblNomedaSala";
            this.LblNomedaSala.Size = new System.Drawing.Size(140, 23);
            this.LblNomedaSala.TabIndex = 9;
            this.LblNomedaSala.Text = "Nome da Sala:";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(40, 40);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(213, 33);
            this.LblCadastro.TabIndex = 8;
            this.LblCadastro.Text = "Cadastrar Sala";
            this.LblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTipodeSala
            // 
            this.LblTipodeSala.AutoSize = true;
            this.LblTipodeSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipodeSala.Location = new System.Drawing.Point(40, 200);
            this.LblTipodeSala.Name = "LblTipodeSala";
            this.LblTipodeSala.Size = new System.Drawing.Size(126, 23);
            this.LblTipodeSala.TabIndex = 12;
            this.LblTipodeSala.Text = "Tipo de Sala:";
            // 
            // CmbTipoSala
            // 
            this.CmbTipoSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoSala.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoSala.FormattingEnabled = true;
            this.CmbTipoSala.Items.AddRange(new object[] {
            "Laboratório",
            "Sala de Aula",
            "Auditório"});
            this.CmbTipoSala.Location = new System.Drawing.Point(46, 240);
            this.CmbTipoSala.Name = "CmbTipoSala";
            this.CmbTipoSala.Size = new System.Drawing.Size(158, 27);
            this.CmbTipoSala.TabIndex = 13;
            this.CmbTipoSala.SelectedIndexChanged += new System.EventHandler(this.CmbTipoSala_SelectedIndexChanged);
            // 
            // LblCapacidade
            // 
            this.LblCapacidade.AutoSize = true;
            this.LblCapacidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCapacidade.Location = new System.Drawing.Point(40, 300);
            this.LblCapacidade.Name = "LblCapacidade";
            this.LblCapacidade.Size = new System.Drawing.Size(121, 23);
            this.LblCapacidade.TabIndex = 14;
            this.LblCapacidade.Text = "Capacidade:";
            // 
            // NumCapacidade
            // 
            this.NumCapacidade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCapacidade.Location = new System.Drawing.Point(46, 340);
            this.NumCapacidade.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumCapacidade.Name = "NumCapacidade";
            this.NumCapacidade.Size = new System.Drawing.Size(120, 27);
            this.NumCapacidade.TabIndex = 15;
            // 
            // FormCadastrarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.NumCapacidade);
            this.Controls.Add(this.LblCapacidade);
            this.Controls.Add(this.CmbTipoSala);
            this.Controls.Add(this.LblTipodeSala);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtNomeSala);
            this.Controls.Add(this.LblNomedaSala);
            this.Controls.Add(this.LblCadastro);
            this.Name = "FormCadastrarSala";
            this.Text = "FormCadastrarSala";
            ((System.ComponentModel.ISupportInitialize)(this.NumCapacidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtNomeSala;
        private System.Windows.Forms.Label LblNomedaSala;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Label LblTipodeSala;
        private System.Windows.Forms.ComboBox CmbTipoSala;
        private System.Windows.Forms.Label LblCapacidade;
        private System.Windows.Forms.NumericUpDown NumCapacidade;
    }
}