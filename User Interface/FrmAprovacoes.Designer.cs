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
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AprTesouraria = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AprOperacoes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AprDireccao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AprPagamento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dgvAprovacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Num,
            this.Serie,
            this.Data,
            this.Processo,
            this.Cliente,
            this.Nome,
            this.AprTesouraria,
            this.AprOperacoes,
            this.AprDireccao,
            this.AprPagamento});
            this.dgvAprovacoes.Location = new System.Drawing.Point(12, 88);
            this.dgvAprovacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAprovacoes.Name = "dgvAprovacoes";
            this.dgvAprovacoes.Size = new System.Drawing.Size(1374, 487);
            this.dgvAprovacoes.TabIndex = 7;
            this.dgvAprovacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAprovacoes_Click);
            this.dgvAprovacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAprovacoes_CellValueChanged);
            // 
            // Doc
            // 
            this.Doc.HeaderText = "Doc";
            this.Doc.Name = "Doc";
            // 
            // Num
            // 
            this.Num.HeaderText = "Nº";
            this.Num.Name = "Num";
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Processo
            // 
            this.Processo.HeaderText = "Processo";
            this.Processo.Name = "Processo";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // AprTesouraria
            // 
            this.AprTesouraria.HeaderText = "Apr Tesouraria";
            this.AprTesouraria.Name = "AprTesouraria";
            this.AprTesouraria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AprTesouraria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AprOperacoes
            // 
            this.AprOperacoes.HeaderText = "Apr Operacoes";
            this.AprOperacoes.Name = "AprOperacoes";
            // 
            // AprDireccao
            // 
            this.AprDireccao.HeaderText = "Apr Direcção";
            this.AprDireccao.Name = "AprDireccao";
            // 
            // AprPagamento
            // 
            this.AprPagamento.HeaderText = "Pgt Tesouraria";
            this.AprPagamento.Name = "AprPagamento";
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
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos por Aprovar";
            this.Load += new System.EventHandler(this.Aprovacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprovacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAprovacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AprTesouraria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AprOperacoes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AprDireccao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AprPagamento;
    }
}