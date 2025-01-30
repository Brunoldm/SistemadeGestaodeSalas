namespace SistemadeGestãodeSalas
{
    partial class FormExcluirProfessor
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
            this.LblApagarProfessor = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.LblCpf = new System.Windows.Forms.Label();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblApagarProfessor
            // 
            this.LblApagarProfessor.AutoSize = true;
            this.LblApagarProfessor.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApagarProfessor.Location = new System.Drawing.Point(40, 40);
            this.LblApagarProfessor.Name = "LblApagarProfessor";
            this.LblApagarProfessor.Size = new System.Drawing.Size(248, 33);
            this.LblApagarProfessor.TabIndex = 9;
            this.LblApagarProfessor.Text = "Apagar Professor";
            this.LblApagarProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(46, 160);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(400, 22);
            this.TxtCodigo.TabIndex = 19;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(40, 120);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(198, 23);
            this.LblCodigo.TabIndex = 18;
            this.LblCodigo.Text = "Código do Professor:";
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(46, 260);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(400, 22);
            this.TxtCPF.TabIndex = 21;
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(40, 220);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(55, 23);
            this.LblCpf.TabIndex = 20;
            this.LblCpf.Text = "CPF:";
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnApagar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnApagar.FlatAppearance.BorderSize = 0;
            this.BtnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar.Location = new System.Drawing.Point(40, 320);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(116, 40);
            this.BtnApagar.TabIndex = 22;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // FormExcluirProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.LblApagarProfessor);
            this.Name = "FormExcluirProfessor";
            this.Text = "FormExcluirProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApagarProfessor;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Button BtnApagar;
    }
}