namespace TRTv10.User_Interface
{
    partial class FrmAprovacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAprovacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprovacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAprovacoes
            // 
            this.dgvAprovacoes.AllowUserToAddRows = false;
            this.dgvAprovacoes.AllowUserToDeleteRows = false;
            this.dgvAprovacoes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAprovacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAprovacoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAprovacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAprovacoes.Location = new System.Drawing.Point(12, 88);
            this.dgvAprovacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAprovacoes.Name = "dgvAprovacoes";
            this.dgvAprovacoes.ReadOnly = true;
            this.dgvAprovacoes.Size = new System.Drawing.Size(1374, 487);
            this.dgvAprovacoes.TabIndex = 7;
            // 
            // FrmAprovacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 588);
            this.Controls.Add(this.dgvAprovacoes);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAprovacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos por Aprovar";
            this.Load += new System.EventHandler(this.Aprovacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprovacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAprovacoes;
    }
}