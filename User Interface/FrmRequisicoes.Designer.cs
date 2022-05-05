
namespace TRTv10.User_Interface
{
    partial class FrmRequisicoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisicoes));
            this.CbReqNumOperacao = new System.Windows.Forms.ComboBox();
            this.CbReqTransporte = new System.Windows.Forms.ComboBox();
            this.lblSERTipoMercadoria = new System.Windows.Forms.Label();
            this.TxtReqTipoMercadoria = new System.Windows.Forms.TextBox();
            this.TxtReqNomeCliente = new System.Windows.Forms.TextBox();
            this.BtnReqAnular = new System.Windows.Forms.Button();
            this.BtnReqLimpaForm = new System.Windows.Forms.Button();
            this.lblSERRUP = new System.Windows.Forms.Label();
            this.TxtReqRUP = new System.Windows.Forms.TextBox();
            this.lblSERDUP = new System.Windows.Forms.Label();
            this.TxtReqDUP = new System.Windows.Forms.TextBox();
            this.lblSERCNCA = new System.Windows.Forms.Label();
            this.TxtReqCNCA = new System.Windows.Forms.TextBox();
            this.CbReqMoeda = new System.Windows.Forms.ComboBox();
            this.lblSERMoeda = new System.Windows.Forms.Label();
            this.lblSERPeso = new System.Windows.Forms.Label();
            this.TxtReqPesoKGs = new System.Windows.Forms.TextBox();
            this.lblSERReferencia = new System.Windows.Forms.Label();
            this.TxtReqVReferencia = new System.Windows.Forms.TextBox();
            this.lblSERPorteBL = new System.Windows.Forms.Label();
            this.TxtReqPorteBL = new System.Windows.Forms.TextBox();
            this.lblSERNumDU = new System.Windows.Forms.Label();
            this.TxtReqDU = new System.Windows.Forms.TextBox();
            this.DtpReqDataDu = new System.Windows.Forms.DateTimePicker();
            this.DtpReqDataSaida = new System.Windows.Forms.DateTimePicker();
            this.DtpReqDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.DtpReqDataChegada = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblDataDU = new System.Windows.Forms.Label();
            this.lblSERNumDAR = new System.Windows.Forms.Label();
            this.TxtReqDar = new System.Windows.Forms.TextBox();
            this.lblSERManifesto = new System.Windows.Forms.Label();
            this.TxtReqManifesto = new System.Windows.Forms.TextBox();
            this.lblAviaoNavio = new System.Windows.Forms.Label();
            this.lblSERVDar = new System.Windows.Forms.Label();
            this.TxtReqValorDar = new System.Windows.Forms.TextBox();
            this.lblVNDObs = new System.Windows.Forms.Label();
            this.TxtRetObs = new System.Windows.Forms.TextBox();
            this.lblSERVAduaneiro = new System.Windows.Forms.Label();
            this.TxtReqValorAduaneiro = new System.Windows.Forms.TextBox();
            this.lvlSERCIF = new System.Windows.Forms.Label();
            this.TxtReqValorCIF = new System.Windows.Forms.TextBox();
            this.lblSERNumVolumes = new System.Windows.Forms.Label();
            this.TxtReqNumVolumes = new System.Windows.Forms.TextBox();
            this.BtnReqImprimir = new System.Windows.Forms.Button();
            this.dgvLinhasDocumentosReq = new System.Windows.Forms.DataGridView();
            this.DtpReqData = new System.Windows.Forms.DateTimePicker();
            this.lblSERData = new System.Windows.Forms.Label();
            this.lblSERCliente = new System.Windows.Forms.Label();
            this.CbReqCliente = new System.Windows.Forms.ComboBox();
            this.lblSEROperacao = new System.Windows.Forms.Label();
            this.CbReqOperacao = new System.Windows.Forms.ComboBox();
            this.lblSERCambio = new System.Windows.Forms.Label();
            this.TxtReqCambio = new System.Windows.Forms.TextBox();
            this.lblSERTipoServ = new System.Windows.Forms.Label();
            this.CbReqTServico = new System.Windows.Forms.ComboBox();
            this.CbReqAno = new System.Windows.Forms.ComboBox();
            this.CbReqNumProcesso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasDocumentosReq)).BeginInit();
            this.SuspendLayout();
            // 
            // CbReqNumOperacao
            // 
            this.CbReqNumOperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqNumOperacao.FormattingEnabled = true;
            this.CbReqNumOperacao.Location = new System.Drawing.Point(521, 117);
            this.CbReqNumOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbReqNumOperacao.Name = "CbReqNumOperacao";
            this.CbReqNumOperacao.Size = new System.Drawing.Size(66, 25);
            this.CbReqNumOperacao.TabIndex = 159;
            this.CbReqNumOperacao.SelectedIndexChanged += new System.EventHandler(this.cbReqNumOperacao_SelectedIndexChanged);
            // 
            // CbReqTransporte
            // 
            this.CbReqTransporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqTransporte.FormattingEnabled = true;
            this.CbReqTransporte.Location = new System.Drawing.Point(502, 217);
            this.CbReqTransporte.Name = "CbReqTransporte";
            this.CbReqTransporte.Size = new System.Drawing.Size(151, 25);
            this.CbReqTransporte.TabIndex = 115;
            this.CbReqTransporte.SelectedIndexChanged += new System.EventHandler(this.CbReqTransporte_SelectedIndexChanged);
            // 
            // lblSERTipoMercadoria
            // 
            this.lblSERTipoMercadoria.AutoSize = true;
            this.lblSERTipoMercadoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERTipoMercadoria.Location = new System.Drawing.Point(26, 573);
            this.lblSERTipoMercadoria.Name = "lblSERTipoMercadoria";
            this.lblSERTipoMercadoria.Size = new System.Drawing.Size(125, 17);
            this.lblSERTipoMercadoria.TabIndex = 157;
            this.lblSERTipoMercadoria.Text = "Tipo de Mercadoria";
            // 
            // TxtReqTipoMercadoria
            // 
            this.TxtReqTipoMercadoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqTipoMercadoria.Location = new System.Drawing.Point(165, 570);
            this.TxtReqTipoMercadoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqTipoMercadoria.Name = "TxtReqTipoMercadoria";
            this.TxtReqTipoMercadoria.Size = new System.Drawing.Size(488, 25);
            this.TxtReqTipoMercadoria.TabIndex = 113;
            // 
            // TxtReqNomeCliente
            // 
            this.TxtReqNomeCliente.Enabled = false;
            this.TxtReqNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqNomeCliente.Location = new System.Drawing.Point(165, 185);
            this.TxtReqNomeCliente.Name = "TxtReqNomeCliente";
            this.TxtReqNomeCliente.Size = new System.Drawing.Size(488, 25);
            this.TxtReqNomeCliente.TabIndex = 101;
            // 
            // BtnReqAnular
            // 
            this.BtnReqAnular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnReqAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReqAnular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReqAnular.ForeColor = System.Drawing.Color.White;
            this.BtnReqAnular.Location = new System.Drawing.Point(134, 24);
            this.BtnReqAnular.Name = "BtnReqAnular";
            this.BtnReqAnular.Size = new System.Drawing.Size(98, 38);
            this.BtnReqAnular.TabIndex = 96;
            this.BtnReqAnular.Text = "Anular";
            this.BtnReqAnular.UseVisualStyleBackColor = false;
            // 
            // BtnReqLimpaForm
            // 
            this.BtnReqLimpaForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnReqLimpaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReqLimpaForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReqLimpaForm.ForeColor = System.Drawing.Color.White;
            this.BtnReqLimpaForm.Location = new System.Drawing.Point(238, 24);
            this.BtnReqLimpaForm.Name = "BtnReqLimpaForm";
            this.BtnReqLimpaForm.Size = new System.Drawing.Size(106, 38);
            this.BtnReqLimpaForm.TabIndex = 97;
            this.BtnReqLimpaForm.Text = "Limpar Dados";
            this.BtnReqLimpaForm.UseVisualStyleBackColor = false;
            this.BtnReqLimpaForm.Click += new System.EventHandler(this.BtnReqLimpaForm_Click);
            // 
            // lblSERRUP
            // 
            this.lblSERRUP.AutoSize = true;
            this.lblSERRUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERRUP.Location = new System.Drawing.Point(26, 447);
            this.lblSERRUP.Name = "lblSERRUP";
            this.lblSERRUP.Size = new System.Drawing.Size(32, 17);
            this.lblSERRUP.TabIndex = 156;
            this.lblSERRUP.Text = "RUP";
            // 
            // TxtReqRUP
            // 
            this.TxtReqRUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqRUP.Location = new System.Drawing.Point(165, 444);
            this.TxtReqRUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqRUP.Name = "TxtReqRUP";
            this.TxtReqRUP.Size = new System.Drawing.Size(166, 25);
            this.TxtReqRUP.TabIndex = 109;
            // 
            // lblSERDUP
            // 
            this.lblSERDUP.AutoSize = true;
            this.lblSERDUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERDUP.Location = new System.Drawing.Point(26, 384);
            this.lblSERDUP.Name = "lblSERDUP";
            this.lblSERDUP.Size = new System.Drawing.Size(33, 17);
            this.lblSERDUP.TabIndex = 155;
            this.lblSERDUP.Text = "DUP";
            // 
            // TxtReqDUP
            // 
            this.TxtReqDUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqDUP.Location = new System.Drawing.Point(165, 380);
            this.TxtReqDUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqDUP.Name = "TxtReqDUP";
            this.TxtReqDUP.Size = new System.Drawing.Size(166, 25);
            this.TxtReqDUP.TabIndex = 107;
            // 
            // lblSERCNCA
            // 
            this.lblSERCNCA.AutoSize = true;
            this.lblSERCNCA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCNCA.Location = new System.Drawing.Point(26, 350);
            this.lblSERCNCA.Name = "lblSERCNCA";
            this.lblSERCNCA.Size = new System.Drawing.Size(42, 17);
            this.lblSERCNCA.TabIndex = 154;
            this.lblSERCNCA.Text = "CNCA";
            // 
            // TxtReqCNCA
            // 
            this.TxtReqCNCA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqCNCA.Location = new System.Drawing.Point(165, 347);
            this.TxtReqCNCA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqCNCA.Name = "TxtReqCNCA";
            this.TxtReqCNCA.Size = new System.Drawing.Size(166, 25);
            this.TxtReqCNCA.TabIndex = 106;
            // 
            // CbReqMoeda
            // 
            this.CbReqMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqMoeda.FormattingEnabled = true;
            this.CbReqMoeda.Location = new System.Drawing.Point(165, 216);
            this.CbReqMoeda.Name = "CbReqMoeda";
            this.CbReqMoeda.Size = new System.Drawing.Size(166, 25);
            this.CbReqMoeda.TabIndex = 102;
            this.CbReqMoeda.SelectedIndexChanged += new System.EventHandler(this.CbReqMoeda_SelectedIndexChanged);
            // 
            // lblSERMoeda
            // 
            this.lblSERMoeda.AutoSize = true;
            this.lblSERMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERMoeda.Location = new System.Drawing.Point(26, 219);
            this.lblSERMoeda.Name = "lblSERMoeda";
            this.lblSERMoeda.Size = new System.Drawing.Size(98, 17);
            this.lblSERMoeda.TabIndex = 153;
            this.lblSERMoeda.Text = "Moeda Origem";
            // 
            // lblSERPeso
            // 
            this.lblSERPeso.AutoSize = true;
            this.lblSERPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERPeso.Location = new System.Drawing.Point(362, 510);
            this.lblSERPeso.Name = "lblSERPeso";
            this.lblSERPeso.Size = new System.Drawing.Size(84, 17);
            this.lblSERPeso.TabIndex = 152;
            this.lblSERPeso.Text = "Peso em KGs";
            // 
            // TxtReqPesoKGs
            // 
            this.TxtReqPesoKGs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqPesoKGs.Location = new System.Drawing.Point(502, 507);
            this.TxtReqPesoKGs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqPesoKGs.Name = "TxtReqPesoKGs";
            this.TxtReqPesoKGs.Size = new System.Drawing.Size(151, 25);
            this.TxtReqPesoKGs.TabIndex = 126;
            // 
            // lblSERReferencia
            // 
            this.lblSERReferencia.AutoSize = true;
            this.lblSERReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERReferencia.Location = new System.Drawing.Point(27, 478);
            this.lblSERReferencia.Name = "lblSERReferencia";
            this.lblSERReferencia.Size = new System.Drawing.Size(86, 17);
            this.lblSERReferencia.TabIndex = 151;
            this.lblSERReferencia.Text = "V/ Referência";
            // 
            // TxtReqVReferencia
            // 
            this.TxtReqVReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqVReferencia.Location = new System.Drawing.Point(165, 475);
            this.TxtReqVReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqVReferencia.Name = "TxtReqVReferencia";
            this.TxtReqVReferencia.Size = new System.Drawing.Size(166, 25);
            this.TxtReqVReferencia.TabIndex = 110;
            // 
            // lblSERPorteBL
            // 
            this.lblSERPorteBL.AutoSize = true;
            this.lblSERPorteBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERPorteBL.Location = new System.Drawing.Point(26, 416);
            this.lblSERPorteBL.Name = "lblSERPorteBL";
            this.lblSERPorteBL.Size = new System.Drawing.Size(119, 17);
            this.lblSERPorteBL.TabIndex = 150;
            this.lblSERPorteBL.Text = "Carta de Porte / BL";
            // 
            // TxtReqPorteBL
            // 
            this.TxtReqPorteBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqPorteBL.Location = new System.Drawing.Point(165, 413);
            this.TxtReqPorteBL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqPorteBL.Name = "TxtReqPorteBL";
            this.TxtReqPorteBL.Size = new System.Drawing.Size(166, 25);
            this.TxtReqPorteBL.TabIndex = 108;
            // 
            // lblSERNumDU
            // 
            this.lblSERNumDU.AutoSize = true;
            this.lblSERNumDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumDU.Location = new System.Drawing.Point(362, 351);
            this.lblSERNumDU.Name = "lblSERNumDU";
            this.lblSERNumDU.Size = new System.Drawing.Size(49, 17);
            this.lblSERNumDU.TabIndex = 149;
            this.lblSERNumDU.Text = "N.º DU";
            // 
            // TxtReqDU
            // 
            this.TxtReqDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqDU.Location = new System.Drawing.Point(502, 348);
            this.TxtReqDU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqDU.Name = "TxtReqDU";
            this.TxtReqDU.Size = new System.Drawing.Size(151, 25);
            this.TxtReqDU.TabIndex = 120;
            // 
            // DtpReqDataDu
            // 
            this.DtpReqDataDu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReqDataDu.Location = new System.Drawing.Point(502, 475);
            this.DtpReqDataDu.Name = "DtpReqDataDu";
            this.DtpReqDataDu.Size = new System.Drawing.Size(151, 25);
            this.DtpReqDataDu.TabIndex = 125;
            // 
            // DtpReqDataSaida
            // 
            this.DtpReqDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReqDataSaida.Location = new System.Drawing.Point(502, 444);
            this.DtpReqDataSaida.Name = "DtpReqDataSaida";
            this.DtpReqDataSaida.Size = new System.Drawing.Size(151, 25);
            this.DtpReqDataSaida.TabIndex = 123;
            // 
            // DtpReqDataEntrada
            // 
            this.DtpReqDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReqDataEntrada.Location = new System.Drawing.Point(502, 413);
            this.DtpReqDataEntrada.Name = "DtpReqDataEntrada";
            this.DtpReqDataEntrada.Size = new System.Drawing.Size(151, 25);
            this.DtpReqDataEntrada.TabIndex = 122;
            // 
            // DtpReqDataChegada
            // 
            this.DtpReqDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReqDataChegada.Location = new System.Drawing.Point(165, 538);
            this.DtpReqDataChegada.Name = "DtpReqDataChegada";
            this.DtpReqDataChegada.Size = new System.Drawing.Size(166, 25);
            this.DtpReqDataChegada.TabIndex = 112;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(362, 450);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(90, 17);
            this.lblDataSaida.TabIndex = 148;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(362, 419);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(103, 17);
            this.lblDataEntrada.TabIndex = 147;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataChegada.Location = new System.Drawing.Point(27, 544);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(91, 17);
            this.lblDataChegada.TabIndex = 146;
            this.lblDataChegada.Text = "Data Chegada";
            // 
            // lblDataDU
            // 
            this.lblDataDU.AutoSize = true;
            this.lblDataDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDU.Location = new System.Drawing.Point(362, 480);
            this.lblDataDU.Name = "lblDataDU";
            this.lblDataDU.Size = new System.Drawing.Size(57, 17);
            this.lblDataDU.TabIndex = 145;
            this.lblDataDU.Text = "Data DU";
            // 
            // lblSERNumDAR
            // 
            this.lblSERNumDAR.AutoSize = true;
            this.lblSERNumDAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumDAR.Location = new System.Drawing.Point(362, 285);
            this.lblSERNumDAR.Name = "lblSERNumDAR";
            this.lblSERNumDAR.Size = new System.Drawing.Size(56, 17);
            this.lblSERNumDAR.TabIndex = 144;
            this.lblSERNumDAR.Text = "DAR N.º";
            // 
            // TxtReqDar
            // 
            this.TxtReqDar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqDar.Location = new System.Drawing.Point(502, 282);
            this.TxtReqDar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqDar.Name = "TxtReqDar";
            this.TxtReqDar.Size = new System.Drawing.Size(151, 25);
            this.TxtReqDar.TabIndex = 117;
            // 
            // lblSERManifesto
            // 
            this.lblSERManifesto.AutoSize = true;
            this.lblSERManifesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERManifesto.Location = new System.Drawing.Point(362, 252);
            this.lblSERManifesto.Name = "lblSERManifesto";
            this.lblSERManifesto.Size = new System.Drawing.Size(66, 17);
            this.lblSERManifesto.TabIndex = 143;
            this.lblSERManifesto.Text = "Manifesto";
            // 
            // TxtReqManifesto
            // 
            this.TxtReqManifesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqManifesto.Location = new System.Drawing.Point(502, 249);
            this.TxtReqManifesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqManifesto.Name = "TxtReqManifesto";
            this.TxtReqManifesto.Size = new System.Drawing.Size(151, 25);
            this.TxtReqManifesto.TabIndex = 116;
            // 
            // lblAviaoNavio
            // 
            this.lblAviaoNavio.AutoSize = true;
            this.lblAviaoNavio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviaoNavio.Location = new System.Drawing.Point(362, 219);
            this.lblAviaoNavio.Name = "lblAviaoNavio";
            this.lblAviaoNavio.Size = new System.Drawing.Size(71, 17);
            this.lblAviaoNavio.TabIndex = 142;
            this.lblAviaoNavio.Text = "Transporte";
            // 
            // lblSERVDar
            // 
            this.lblSERVDar.AutoSize = true;
            this.lblSERVDar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERVDar.Location = new System.Drawing.Point(362, 318);
            this.lblSERVDar.Name = "lblSERVDar";
            this.lblSERVDar.Size = new System.Drawing.Size(67, 17);
            this.lblSERVDar.TabIndex = 141;
            this.lblSERVDar.Text = "Valor DAR";
            // 
            // TxtReqValorDar
            // 
            this.TxtReqValorDar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqValorDar.Location = new System.Drawing.Point(502, 315);
            this.TxtReqValorDar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqValorDar.Name = "TxtReqValorDar";
            this.TxtReqValorDar.Size = new System.Drawing.Size(151, 25);
            this.TxtReqValorDar.TabIndex = 119;
            // 
            // lblVNDObs
            // 
            this.lblVNDObs.AutoSize = true;
            this.lblVNDObs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVNDObs.Location = new System.Drawing.Point(26, 606);
            this.lblVNDObs.Name = "lblVNDObs";
            this.lblVNDObs.Size = new System.Drawing.Size(84, 17);
            this.lblVNDObs.TabIndex = 140;
            this.lblVNDObs.Text = "Observações";
            // 
            // TxtRetObs
            // 
            this.TxtRetObs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRetObs.Location = new System.Drawing.Point(165, 603);
            this.TxtRetObs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtRetObs.Multiline = true;
            this.TxtRetObs.Name = "TxtRetObs";
            this.TxtRetObs.Size = new System.Drawing.Size(488, 25);
            this.TxtRetObs.TabIndex = 114;
            // 
            // lblSERVAduaneiro
            // 
            this.lblSERVAduaneiro.AutoSize = true;
            this.lblSERVAduaneiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERVAduaneiro.Location = new System.Drawing.Point(26, 284);
            this.lblSERVAduaneiro.Name = "lblSERVAduaneiro";
            this.lblSERVAduaneiro.Size = new System.Drawing.Size(102, 17);
            this.lblSERVAduaneiro.TabIndex = 139;
            this.lblSERVAduaneiro.Text = "Valor Aduaneiro";
            // 
            // TxtReqValorAduaneiro
            // 
            this.TxtReqValorAduaneiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqValorAduaneiro.Location = new System.Drawing.Point(165, 281);
            this.TxtReqValorAduaneiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqValorAduaneiro.Name = "TxtReqValorAduaneiro";
            this.TxtReqValorAduaneiro.Size = new System.Drawing.Size(166, 25);
            this.TxtReqValorAduaneiro.TabIndex = 104;
            // 
            // lvlSERCIF
            // 
            this.lvlSERCIF.AutoSize = true;
            this.lvlSERCIF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSERCIF.Location = new System.Drawing.Point(26, 252);
            this.lvlSERCIF.Name = "lvlSERCIF";
            this.lvlSERCIF.Size = new System.Drawing.Size(59, 17);
            this.lvlSERCIF.TabIndex = 138;
            this.lvlSERCIF.Text = "Valor CIF";
            // 
            // TxtReqValorCIF
            // 
            this.TxtReqValorCIF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqValorCIF.Location = new System.Drawing.Point(165, 248);
            this.TxtReqValorCIF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqValorCIF.Name = "TxtReqValorCIF";
            this.TxtReqValorCIF.Size = new System.Drawing.Size(166, 25);
            this.TxtReqValorCIF.TabIndex = 103;
            // 
            // lblSERNumVolumes
            // 
            this.lblSERNumVolumes.AutoSize = true;
            this.lblSERNumVolumes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumVolumes.Location = new System.Drawing.Point(362, 384);
            this.lblSERNumVolumes.Name = "lblSERNumVolumes";
            this.lblSERNumVolumes.Size = new System.Drawing.Size(80, 17);
            this.lblSERNumVolumes.TabIndex = 137;
            this.lblSERNumVolumes.Text = "N.º Volumes";
            // 
            // TxtReqNumVolumes
            // 
            this.TxtReqNumVolumes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqNumVolumes.Location = new System.Drawing.Point(502, 381);
            this.TxtReqNumVolumes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqNumVolumes.Name = "TxtReqNumVolumes";
            this.TxtReqNumVolumes.Size = new System.Drawing.Size(151, 25);
            this.TxtReqNumVolumes.TabIndex = 121;
            // 
            // BtnReqImprimir
            // 
            this.BtnReqImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnReqImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReqImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReqImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnReqImprimir.Location = new System.Drawing.Point(29, 24);
            this.BtnReqImprimir.Name = "BtnReqImprimir";
            this.BtnReqImprimir.Size = new System.Drawing.Size(99, 38);
            this.BtnReqImprimir.TabIndex = 95;
            this.BtnReqImprimir.Text = "Imprimir";
            this.BtnReqImprimir.UseVisualStyleBackColor = false;
            this.BtnReqImprimir.Click += new System.EventHandler(this.BtnReqImprimir_Click);
            // 
            // dgvLinhasDocumentosReq
            // 
            this.dgvLinhasDocumentosReq.AllowUserToAddRows = false;
            this.dgvLinhasDocumentosReq.AllowUserToDeleteRows = false;
            this.dgvLinhasDocumentosReq.BackgroundColor = System.Drawing.Color.White;
            this.dgvLinhasDocumentosReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhasDocumentosReq.Location = new System.Drawing.Point(669, 24);
            this.dgvLinhasDocumentosReq.Name = "dgvLinhasDocumentosReq";
            this.dgvLinhasDocumentosReq.Size = new System.Drawing.Size(645, 604);
            this.dgvLinhasDocumentosReq.TabIndex = 136;
            this.dgvLinhasDocumentosReq.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinhasDocReq_CellValueChanged);
            // 
            // DtpReqData
            // 
            this.DtpReqData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReqData.Location = new System.Drawing.Point(165, 507);
            this.DtpReqData.Name = "DtpReqData";
            this.DtpReqData.Size = new System.Drawing.Size(166, 25);
            this.DtpReqData.TabIndex = 111;
            // 
            // lblSERData
            // 
            this.lblSERData.AutoSize = true;
            this.lblSERData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERData.Location = new System.Drawing.Point(26, 513);
            this.lblSERData.Name = "lblSERData";
            this.lblSERData.Size = new System.Drawing.Size(35, 17);
            this.lblSERData.TabIndex = 132;
            this.lblSERData.Text = "Data";
            // 
            // lblSERCliente
            // 
            this.lblSERCliente.AutoSize = true;
            this.lblSERCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCliente.Location = new System.Drawing.Point(27, 156);
            this.lblSERCliente.Name = "lblSERCliente";
            this.lblSERCliente.Size = new System.Drawing.Size(47, 17);
            this.lblSERCliente.TabIndex = 130;
            this.lblSERCliente.Text = "Cliente";
            // 
            // CbReqCliente
            // 
            this.CbReqCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqCliente.FormattingEnabled = true;
            this.CbReqCliente.Location = new System.Drawing.Point(165, 153);
            this.CbReqCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbReqCliente.Name = "CbReqCliente";
            this.CbReqCliente.Size = new System.Drawing.Size(488, 25);
            this.CbReqCliente.TabIndex = 100;
            this.CbReqCliente.SelectedIndexChanged += new System.EventHandler(this.CbReqCliente_SelectedIndexChanged);
            // 
            // lblSEROperacao
            // 
            this.lblSEROperacao.AutoSize = true;
            this.lblSEROperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEROperacao.Location = new System.Drawing.Point(27, 120);
            this.lblSEROperacao.Name = "lblSEROperacao";
            this.lblSEROperacao.Size = new System.Drawing.Size(66, 17);
            this.lblSEROperacao.TabIndex = 127;
            this.lblSEROperacao.Text = "Operação";
            // 
            // CbReqOperacao
            // 
            this.CbReqOperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqOperacao.FormattingEnabled = true;
            this.CbReqOperacao.Location = new System.Drawing.Point(165, 117);
            this.CbReqOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbReqOperacao.Name = "CbReqOperacao";
            this.CbReqOperacao.Size = new System.Drawing.Size(350, 25);
            this.CbReqOperacao.TabIndex = 99;
            this.CbReqOperacao.SelectedIndexChanged += new System.EventHandler(this.CbReqOperacao_SelectedIndexChanged);
            // 
            // lblSERCambio
            // 
            this.lblSERCambio.AutoSize = true;
            this.lblSERCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCambio.Location = new System.Drawing.Point(26, 318);
            this.lblSERCambio.Name = "lblSERCambio";
            this.lblSERCambio.Size = new System.Drawing.Size(53, 17);
            this.lblSERCambio.TabIndex = 124;
            this.lblSERCambio.Text = "Câmbio";
            // 
            // TxtReqCambio
            // 
            this.TxtReqCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReqCambio.Location = new System.Drawing.Point(165, 314);
            this.TxtReqCambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtReqCambio.Name = "TxtReqCambio";
            this.TxtReqCambio.Size = new System.Drawing.Size(166, 25);
            this.TxtReqCambio.TabIndex = 105;
            // 
            // lblSERTipoServ
            // 
            this.lblSERTipoServ.AutoSize = true;
            this.lblSERTipoServ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERTipoServ.Location = new System.Drawing.Point(26, 87);
            this.lblSERTipoServ.Name = "lblSERTipoServ";
            this.lblSERTipoServ.Size = new System.Drawing.Size(99, 17);
            this.lblSERTipoServ.TabIndex = 118;
            this.lblSERTipoServ.Text = "Tipo de Serviço";
            // 
            // CbReqTServico
            // 
            this.CbReqTServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqTServico.FormattingEnabled = true;
            this.CbReqTServico.Location = new System.Drawing.Point(165, 84);
            this.CbReqTServico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbReqTServico.Name = "CbReqTServico";
            this.CbReqTServico.Size = new System.Drawing.Size(488, 25);
            this.CbReqTServico.TabIndex = 98;
            // 
            // CbReqAno
            // 
            this.CbReqAno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqAno.FormattingEnabled = true;
            this.CbReqAno.Location = new System.Drawing.Point(593, 117);
            this.CbReqAno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbReqAno.Name = "CbReqAno";
            this.CbReqAno.Size = new System.Drawing.Size(60, 25);
            this.CbReqAno.TabIndex = 160;
            this.CbReqAno.SelectedIndexChanged += new System.EventHandler(this.CbReqAno_SelectedIndexChanged);
            // 
            // CbReqNumProcesso
            // 
            this.CbReqNumProcesso.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbReqNumProcesso.FormattingEnabled = true;
            this.CbReqNumProcesso.Location = new System.Drawing.Point(521, 24);
            this.CbReqNumProcesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbReqNumProcesso.Name = "CbReqNumProcesso";
            this.CbReqNumProcesso.Size = new System.Drawing.Size(132, 38);
            this.CbReqNumProcesso.TabIndex = 162;
            // 
            // FrmRequisicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 653);
            this.Controls.Add(this.CbReqNumProcesso);
            this.Controls.Add(this.CbReqAno);
            this.Controls.Add(this.CbReqNumOperacao);
            this.Controls.Add(this.CbReqTransporte);
            this.Controls.Add(this.lblSERTipoMercadoria);
            this.Controls.Add(this.TxtReqTipoMercadoria);
            this.Controls.Add(this.TxtReqNomeCliente);
            this.Controls.Add(this.BtnReqAnular);
            this.Controls.Add(this.BtnReqLimpaForm);
            this.Controls.Add(this.lblSERRUP);
            this.Controls.Add(this.TxtReqRUP);
            this.Controls.Add(this.lblSERDUP);
            this.Controls.Add(this.TxtReqDUP);
            this.Controls.Add(this.lblSERCNCA);
            this.Controls.Add(this.TxtReqCNCA);
            this.Controls.Add(this.CbReqMoeda);
            this.Controls.Add(this.lblSERMoeda);
            this.Controls.Add(this.lblSERPeso);
            this.Controls.Add(this.TxtReqPesoKGs);
            this.Controls.Add(this.lblSERReferencia);
            this.Controls.Add(this.TxtReqVReferencia);
            this.Controls.Add(this.lblSERPorteBL);
            this.Controls.Add(this.TxtReqPorteBL);
            this.Controls.Add(this.lblSERNumDU);
            this.Controls.Add(this.TxtReqDU);
            this.Controls.Add(this.DtpReqDataDu);
            this.Controls.Add(this.DtpReqDataSaida);
            this.Controls.Add(this.DtpReqDataEntrada);
            this.Controls.Add(this.DtpReqDataChegada);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblDataChegada);
            this.Controls.Add(this.lblDataDU);
            this.Controls.Add(this.lblSERNumDAR);
            this.Controls.Add(this.TxtReqDar);
            this.Controls.Add(this.lblSERManifesto);
            this.Controls.Add(this.TxtReqManifesto);
            this.Controls.Add(this.lblAviaoNavio);
            this.Controls.Add(this.lblSERVDar);
            this.Controls.Add(this.TxtReqValorDar);
            this.Controls.Add(this.lblVNDObs);
            this.Controls.Add(this.TxtRetObs);
            this.Controls.Add(this.lblSERVAduaneiro);
            this.Controls.Add(this.TxtReqValorAduaneiro);
            this.Controls.Add(this.lvlSERCIF);
            this.Controls.Add(this.TxtReqValorCIF);
            this.Controls.Add(this.lblSERNumVolumes);
            this.Controls.Add(this.TxtReqNumVolumes);
            this.Controls.Add(this.BtnReqImprimir);
            this.Controls.Add(this.dgvLinhasDocumentosReq);
            this.Controls.Add(this.DtpReqData);
            this.Controls.Add(this.lblSERData);
            this.Controls.Add(this.lblSERCliente);
            this.Controls.Add(this.CbReqCliente);
            this.Controls.Add(this.lblSEROperacao);
            this.Controls.Add(this.CbReqOperacao);
            this.Controls.Add(this.lblSERCambio);
            this.Controls.Add(this.TxtReqCambio);
            this.Controls.Add(this.lblSERTipoServ);
            this.Controls.Add(this.CbReqTServico);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRequisicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisições";
            this.Load += new System.EventHandler(this.FrmRequisicoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasDocumentosReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CbReqNumOperacao;
        public System.Windows.Forms.ComboBox CbReqTransporte;
        private System.Windows.Forms.Label lblSERTipoMercadoria;
        public System.Windows.Forms.TextBox TxtReqTipoMercadoria;
        public System.Windows.Forms.TextBox TxtReqNomeCliente;
        private System.Windows.Forms.Button BtnReqAnular;
        private System.Windows.Forms.Button BtnReqLimpaForm;
        private System.Windows.Forms.Label lblSERRUP;
        public System.Windows.Forms.TextBox TxtReqRUP;
        private System.Windows.Forms.Label lblSERDUP;
        public System.Windows.Forms.TextBox TxtReqDUP;
        private System.Windows.Forms.Label lblSERCNCA;
        public System.Windows.Forms.TextBox TxtReqCNCA;
        public System.Windows.Forms.ComboBox CbReqMoeda;
        private System.Windows.Forms.Label lblSERMoeda;
        private System.Windows.Forms.Label lblSERPeso;
        public System.Windows.Forms.TextBox TxtReqPesoKGs;
        private System.Windows.Forms.Label lblSERReferencia;
        public System.Windows.Forms.TextBox TxtReqVReferencia;
        private System.Windows.Forms.Label lblSERPorteBL;
        public System.Windows.Forms.TextBox TxtReqPorteBL;
        private System.Windows.Forms.Label lblSERNumDU;
        public System.Windows.Forms.TextBox TxtReqDU;
        public System.Windows.Forms.DateTimePicker DtpReqDataDu;
        public System.Windows.Forms.DateTimePicker DtpReqDataSaida;
        public System.Windows.Forms.DateTimePicker DtpReqDataEntrada;
        public System.Windows.Forms.DateTimePicker DtpReqDataChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label lblDataDU;
        private System.Windows.Forms.Label lblSERNumDAR;
        public System.Windows.Forms.TextBox TxtReqDar;
        private System.Windows.Forms.Label lblSERManifesto;
        public System.Windows.Forms.TextBox TxtReqManifesto;
        private System.Windows.Forms.Label lblAviaoNavio;
        private System.Windows.Forms.Label lblSERVDar;
        public System.Windows.Forms.TextBox TxtReqValorDar;
        private System.Windows.Forms.Label lblVNDObs;
        public System.Windows.Forms.TextBox TxtRetObs;
        private System.Windows.Forms.Label lblSERVAduaneiro;
        public System.Windows.Forms.TextBox TxtReqValorAduaneiro;
        private System.Windows.Forms.Label lvlSERCIF;
        public System.Windows.Forms.TextBox TxtReqValorCIF;
        private System.Windows.Forms.Label lblSERNumVolumes;
        public System.Windows.Forms.TextBox TxtReqNumVolumes;
        private System.Windows.Forms.Button BtnReqImprimir;
        public System.Windows.Forms.DataGridView dgvLinhasDocumentosReq;
        public System.Windows.Forms.DateTimePicker DtpReqData;
        private System.Windows.Forms.Label lblSERData;
        private System.Windows.Forms.Label lblSERCliente;
        public System.Windows.Forms.ComboBox CbReqCliente;
        private System.Windows.Forms.Label lblSEROperacao;
        public System.Windows.Forms.ComboBox CbReqOperacao;
        private System.Windows.Forms.Label lblSERCambio;
        public System.Windows.Forms.TextBox TxtReqCambio;
        private System.Windows.Forms.Label lblSERTipoServ;
        public System.Windows.Forms.ComboBox CbReqTServico;
        public System.Windows.Forms.ComboBox CbReqAno;
        public System.Windows.Forms.ComboBox CbReqNumProcesso;
    }
}