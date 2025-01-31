namespace SistemadeGestãodeSalas.Forms.Reservas
{
    partial class FormListarReservas
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
            this.DgvReservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReservas
            // 
            this.DgvReservas.AllowUserToAddRows = false;
            this.DgvReservas.AllowUserToDeleteRows = false;
            this.DgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvReservas.Location = new System.Drawing.Point(0, 0);
            this.DgvReservas.Name = "DgvReservas";
            this.DgvReservas.ReadOnly = true;
            this.DgvReservas.RowHeadersWidth = 51;
            this.DgvReservas.RowTemplate.Height = 24;
            this.DgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReservas.Size = new System.Drawing.Size(718, 674);
            this.DgvReservas.TabIndex = 4;
            this.DgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormListarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(718, 674);
            this.Controls.Add(this.DgvReservas);
            this.Name = "FormListarReservas";
            this.Text = "FormListarReservas";
            this.Load += new System.EventHandler(this.FormListarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvReservas;
    }
}