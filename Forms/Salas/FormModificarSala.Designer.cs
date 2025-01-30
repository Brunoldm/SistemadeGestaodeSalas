namespace SistemadeGestãodeSalas.Forms.Salas
{
    partial class FormModificarSala
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
            this.NumCapacidade = new System.Windows.Forms.NumericUpDown();
            this.CmbTipoSala = new System.Windows.Forms.ComboBox();
            this.LblTipodeSala = new System.Windows.Forms.Label();
            this.TxtNomeSala = new System.Windows.Forms.TextBox();
            this.LblNomedaSala = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.TxtCodigoSala = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnBuscarSala = new System.Windows.Forms.Button();
            this.LblCapacidade = new System.Windows.Forms.Label();
            this.BtnSalvarAlteracoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumCapacidade)).BeginInit();
            this.SuspendLayout();
            // 
            // NumCapacidade
            // 
            this.NumCapacidade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCapacidade.Location = new System.Drawing.Point(46, 440);
            this.NumCapacidade.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumCapacidade.Name = "NumCapacidade";
            this.NumCapacidade.Size = new System.Drawing.Size(120, 27);
            this.NumCapacidade.TabIndex = 22;
            // 
            // CmbTipoSala
            // 
            this.CmbTipoSala.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoSala.FormattingEnabled = true;
            this.CmbTipoSala.Items.AddRange(new object[] {
            "Laboratório",
            "Sala de Aula",
            "Auditório"});
            this.CmbTipoSala.Location = new System.Drawing.Point(46, 340);
            this.CmbTipoSala.Name = "CmbTipoSala";
            this.CmbTipoSala.Size = new System.Drawing.Size(158, 27);
            this.CmbTipoSala.TabIndex = 21;
            // 
            // LblTipodeSala
            // 
            this.LblTipodeSala.AutoSize = true;
            this.LblTipodeSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipodeSala.Location = new System.Drawing.Point(40, 300);
            this.LblTipodeSala.Name = "LblTipodeSala";
            this.LblTipodeSala.Size = new System.Drawing.Size(126, 23);
            this.LblTipodeSala.TabIndex = 20;
            this.LblTipodeSala.Text = "Tipo de Sala:";
            // 
            // TxtNomeSala
            // 
            this.TxtNomeSala.Location = new System.Drawing.Point(46, 240);
            this.TxtNomeSala.Name = "TxtNomeSala";
            this.TxtNomeSala.Size = new System.Drawing.Size(400, 22);
            this.TxtNomeSala.TabIndex = 18;
            // 
            // LblNomedaSala
            // 
            this.LblNomedaSala.AutoSize = true;
            this.LblNomedaSala.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomedaSala.Location = new System.Drawing.Point(40, 200);
            this.LblNomedaSala.Name = "LblNomedaSala";
            this.LblNomedaSala.Size = new System.Drawing.Size(140, 23);
            this.LblNomedaSala.TabIndex = 17;
            this.LblNomedaSala.Text = "Nome da Sala:";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(40, 40);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(209, 33);
            this.LblCadastro.TabIndex = 16;
            this.LblCadastro.Text = "Modificar Sala";
            this.LblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoSala
            // 
            this.TxtCodigoSala.Location = new System.Drawing.Point(46, 140);
            this.TxtCodigoSala.Name = "TxtCodigoSala";
            this.TxtCodigoSala.Size = new System.Drawing.Size(400, 22);
            this.TxtCodigoSala.TabIndex = 24;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(40, 100);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(151, 23);
            this.LblCodigo.TabIndex = 23;
            this.LblCodigo.Text = "Código da Sala:";
            // 
            // BtnBuscarSala
            // 
            this.BtnBuscarSala.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnBuscarSala.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnBuscarSala.FlatAppearance.BorderSize = 0;
            this.BtnBuscarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarSala.Location = new System.Drawing.Point(497, 128);
            this.BtnBuscarSala.Name = "BtnBuscarSala";
            this.BtnBuscarSala.Size = new System.Drawing.Size(116, 40);
            this.BtnBuscarSala.TabIndex = 25;
            this.BtnBuscarSala.Text = "Buscar";
            this.BtnBuscarSala.UseVisualStyleBackColor = false;
            this.BtnBuscarSala.Click += new System.EventHandler(this.BtnBuscarSala_Click);
            // 
            // LblCapacidade
            // 
            this.LblCapacidade.AutoSize = true;
            this.LblCapacidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCapacidade.Location = new System.Drawing.Point(40, 400);
            this.LblCapacidade.Name = "LblCapacidade";
            this.LblCapacidade.Size = new System.Drawing.Size(121, 23);
            this.LblCapacidade.TabIndex = 26;
            this.LblCapacidade.Text = "Capacidade:";
            // 
            // BtnSalvarAlteracoes
            // 
            this.BtnSalvarAlteracoes.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnSalvarAlteracoes.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnSalvarAlteracoes.FlatAppearance.BorderSize = 0;
            this.BtnSalvarAlteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarAlteracoes.Location = new System.Drawing.Point(40, 500);
            this.BtnSalvarAlteracoes.Name = "BtnSalvarAlteracoes";
            this.BtnSalvarAlteracoes.Size = new System.Drawing.Size(116, 40);
            this.BtnSalvarAlteracoes.TabIndex = 27;
            this.BtnSalvarAlteracoes.Text = "Salvar";
            this.BtnSalvarAlteracoes.UseVisualStyleBackColor = false;
            // 
            // FormModificarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.BtnSalvarAlteracoes);
            this.Controls.Add(this.LblCapacidade);
            this.Controls.Add(this.BtnBuscarSala);
            this.Controls.Add(this.TxtCodigoSala);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.NumCapacidade);
            this.Controls.Add(this.CmbTipoSala);
            this.Controls.Add(this.LblTipodeSala);
            this.Controls.Add(this.TxtNomeSala);
            this.Controls.Add(this.LblNomedaSala);
            this.Controls.Add(this.LblCadastro);
            this.Name = "FormModificarSala";
            this.Text = "FormModificarSala";
            this.Load += new System.EventHandler(this.FormModificarSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCapacidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumCapacidade;
        private System.Windows.Forms.ComboBox CmbTipoSala;
        private System.Windows.Forms.Label LblTipodeSala;
        private System.Windows.Forms.TextBox TxtNomeSala;
        private System.Windows.Forms.Label LblNomedaSala;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.TextBox TxtCodigoSala;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnBuscarSala;
        private System.Windows.Forms.Label LblCapacidade;
        private System.Windows.Forms.Button BtnSalvarAlteracoes;
    }
}