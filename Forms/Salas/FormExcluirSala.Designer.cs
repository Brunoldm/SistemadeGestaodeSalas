namespace SistemadeGestãodeSalas.Forms.Salas
{
    partial class FormExcluirSala
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
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtCodigoSala = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(40, 200);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(116, 40);
            this.BtnExcluir.TabIndex = 31;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TxtCodigoSala
            // 
            this.TxtCodigoSala.Location = new System.Drawing.Point(46, 140);
            this.TxtCodigoSala.Name = "TxtCodigoSala";
            this.TxtCodigoSala.Size = new System.Drawing.Size(400, 22);
            this.TxtCodigoSala.TabIndex = 30;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(40, 100);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(151, 23);
            this.LblCodigo.TabIndex = 29;
            this.LblCodigo.Text = "Código da Sala:";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(40, 40);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(177, 33);
            this.LblCadastro.TabIndex = 28;
            this.LblCadastro.Text = "Excluir Sala";
            this.LblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExcluirSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.TxtCodigoSala);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.LblCadastro);
            this.Name = "FormExcluirSala";
            this.Text = "FormExcluirSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtCodigoSala;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblCadastro;
    }
}