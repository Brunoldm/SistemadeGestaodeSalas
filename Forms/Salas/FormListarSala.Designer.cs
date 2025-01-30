namespace SistemadeGestãodeSalas.Forms.Salas
{
    partial class FormListarSala
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
            this.DgvSalas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.LblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(20, 20);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(168, 32);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Listar Salas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvSalas
            // 
            this.DgvSalas.AllowUserToAddRows = false;
            this.DgvSalas.AllowUserToDeleteRows = false;
            this.DgvSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSalas.Location = new System.Drawing.Point(0, 0);
            this.DgvSalas.Name = "DgvSalas";
            this.DgvSalas.ReadOnly = true;
            this.DgvSalas.RowHeadersWidth = 51;
            this.DgvSalas.RowTemplate.Height = 24;
            this.DgvSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSalas.Size = new System.Drawing.Size(718, 674);
            this.DgvSalas.TabIndex = 3;
            this.DgvSalas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalas_CellContentClick);
            // 
            // FormListarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.DgvSalas);
            this.Name = "FormListarSala";
            this.Text = "FormListarSala";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvSalas;
    }
}