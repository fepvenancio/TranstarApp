
namespace TRTv10.User_Interface
{
    partial class FrmDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumento));
            this.CbDocNumOperacao = new System.Windows.Forms.ComboBox();
            this.lblSERTipoMercadoria = new System.Windows.Forms.Label();
            this.TxtDocTipoMercadoria = new System.Windows.Forms.TextBox();
            this.TxtDocNomeCliente = new System.Windows.Forms.TextBox();
            this.lblSERDUP = new System.Windows.Forms.Label();
            this.TxtDocDup = new System.Windows.Forms.TextBox();
            this.lblSERMoeda = new System.Windows.Forms.Label();
            this.lblSERPorteBL = new System.Windows.Forms.Label();
            this.TxtDocPorteBl = new System.Windows.Forms.TextBox();
            this.lblSERNumDU = new System.Windows.Forms.Label();
            this.TxtDocDu = new System.Windows.Forms.TextBox();
            this.DtpDocDataDu = new System.Windows.Forms.DateTimePicker();
            this.lblDataDU = new System.Windows.Forms.Label();
            this.lblAviaoNavio = new System.Windows.Forms.Label();
            this.lblSERVAduaneiro = new System.Windows.Forms.Label();
            this.TxtDocValorAduaneiro = new System.Windows.Forms.TextBox();
            this.lvlSERCIF = new System.Windows.Forms.Label();
            this.TxtDocValorCif = new System.Windows.Forms.TextBox();
            this.BtnDocImprimir = new System.Windows.Forms.Button();
            this.dgvLinhasDocumentoDoc = new System.Windows.Forms.DataGridView();
            this.DtpDocData = new System.Windows.Forms.DateTimePicker();
            this.lblSERData = new System.Windows.Forms.Label();
            this.lblSERCliente = new System.Windows.Forms.Label();
            this.lblSEROperacao = new System.Windows.Forms.Label();
            this.CbDocOperacao = new System.Windows.Forms.ComboBox();
            this.CbDocAno = new System.Windows.Forms.ComboBox();
            this.TxtDocTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDocTotalSIva = new System.Windows.Forms.TextBox();
            this.TxtDocTotalIva = new System.Windows.Forms.TextBox();
            this.TxtDocTotalDoc = new System.Windows.Forms.TextBox();
            this.TxtDocTotalRet = new System.Windows.Forms.TextBox();
            this.BtnDocConverter = new System.Windows.Forms.Button();
            this.TxtDocCliente = new System.Windows.Forms.TextBox();
            this.TxtDocMoeda = new System.Windows.Forms.TextBox();
            this.TxtDocCambio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDocNumDocConvertido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasDocumentoDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // CbDocNumOperacao
            // 
            this.CbDocNumOperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDocNumOperacao.FormattingEnabled = true;
            this.CbDocNumOperacao.Location = new System.Drawing.Point(520, 84);
            this.CbDocNumOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbDocNumOperacao.Name = "CbDocNumOperacao";
            this.CbDocNumOperacao.Size = new System.Drawing.Size(66, 25);
            this.CbDocNumOperacao.TabIndex = 159;
            this.CbDocNumOperacao.SelectedIndexChanged += new System.EventHandler(this.cbCotNumOperacao_SelectedIndexChanged);
            // 
            // lblSERTipoMercadoria
            // 
            this.lblSERTipoMercadoria.AutoSize = true;
            this.lblSERTipoMercadoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERTipoMercadoria.Location = new System.Drawing.Point(26, 189);
            this.lblSERTipoMercadoria.Name = "lblSERTipoMercadoria";
            this.lblSERTipoMercadoria.Size = new System.Drawing.Size(125, 17);
            this.lblSERTipoMercadoria.TabIndex = 157;
            this.lblSERTipoMercadoria.Text = "Tipo de Mercadoria";
            // 
            // TxtDocTipoMercadoria
            // 
            this.TxtDocTipoMercadoria.Enabled = false;
            this.TxtDocTipoMercadoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocTipoMercadoria.Location = new System.Drawing.Point(164, 186);
            this.TxtDocTipoMercadoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocTipoMercadoria.Name = "TxtDocTipoMercadoria";
            this.TxtDocTipoMercadoria.Size = new System.Drawing.Size(488, 25);
            this.TxtDocTipoMercadoria.TabIndex = 113;
            // 
            // TxtDocNomeCliente
            // 
            this.TxtDocNomeCliente.Enabled = false;
            this.TxtDocNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocNomeCliente.Location = new System.Drawing.Point(164, 152);
            this.TxtDocNomeCliente.Name = "TxtDocNomeCliente";
            this.TxtDocNomeCliente.Size = new System.Drawing.Size(488, 25);
            this.TxtDocNomeCliente.TabIndex = 101;
            // 
            // lblSERDUP
            // 
            this.lblSERDUP.AutoSize = true;
            this.lblSERDUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERDUP.Location = new System.Drawing.Point(361, 253);
            this.lblSERDUP.Name = "lblSERDUP";
            this.lblSERDUP.Size = new System.Drawing.Size(33, 17);
            this.lblSERDUP.TabIndex = 155;
            this.lblSERDUP.Text = "DUP";
            // 
            // TxtDocDup
            // 
            this.TxtDocDup.Enabled = false;
            this.TxtDocDup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocDup.Location = new System.Drawing.Point(486, 250);
            this.TxtDocDup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocDup.Name = "TxtDocDup";
            this.TxtDocDup.Size = new System.Drawing.Size(166, 25);
            this.TxtDocDup.TabIndex = 107;
            // 
            // lblSERMoeda
            // 
            this.lblSERMoeda.AutoSize = true;
            this.lblSERMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERMoeda.Location = new System.Drawing.Point(25, 253);
            this.lblSERMoeda.Name = "lblSERMoeda";
            this.lblSERMoeda.Size = new System.Drawing.Size(98, 17);
            this.lblSERMoeda.TabIndex = 153;
            this.lblSERMoeda.Text = "Moeda Origem";
            // 
            // lblSERPorteBL
            // 
            this.lblSERPorteBL.AutoSize = true;
            this.lblSERPorteBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERPorteBL.Location = new System.Drawing.Point(361, 319);
            this.lblSERPorteBL.Name = "lblSERPorteBL";
            this.lblSERPorteBL.Size = new System.Drawing.Size(119, 17);
            this.lblSERPorteBL.TabIndex = 150;
            this.lblSERPorteBL.Text = "Carta de Porte / BL";
            // 
            // TxtDocPorteBl
            // 
            this.TxtDocPorteBl.Enabled = false;
            this.TxtDocPorteBl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocPorteBl.Location = new System.Drawing.Point(486, 316);
            this.TxtDocPorteBl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocPorteBl.Name = "TxtDocPorteBl";
            this.TxtDocPorteBl.Size = new System.Drawing.Size(166, 25);
            this.TxtDocPorteBl.TabIndex = 108;
            // 
            // lblSERNumDU
            // 
            this.lblSERNumDU.AutoSize = true;
            this.lblSERNumDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumDU.Location = new System.Drawing.Point(361, 286);
            this.lblSERNumDU.Name = "lblSERNumDU";
            this.lblSERNumDU.Size = new System.Drawing.Size(49, 17);
            this.lblSERNumDU.TabIndex = 149;
            this.lblSERNumDU.Text = "N.º DU";
            // 
            // TxtDocDu
            // 
            this.TxtDocDu.Enabled = false;
            this.TxtDocDu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocDu.Location = new System.Drawing.Point(486, 283);
            this.TxtDocDu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocDu.Name = "TxtDocDu";
            this.TxtDocDu.Size = new System.Drawing.Size(166, 25);
            this.TxtDocDu.TabIndex = 120;
            // 
            // DtpDocDataDu
            // 
            this.DtpDocDataDu.Enabled = false;
            this.DtpDocDataDu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDocDataDu.Location = new System.Drawing.Point(486, 218);
            this.DtpDocDataDu.Name = "DtpDocDataDu";
            this.DtpDocDataDu.Size = new System.Drawing.Size(166, 25);
            this.DtpDocDataDu.TabIndex = 125;
            // 
            // lblDataDU
            // 
            this.lblDataDU.AutoSize = true;
            this.lblDataDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDU.Location = new System.Drawing.Point(361, 224);
            this.lblDataDU.Name = "lblDataDU";
            this.lblDataDU.Size = new System.Drawing.Size(57, 17);
            this.lblDataDU.TabIndex = 145;
            this.lblDataDU.Text = "Data DU";
            // 
            // lblAviaoNavio
            // 
            this.lblAviaoNavio.AutoSize = true;
            this.lblAviaoNavio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviaoNavio.Location = new System.Drawing.Point(361, 351);
            this.lblAviaoNavio.Name = "lblAviaoNavio";
            this.lblAviaoNavio.Size = new System.Drawing.Size(71, 17);
            this.lblAviaoNavio.TabIndex = 142;
            this.lblAviaoNavio.Text = "Transporte";
            // 
            // lblSERVAduaneiro
            // 
            this.lblSERVAduaneiro.AutoSize = true;
            this.lblSERVAduaneiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERVAduaneiro.Location = new System.Drawing.Point(361, 420);
            this.lblSERVAduaneiro.Name = "lblSERVAduaneiro";
            this.lblSERVAduaneiro.Size = new System.Drawing.Size(102, 17);
            this.lblSERVAduaneiro.TabIndex = 139;
            this.lblSERVAduaneiro.Text = "Valor Aduaneiro";
            // 
            // TxtDocValorAduaneiro
            // 
            this.TxtDocValorAduaneiro.Enabled = false;
            this.TxtDocValorAduaneiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocValorAduaneiro.Location = new System.Drawing.Point(486, 417);
            this.TxtDocValorAduaneiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocValorAduaneiro.Name = "TxtDocValorAduaneiro";
            this.TxtDocValorAduaneiro.Size = new System.Drawing.Size(166, 25);
            this.TxtDocValorAduaneiro.TabIndex = 104;
            // 
            // lvlSERCIF
            // 
            this.lvlSERCIF.AutoSize = true;
            this.lvlSERCIF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSERCIF.Location = new System.Drawing.Point(361, 387);
            this.lvlSERCIF.Name = "lvlSERCIF";
            this.lvlSERCIF.Size = new System.Drawing.Size(59, 17);
            this.lvlSERCIF.TabIndex = 138;
            this.lvlSERCIF.Text = "Valor CIF";
            // 
            // TxtDocValorCif
            // 
            this.TxtDocValorCif.Enabled = false;
            this.TxtDocValorCif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocValorCif.Location = new System.Drawing.Point(486, 384);
            this.TxtDocValorCif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocValorCif.Name = "TxtDocValorCif";
            this.TxtDocValorCif.Size = new System.Drawing.Size(166, 25);
            this.TxtDocValorCif.TabIndex = 103;
            // 
            // BtnDocImprimir
            // 
            this.BtnDocImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnDocImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDocImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnDocImprimir.Location = new System.Drawing.Point(553, 24);
            this.BtnDocImprimir.Name = "BtnDocImprimir";
            this.BtnDocImprimir.Size = new System.Drawing.Size(99, 38);
            this.BtnDocImprimir.TabIndex = 95;
            this.BtnDocImprimir.Text = "Imprimir";
            this.BtnDocImprimir.UseVisualStyleBackColor = false;
            this.BtnDocImprimir.Click += new System.EventHandler(this.BtnCotImprimir_Click);
            // 
            // dgvLinhasDocumentoDoc
            // 
            this.dgvLinhasDocumentoDoc.AllowUserToAddRows = false;
            this.dgvLinhasDocumentoDoc.AllowUserToDeleteRows = false;
            this.dgvLinhasDocumentoDoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLinhasDocumentoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhasDocumentoDoc.Enabled = false;
            this.dgvLinhasDocumentoDoc.Location = new System.Drawing.Point(28, 464);
            this.dgvLinhasDocumentoDoc.Name = "dgvLinhasDocumentoDoc";
            this.dgvLinhasDocumentoDoc.Size = new System.Drawing.Size(624, 254);
            this.dgvLinhasDocumentoDoc.TabIndex = 136;
            this.dgvLinhasDocumentoDoc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinhasDocumentoDoc_CellValueChanged);
            // 
            // DtpDocData
            // 
            this.DtpDocData.Enabled = false;
            this.DtpDocData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDocData.Location = new System.Drawing.Point(164, 218);
            this.DtpDocData.Name = "DtpDocData";
            this.DtpDocData.Size = new System.Drawing.Size(166, 25);
            this.DtpDocData.TabIndex = 111;
            // 
            // lblSERData
            // 
            this.lblSERData.AutoSize = true;
            this.lblSERData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERData.Location = new System.Drawing.Point(26, 224);
            this.lblSERData.Name = "lblSERData";
            this.lblSERData.Size = new System.Drawing.Size(35, 17);
            this.lblSERData.TabIndex = 132;
            this.lblSERData.Text = "Data";
            // 
            // lblSERCliente
            // 
            this.lblSERCliente.AutoSize = true;
            this.lblSERCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCliente.Location = new System.Drawing.Point(26, 123);
            this.lblSERCliente.Name = "lblSERCliente";
            this.lblSERCliente.Size = new System.Drawing.Size(47, 17);
            this.lblSERCliente.TabIndex = 130;
            this.lblSERCliente.Text = "Cliente";
            // 
            // lblSEROperacao
            // 
            this.lblSEROperacao.AutoSize = true;
            this.lblSEROperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEROperacao.Location = new System.Drawing.Point(26, 87);
            this.lblSEROperacao.Name = "lblSEROperacao";
            this.lblSEROperacao.Size = new System.Drawing.Size(66, 17);
            this.lblSEROperacao.TabIndex = 127;
            this.lblSEROperacao.Text = "Operação";
            // 
            // CbDocOperacao
            // 
            this.CbDocOperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDocOperacao.FormattingEnabled = true;
            this.CbDocOperacao.Location = new System.Drawing.Point(164, 84);
            this.CbDocOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbDocOperacao.Name = "CbDocOperacao";
            this.CbDocOperacao.Size = new System.Drawing.Size(350, 25);
            this.CbDocOperacao.TabIndex = 99;
            this.CbDocOperacao.SelectedIndexChanged += new System.EventHandler(this.CbCotOperacao_SelectedIndexChanged);
            // 
            // CbDocAno
            // 
            this.CbDocAno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDocAno.FormattingEnabled = true;
            this.CbDocAno.Location = new System.Drawing.Point(592, 84);
            this.CbDocAno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbDocAno.Name = "CbDocAno";
            this.CbDocAno.Size = new System.Drawing.Size(60, 25);
            this.CbDocAno.TabIndex = 160;
            // 
            // TxtDocTransporte
            // 
            this.TxtDocTransporte.Enabled = false;
            this.TxtDocTransporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocTransporte.Location = new System.Drawing.Point(486, 349);
            this.TxtDocTransporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocTransporte.Name = "TxtDocTransporte";
            this.TxtDocTransporte.Size = new System.Drawing.Size(166, 25);
            this.TxtDocTransporte.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 162;
            this.label1.Text = "Total Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 163;
            this.label2.Text = "Total S/IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 164;
            this.label3.Text = "Total IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 165;
            this.label4.Text = "Total Retenção";
            // 
            // TxtDocTotalSIva
            // 
            this.TxtDocTotalSIva.Enabled = false;
            this.TxtDocTotalSIva.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocTotalSIva.Location = new System.Drawing.Point(164, 316);
            this.TxtDocTotalSIva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocTotalSIva.Name = "TxtDocTotalSIva";
            this.TxtDocTotalSIva.Size = new System.Drawing.Size(166, 25);
            this.TxtDocTotalSIva.TabIndex = 166;
            // 
            // TxtDocTotalIva
            // 
            this.TxtDocTotalIva.Enabled = false;
            this.TxtDocTotalIva.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocTotalIva.Location = new System.Drawing.Point(164, 349);
            this.TxtDocTotalIva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocTotalIva.Name = "TxtDocTotalIva";
            this.TxtDocTotalIva.Size = new System.Drawing.Size(166, 25);
            this.TxtDocTotalIva.TabIndex = 167;
            // 
            // TxtDocTotalDoc
            // 
            this.TxtDocTotalDoc.Enabled = false;
            this.TxtDocTotalDoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocTotalDoc.Location = new System.Drawing.Point(164, 382);
            this.TxtDocTotalDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocTotalDoc.Name = "TxtDocTotalDoc";
            this.TxtDocTotalDoc.Size = new System.Drawing.Size(166, 25);
            this.TxtDocTotalDoc.TabIndex = 168;
            // 
            // TxtDocTotalRet
            // 
            this.TxtDocTotalRet.Enabled = false;
            this.TxtDocTotalRet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocTotalRet.Location = new System.Drawing.Point(164, 417);
            this.TxtDocTotalRet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocTotalRet.Name = "TxtDocTotalRet";
            this.TxtDocTotalRet.Size = new System.Drawing.Size(166, 25);
            this.TxtDocTotalRet.TabIndex = 169;
            // 
            // BtnDocConverter
            // 
            this.BtnDocConverter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnDocConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocConverter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDocConverter.ForeColor = System.Drawing.Color.White;
            this.BtnDocConverter.Location = new System.Drawing.Point(29, 24);
            this.BtnDocConverter.Name = "BtnDocConverter";
            this.BtnDocConverter.Size = new System.Drawing.Size(99, 38);
            this.BtnDocConverter.TabIndex = 170;
            this.BtnDocConverter.Text = "Converter";
            this.BtnDocConverter.UseVisualStyleBackColor = false;
            this.BtnDocConverter.Click += new System.EventHandler(this.BtnDocConverter_Click);
            // 
            // TxtDocCliente
            // 
            this.TxtDocCliente.Enabled = false;
            this.TxtDocCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocCliente.Location = new System.Drawing.Point(164, 120);
            this.TxtDocCliente.Name = "TxtDocCliente";
            this.TxtDocCliente.Size = new System.Drawing.Size(488, 25);
            this.TxtDocCliente.TabIndex = 171;
            // 
            // TxtDocMoeda
            // 
            this.TxtDocMoeda.Enabled = false;
            this.TxtDocMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocMoeda.Location = new System.Drawing.Point(164, 250);
            this.TxtDocMoeda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocMoeda.Name = "TxtDocMoeda";
            this.TxtDocMoeda.Size = new System.Drawing.Size(166, 25);
            this.TxtDocMoeda.TabIndex = 172;
            // 
            // TxtDocCambio
            // 
            this.TxtDocCambio.Enabled = false;
            this.TxtDocCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocCambio.Location = new System.Drawing.Point(164, 283);
            this.TxtDocCambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDocCambio.Name = "TxtDocCambio";
            this.TxtDocCambio.Size = new System.Drawing.Size(166, 25);
            this.TxtDocCambio.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 174;
            this.label5.Text = "Câmbio";
            // 
            // TxtDocNumDocConvertido
            // 
            this.TxtDocNumDocConvertido.Enabled = false;
            this.TxtDocNumDocConvertido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocNumDocConvertido.Location = new System.Drawing.Point(244, 23);
            this.TxtDocNumDocConvertido.Name = "TxtDocNumDocConvertido";
            this.TxtDocNumDocConvertido.Size = new System.Drawing.Size(204, 39);
            this.TxtDocNumDocConvertido.TabIndex = 175;
            this.TxtDocNumDocConvertido.Visible = false;
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 745);
            this.Controls.Add(this.TxtDocNumDocConvertido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDocCambio);
            this.Controls.Add(this.TxtDocMoeda);
            this.Controls.Add(this.TxtDocCliente);
            this.Controls.Add(this.BtnDocConverter);
            this.Controls.Add(this.TxtDocTotalRet);
            this.Controls.Add(this.TxtDocTotalDoc);
            this.Controls.Add(this.TxtDocTotalIva);
            this.Controls.Add(this.TxtDocTotalSIva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDocTransporte);
            this.Controls.Add(this.CbDocAno);
            this.Controls.Add(this.CbDocNumOperacao);
            this.Controls.Add(this.lblSERTipoMercadoria);
            this.Controls.Add(this.TxtDocTipoMercadoria);
            this.Controls.Add(this.TxtDocNomeCliente);
            this.Controls.Add(this.lblSERDUP);
            this.Controls.Add(this.TxtDocDup);
            this.Controls.Add(this.lblSERMoeda);
            this.Controls.Add(this.lblSERPorteBL);
            this.Controls.Add(this.TxtDocPorteBl);
            this.Controls.Add(this.lblSERNumDU);
            this.Controls.Add(this.TxtDocDu);
            this.Controls.Add(this.DtpDocDataDu);
            this.Controls.Add(this.lblDataDU);
            this.Controls.Add(this.lblAviaoNavio);
            this.Controls.Add(this.lblSERVAduaneiro);
            this.Controls.Add(this.TxtDocValorAduaneiro);
            this.Controls.Add(this.lvlSERCIF);
            this.Controls.Add(this.TxtDocValorCif);
            this.Controls.Add(this.BtnDocImprimir);
            this.Controls.Add(this.dgvLinhasDocumentoDoc);
            this.Controls.Add(this.DtpDocData);
            this.Controls.Add(this.lblSERData);
            this.Controls.Add(this.lblSERCliente);
            this.Controls.Add(this.lblSEROperacao);
            this.Controls.Add(this.CbDocOperacao);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.FrmCotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasDocumentoDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CbDocNumOperacao;
        private System.Windows.Forms.Label lblSERTipoMercadoria;
        public System.Windows.Forms.TextBox TxtDocTipoMercadoria;
        public System.Windows.Forms.TextBox TxtDocNomeCliente;
        private System.Windows.Forms.Label lblSERDUP;
        public System.Windows.Forms.TextBox TxtDocDup;
        private System.Windows.Forms.Label lblSERMoeda;
        private System.Windows.Forms.Label lblSERPorteBL;
        public System.Windows.Forms.TextBox TxtDocPorteBl;
        private System.Windows.Forms.Label lblSERNumDU;
        public System.Windows.Forms.TextBox TxtDocDu;
        public System.Windows.Forms.DateTimePicker DtpDocDataDu;
        private System.Windows.Forms.Label lblDataDU;
        private System.Windows.Forms.Label lblAviaoNavio;
        private System.Windows.Forms.Label lblSERVAduaneiro;
        public System.Windows.Forms.TextBox TxtDocValorAduaneiro;
        private System.Windows.Forms.Label lvlSERCIF;
        public System.Windows.Forms.TextBox TxtDocValorCif;
        private System.Windows.Forms.Button BtnDocImprimir;
        public System.Windows.Forms.DataGridView dgvLinhasDocumentoDoc;
        public System.Windows.Forms.DateTimePicker DtpDocData;
        private System.Windows.Forms.Label lblSERData;
        private System.Windows.Forms.Label lblSERCliente;
        private System.Windows.Forms.Label lblSEROperacao;
        public System.Windows.Forms.ComboBox CbDocOperacao;
        public System.Windows.Forms.ComboBox CbDocAno;
        public System.Windows.Forms.TextBox TxtDocTransporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtDocTotalSIva;
        public System.Windows.Forms.TextBox TxtDocTotalIva;
        public System.Windows.Forms.TextBox TxtDocTotalDoc;
        public System.Windows.Forms.TextBox TxtDocTotalRet;
        private System.Windows.Forms.Button BtnDocConverter;
        public System.Windows.Forms.TextBox TxtDocCliente;
        public System.Windows.Forms.TextBox TxtDocMoeda;
        public System.Windows.Forms.TextBox TxtDocCambio;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtDocNumDocConvertido;
    }
}