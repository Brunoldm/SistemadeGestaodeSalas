namespace SistemadeGestãodeSalas
{
    partial class FormListarProfessor
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
            this.DgvProfessores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProfessores
            // 
            this.DgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfessores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProfessores.Location = new System.Drawing.Point(0, 0);
            this.DgvProfessores.Name = "DgvProfessores";
            this.DgvProfessores.RowHeadersWidth = 51;
            this.DgvProfessores.RowTemplate.Height = 24;
            this.DgvProfessores.Size = new System.Drawing.Size(718, 674);
            this.DgvProfessores.TabIndex = 0;
            this.DgvProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfessores_CellContentClick);
            this.DgvProfessores.AutoGenerateColumns = true;
            // 
            // FormListarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.DgvProfessores);
            this.Name = "FormListarProfessor";
            this.Text = "FormListarProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProfessores;
    }
}