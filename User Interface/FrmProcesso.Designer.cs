using System.ComponentModel;

namespace TRTv10.User_Interface
{
    partial class FrmProcesso
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDocumentosVND = new System.Windows.Forms.DataGridView();
            this.dgvDocumentoVNDLin = new System.Windows.Forms.DataGridView();
            this.cbPRONumProcesso = new System.Windows.Forms.ComboBox();
            this.lblRI = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.dgvDocumentosRI = new System.Windows.Forms.DataGridView();
            this.cmsVND = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.criarReqInternaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsREC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.criarReciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPROCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentosVND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentoVNDLin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentosRI)).BeginInit();
            this.cmsVND.SuspendLayout();
            this.cmsREC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocumentosVND
            // 
            this.dgvDocumentosVND.AllowUserToAddRows = false;
            this.dgvDocumentosVND.AllowUserToDeleteRows = false;
            this.dgvDocumentosVND.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDocumentosVND.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDocumentosVND.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentosVND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentosVND.Location = new System.Drawing.Point(39, 330);
            this.dgvDocumentosVND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDocumentosVND.Name = "dgvDocumentosVND";
            this.dgvDocumentosVND.ReadOnly = true;
            this.dgvDocumentosVND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentosVND.Size = new System.Drawing.Size(993, 221);
            this.dgvDocumentosVND.TabIndex = 1;
            this.dgvDocumentosVND.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.DgvDocumentosVND_CellContextMenuStripNeeded);
            this.dgvDocumentosVND.Click += new System.EventHandler(this.DgvDocumentosVND_Click);
            // 
            // dgvDocumentoVNDLin
            // 
            this.dgvDocumentoVNDLin.AllowUserToAddRows = false;
            this.dgvDocumentoVNDLin.AllowUserToDeleteRows = false;
            this.dgvDocumentoVNDLin.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDocumentoVNDLin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDocumentoVNDLin.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentoVNDLin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentoVNDLin.Location = new System.Drawing.Point(39, 571);
            this.dgvDocumentoVNDLin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDocumentoVNDLin.Name = "dgvDocumentoVNDLin";
            this.dgvDocumentoVNDLin.ReadOnly = true;
            this.dgvDocumentoVNDLin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentoVNDLin.Size = new System.Drawing.Size(993, 175);
            this.dgvDocumentoVNDLin.TabIndex = 2;
            this.dgvDocumentoVNDLin.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.DgvDocumentoLin_CellContextMenuStripNeeded);
            // 
            // cbPRONumProcesso
            // 
            this.cbPRONumProcesso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRONumProcesso.FormattingEnabled = true;
            this.cbPRONumProcesso.Location = new System.Drawing.Point(855, 22);
            this.cbPRONumProcesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPRONumProcesso.Name = "cbPRONumProcesso";
            this.cbPRONumProcesso.Size = new System.Drawing.Size(181, 29);
            this.cbPRONumProcesso.TabIndex = 3;
            this.cbPRONumProcesso.SelectedIndexChanged += new System.EventHandler(this.CbPRONumProcesso_SelectedIndexChanged);
            // 
            // lblRI
            // 
            this.lblRI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRI.Location = new System.Drawing.Point(35, 25);
            this.lblRI.Name = "lblRI";
            this.lblRI.Size = new System.Drawing.Size(227, 30);
            this.lblRI.TabIndex = 4;
            this.lblRI.Text = "Documentos RI";
            // 
            // lblVND
            // 
            this.lblVND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND.Location = new System.Drawing.Point(34, 271);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(227, 30);
            this.lblVND.TabIndex = 5;
            this.lblVND.Text = "Documentos Vendas";
            // 
            // dgvDocumentosRI
            // 
            this.dgvDocumentosRI.AllowUserToAddRows = false;
            this.dgvDocumentosRI.AllowUserToDeleteRows = false;
            this.dgvDocumentosRI.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDocumentosRI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDocumentosRI.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentosRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentosRI.Location = new System.Drawing.Point(38, 76);
            this.dgvDocumentosRI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDocumentosRI.Name = "dgvDocumentosRI";
            this.dgvDocumentosRI.ReadOnly = true;
            this.dgvDocumentosRI.Size = new System.Drawing.Size(998, 171);
            this.dgvDocumentosRI.TabIndex = 6;
            this.dgvDocumentosRI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDocumentosRI_CellContentClick);
            // 
            // cmsVND
            // 
            this.cmsVND.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarReqInternaToolStripMenuItem});
            this.cmsVND.Name = "cmsVND";
            this.cmsVND.Size = new System.Drawing.Size(166, 26);
            // 
            // criarReqInternaToolStripMenuItem
            // 
            this.criarReqInternaToolStripMenuItem.Name = "criarReqInternaToolStripMenuItem";
            this.criarReqInternaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.criarReqInternaToolStripMenuItem.Text = "Criar Req. Interna";
            this.criarReqInternaToolStripMenuItem.Click += new System.EventHandler(this.CriarReqInternaToolStripMenuItem_Click_1);
            // 
            // cmsREC
            // 
            this.cmsREC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarReciboToolStripMenuItem});
            this.cmsREC.Name = "cmsREC";
            this.cmsREC.Size = new System.Drawing.Size(220, 26);
            // 
            // criarReciboToolStripMenuItem
            // 
            this.criarReciboToolStripMenuItem.Name = "criarReciboToolStripMenuItem";
            this.criarReciboToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.criarReciboToolStripMenuItem.Text = "Criar Pagamento de Cliente";
            this.criarReciboToolStripMenuItem.Click += new System.EventHandler(this.CriarReciboToolStripMenuItem_Click);
            // 
            // cbPROCliente
            // 
            this.cbPROCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPROCliente.FormattingEnabled = true;
            this.cbPROCliente.Location = new System.Drawing.Point(655, 22);
            this.cbPROCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPROCliente.Name = "cbPROCliente";
            this.cbPROCliente.Size = new System.Drawing.Size(181, 29);
            this.cbPROCliente.TabIndex = 7;
            this.cbPROCliente.Leave += new System.EventHandler(this.CbPROCliente_Leave);
            // 
            // FrmProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 770);
            this.Controls.Add(this.cbPROCliente);
            this.Controls.Add(this.dgvDocumentosRI);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.lblRI);
            this.Controls.Add(this.cbPRONumProcesso);
            this.Controls.Add(this.dgvDocumentoVNDLin);
            this.Controls.Add(this.dgvDocumentosVND);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProcesso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos do Processo";
            this.Load += new System.EventHandler(this.Processo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentosVND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentoVNDLin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentosRI)).EndInit();
            this.cmsVND.ResumeLayout(false);
            this.cmsREC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cbPRONumProcesso;
        private System.Windows.Forms.ContextMenuStrip cmsREC;
        private System.Windows.Forms.ContextMenuStrip cmsVND;
        private System.Windows.Forms.ToolStripMenuItem criarReciboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarReqInternaToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvDocumentosRI;
        public System.Windows.Forms.DataGridView dgvDocumentosVND;
        private System.Windows.Forms.DataGridView dgvDocumentoVNDLin;
        private System.Windows.Forms.Label lblRI;
        private System.Windows.Forms.Label lblVND;

        #endregion

        private System.Windows.Forms.ComboBox cbPROCliente;
    }
}