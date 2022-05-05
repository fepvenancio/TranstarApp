
namespace TRTv10.User_Interface
{
    partial class FrmRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecibo));
            this.CbRecNumero = new System.Windows.Forms.ComboBox();
            this.TxtRecNomeCliente = new System.Windows.Forms.TextBox();
            this.BtnCotAnular = new System.Windows.Forms.Button();
            this.BtnCotLimpaForm = new System.Windows.Forms.Button();
            this.CbRecMoeda = new System.Windows.Forms.ComboBox();
            this.lblRecMoeda = new System.Windows.Forms.Label();
            this.BtnCotImprimir = new System.Windows.Forms.Button();
            this.dgvRecLinhasDocumentos = new System.Windows.Forms.DataGridView();
            this.lblRecCliente = new System.Windows.Forms.Label();
            this.CbRecCliente = new System.Windows.Forms.ComboBox();
            this.lblRecDocumento = new System.Windows.Forms.Label();
            this.CbRecDocumento = new System.Windows.Forms.ComboBox();
            this.lblRecCambio = new System.Windows.Forms.Label();
            this.TxtRecCambio = new System.Windows.Forms.TextBox();
            this.lblRecProcesso = new System.Windows.Forms.Label();
            this.CbRecProcesso = new System.Windows.Forms.ComboBox();
            this.CbRecAno = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtRecTotalRec = new System.Windows.Forms.TextBox();
            this.TxtRECTotalRetencao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRecTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecLinhasDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // CbRecNumero
            // 
            this.CbRecNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRecNumero.FormattingEnabled = true;
            this.CbRecNumero.Location = new System.Drawing.Point(519, 129);
            this.CbRecNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbRecNumero.Name = "CbRecNumero";
            this.CbRecNumero.Size = new System.Drawing.Size(66, 25);
            this.CbRecNumero.TabIndex = 159;
            this.CbRecNumero.SelectedIndexChanged += new System.EventHandler(this.CbRecNumOperacao_SelectedIndexChanged);
            // 
            // TxtRecNomeCliente
            // 
            this.TxtRecNomeCliente.Enabled = false;
            this.TxtRecNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecNomeCliente.Location = new System.Drawing.Point(215, 84);
            this.TxtRecNomeCliente.Name = "TxtRecNomeCliente";
            this.TxtRecNomeCliente.Size = new System.Drawing.Size(436, 25);
            this.TxtRecNomeCliente.TabIndex = 101;
            // 
            // BtnCotAnular
            // 
            this.BtnCotAnular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCotAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCotAnular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCotAnular.ForeColor = System.Drawing.Color.White;
            this.BtnCotAnular.Location = new System.Drawing.Point(134, 24);
            this.BtnCotAnular.Name = "BtnCotAnular";
            this.BtnCotAnular.Size = new System.Drawing.Size(98, 38);
            this.BtnCotAnular.TabIndex = 96;
            this.BtnCotAnular.Text = "Anular";
            this.BtnCotAnular.UseVisualStyleBackColor = false;
            // 
            // BtnCotLimpaForm
            // 
            this.BtnCotLimpaForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCotLimpaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCotLimpaForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCotLimpaForm.ForeColor = System.Drawing.Color.White;
            this.BtnCotLimpaForm.Location = new System.Drawing.Point(242, 24);
            this.BtnCotLimpaForm.Name = "BtnCotLimpaForm";
            this.BtnCotLimpaForm.Size = new System.Drawing.Size(106, 38);
            this.BtnCotLimpaForm.TabIndex = 97;
            this.BtnCotLimpaForm.Text = "Limpar Dados";
            this.BtnCotLimpaForm.UseVisualStyleBackColor = false;
            this.BtnCotLimpaForm.Click += new System.EventHandler(this.BtnRecLimpaForm_Click);
            // 
            // CbRecMoeda
            // 
            this.CbRecMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRecMoeda.FormattingEnabled = true;
            this.CbRecMoeda.Location = new System.Drawing.Point(342, 176);
            this.CbRecMoeda.Name = "CbRecMoeda";
            this.CbRecMoeda.Size = new System.Drawing.Size(105, 25);
            this.CbRecMoeda.TabIndex = 102;
            this.CbRecMoeda.SelectedIndexChanged += new System.EventHandler(this.CbRecMoeda_SelectedIndexChanged);
            // 
            // lblRecMoeda
            // 
            this.lblRecMoeda.AutoSize = true;
            this.lblRecMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecMoeda.Location = new System.Drawing.Point(277, 179);
            this.lblRecMoeda.Name = "lblRecMoeda";
            this.lblRecMoeda.Size = new System.Drawing.Size(50, 17);
            this.lblRecMoeda.TabIndex = 153;
            this.lblRecMoeda.Text = "Moeda";
            // 
            // BtnCotImprimir
            // 
            this.BtnCotImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCotImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCotImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCotImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnCotImprimir.Location = new System.Drawing.Point(29, 24);
            this.BtnCotImprimir.Name = "BtnCotImprimir";
            this.BtnCotImprimir.Size = new System.Drawing.Size(99, 38);
            this.BtnCotImprimir.TabIndex = 95;
            this.BtnCotImprimir.Text = "Imprimir";
            this.BtnCotImprimir.UseVisualStyleBackColor = false;
            this.BtnCotImprimir.Click += new System.EventHandler(this.BtnCotImprimir_Click);
            // 
            // dgvRecLinhasDocumentos
            // 
            this.dgvRecLinhasDocumentos.AllowUserToAddRows = false;
            this.dgvRecLinhasDocumentos.AllowUserToDeleteRows = false;
            this.dgvRecLinhasDocumentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecLinhasDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecLinhasDocumentos.Location = new System.Drawing.Point(29, 208);
            this.dgvRecLinhasDocumentos.Name = "dgvRecLinhasDocumentos";
            this.dgvRecLinhasDocumentos.Size = new System.Drawing.Size(1285, 420);
            this.dgvRecLinhasDocumentos.TabIndex = 136;
            this.dgvRecLinhasDocumentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecLinhasDocumentos_CellValueChanged);
            // 
            // lblRecCliente
            // 
            this.lblRecCliente.AutoSize = true;
            this.lblRecCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCliente.Location = new System.Drawing.Point(26, 87);
            this.lblRecCliente.Name = "lblRecCliente";
            this.lblRecCliente.Size = new System.Drawing.Size(47, 17);
            this.lblRecCliente.TabIndex = 130;
            this.lblRecCliente.Text = "Cliente";
            // 
            // CbRecCliente
            // 
            this.CbRecCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRecCliente.FormattingEnabled = true;
            this.CbRecCliente.Location = new System.Drawing.Point(118, 84);
            this.CbRecCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbRecCliente.Name = "CbRecCliente";
            this.CbRecCliente.Size = new System.Drawing.Size(91, 25);
            this.CbRecCliente.TabIndex = 100;
            this.CbRecCliente.SelectedIndexChanged += new System.EventHandler(this.CbRecCliente_SelectedIndexChanged);
            // 
            // lblRecDocumento
            // 
            this.lblRecDocumento.AutoSize = true;
            this.lblRecDocumento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecDocumento.Location = new System.Drawing.Point(26, 132);
            this.lblRecDocumento.Name = "lblRecDocumento";
            this.lblRecDocumento.Size = new System.Drawing.Size(75, 17);
            this.lblRecDocumento.TabIndex = 127;
            this.lblRecDocumento.Text = "Documento";
            // 
            // CbRecDocumento
            // 
            this.CbRecDocumento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRecDocumento.FormattingEnabled = true;
            this.CbRecDocumento.Location = new System.Drawing.Point(118, 129);
            this.CbRecDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbRecDocumento.Name = "CbRecDocumento";
            this.CbRecDocumento.Size = new System.Drawing.Size(395, 25);
            this.CbRecDocumento.TabIndex = 99;
            this.CbRecDocumento.SelectedIndexChanged += new System.EventHandler(this.CbRecDocumento_SelectedIndexChanged);
            // 
            // lblRecCambio
            // 
            this.lblRecCambio.AutoSize = true;
            this.lblRecCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCambio.Location = new System.Drawing.Point(453, 179);
            this.lblRecCambio.Name = "lblRecCambio";
            this.lblRecCambio.Size = new System.Drawing.Size(53, 17);
            this.lblRecCambio.TabIndex = 124;
            this.lblRecCambio.Text = "Câmbio";
            this.lblRecCambio.Click += new System.EventHandler(this.lblSERCambio_Click);
            // 
            // TxtRecCambio
            // 
            this.TxtRecCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecCambio.Location = new System.Drawing.Point(519, 176);
            this.TxtRecCambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtRecCambio.Name = "TxtRecCambio";
            this.TxtRecCambio.Size = new System.Drawing.Size(132, 25);
            this.TxtRecCambio.TabIndex = 105;
            // 
            // lblRecProcesso
            // 
            this.lblRecProcesso.AutoSize = true;
            this.lblRecProcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecProcesso.Location = new System.Drawing.Point(26, 179);
            this.lblRecProcesso.Name = "lblRecProcesso";
            this.lblRecProcesso.Size = new System.Drawing.Size(61, 17);
            this.lblRecProcesso.TabIndex = 118;
            this.lblRecProcesso.Text = "Processo";
            // 
            // CbRecProcesso
            // 
            this.CbRecProcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRecProcesso.FormattingEnabled = true;
            this.CbRecProcesso.Location = new System.Drawing.Point(118, 176);
            this.CbRecProcesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbRecProcesso.Name = "CbRecProcesso";
            this.CbRecProcesso.Size = new System.Drawing.Size(136, 25);
            this.CbRecProcesso.TabIndex = 98;
            this.CbRecProcesso.SelectedIndexChanged += new System.EventHandler(this.CbRecProcesso_SelectedIndexChanged);
            // 
            // CbRecAno
            // 
            this.CbRecAno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRecAno.FormattingEnabled = true;
            this.CbRecAno.Location = new System.Drawing.Point(591, 129);
            this.CbRecAno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbRecAno.Name = "CbRecAno";
            this.CbRecAno.Size = new System.Drawing.Size(60, 25);
            this.CbRecAno.TabIndex = 160;
            this.CbRecAno.SelectedIndexChanged += new System.EventHandler(this.CbRecAno_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1053, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(262, 13);
            this.label16.TabIndex = 181;
            this.label16.Text = "___________________________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1114, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 180;
            this.label15.Text = "Total do Documento";
            // 
            // TxtRecTotalRec
            // 
            this.TxtRecTotalRec.Enabled = false;
            this.TxtRecTotalRec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecTotalRec.HideSelection = false;
            this.TxtRecTotalRec.Location = new System.Drawing.Point(1162, 115);
            this.TxtRecTotalRec.Name = "TxtRecTotalRec";
            this.TxtRecTotalRec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtRecTotalRec.Size = new System.Drawing.Size(147, 25);
            this.TxtRecTotalRec.TabIndex = 179;
            // 
            // TxtRECTotalRetencao
            // 
            this.TxtRECTotalRetencao.Enabled = false;
            this.TxtRECTotalRetencao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRECTotalRetencao.Location = new System.Drawing.Point(1162, 84);
            this.TxtRECTotalRetencao.Name = "TxtRECTotalRetencao";
            this.TxtRECTotalRetencao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtRECTotalRetencao.Size = new System.Drawing.Size(147, 25);
            this.TxtRECTotalRetencao.TabIndex = 178;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1053, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 176;
            this.label7.Text = "Total a Receber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1053, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 175;
            this.label6.Text = "Total Retenção";
            // 
            // TxtRecTotal
            // 
            this.TxtRecTotal.Enabled = false;
            this.TxtRecTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecTotal.HideSelection = false;
            this.TxtRecTotal.Location = new System.Drawing.Point(1162, 146);
            this.TxtRecTotal.Name = "TxtRecTotal";
            this.TxtRecTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtRecTotal.Size = new System.Drawing.Size(147, 25);
            this.TxtRecTotal.TabIndex = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1053, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 182;
            this.label1.Text = "Total";
            // 
            // FrmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 653);
            this.Controls.Add(this.TxtRecTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtRecTotalRec);
            this.Controls.Add(this.TxtRECTotalRetencao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbRecAno);
            this.Controls.Add(this.CbRecNumero);
            this.Controls.Add(this.TxtRecNomeCliente);
            this.Controls.Add(this.BtnCotAnular);
            this.Controls.Add(this.BtnCotLimpaForm);
            this.Controls.Add(this.CbRecMoeda);
            this.Controls.Add(this.lblRecMoeda);
            this.Controls.Add(this.BtnCotImprimir);
            this.Controls.Add(this.dgvRecLinhasDocumentos);
            this.Controls.Add(this.lblRecCliente);
            this.Controls.Add(this.CbRecCliente);
            this.Controls.Add(this.lblRecDocumento);
            this.Controls.Add(this.CbRecDocumento);
            this.Controls.Add(this.lblRecCambio);
            this.Controls.Add(this.TxtRecCambio);
            this.Controls.Add(this.lblRecProcesso);
            this.Controls.Add(this.CbRecProcesso);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recebimentos";
            this.Load += new System.EventHandler(this.FrmRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecLinhasDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CbRecNumero;
        public System.Windows.Forms.TextBox TxtRecNomeCliente;
        private System.Windows.Forms.Button BtnCotAnular;
        private System.Windows.Forms.Button BtnCotLimpaForm;
        public System.Windows.Forms.ComboBox CbRecMoeda;
        private System.Windows.Forms.Label lblRecMoeda;
        private System.Windows.Forms.Button BtnCotImprimir;
        public System.Windows.Forms.DataGridView dgvRecLinhasDocumentos;
        private System.Windows.Forms.Label lblRecCliente;
        public System.Windows.Forms.ComboBox CbRecCliente;
        private System.Windows.Forms.Label lblRecDocumento;
        public System.Windows.Forms.ComboBox CbRecDocumento;
        private System.Windows.Forms.Label lblRecCambio;
        public System.Windows.Forms.TextBox TxtRecCambio;
        private System.Windows.Forms.Label lblRecProcesso;
        public System.Windows.Forms.ComboBox CbRecProcesso;
        public System.Windows.Forms.ComboBox CbRecAno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtRecTotalRec;
        private System.Windows.Forms.TextBox TxtRECTotalRetencao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRecTotal;
        private System.Windows.Forms.Label label1;
    }
}