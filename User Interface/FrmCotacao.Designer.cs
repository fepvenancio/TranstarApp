
namespace TRTv10.User_Interface
{
    partial class FrmCotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotacao));
            this.cbCotNumOperacao = new System.Windows.Forms.ComboBox();
            this.CbCotTransporte = new System.Windows.Forms.ComboBox();
            this.lblSERTipoMercadoria = new System.Windows.Forms.Label();
            this.TxtCotTipoMercadoria = new System.Windows.Forms.TextBox();
            this.TxtCotNomeCliente = new System.Windows.Forms.TextBox();
            this.BtnCotAnular = new System.Windows.Forms.Button();
            this.BtnCotLimpaForm = new System.Windows.Forms.Button();
            this.lblSERRUP = new System.Windows.Forms.Label();
            this.TxtCotRUP = new System.Windows.Forms.TextBox();
            this.lblSERDUP = new System.Windows.Forms.Label();
            this.TxtCotDUP = new System.Windows.Forms.TextBox();
            this.lblSERCNCA = new System.Windows.Forms.Label();
            this.TxtCotCNCA = new System.Windows.Forms.TextBox();
            this.CbCotMoeda = new System.Windows.Forms.ComboBox();
            this.lblSERMoeda = new System.Windows.Forms.Label();
            this.lblSERPeso = new System.Windows.Forms.Label();
            this.TxtPesoKGs = new System.Windows.Forms.TextBox();
            this.lblSERReferencia = new System.Windows.Forms.Label();
            this.txtCotVReferencia = new System.Windows.Forms.TextBox();
            this.lblSERPorteBL = new System.Windows.Forms.Label();
            this.txtCotPorteBL = new System.Windows.Forms.TextBox();
            this.lblSERNumDU = new System.Windows.Forms.Label();
            this.TxtCotDU = new System.Windows.Forms.TextBox();
            this.DtpCotDataDu = new System.Windows.Forms.DateTimePicker();
            this.DtpCotDataSaida = new System.Windows.Forms.DateTimePicker();
            this.DtpCotDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpCotDataChegada = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblDataDU = new System.Windows.Forms.Label();
            this.lblSERNumDAR = new System.Windows.Forms.Label();
            this.txtCotDar = new System.Windows.Forms.TextBox();
            this.lblSERManifesto = new System.Windows.Forms.Label();
            this.TxtCotManifesto = new System.Windows.Forms.TextBox();
            this.lblAviaoNavio = new System.Windows.Forms.Label();
            this.lblSERVDar = new System.Windows.Forms.Label();
            this.TxtCotValorDar = new System.Windows.Forms.TextBox();
            this.lblVNDObs = new System.Windows.Forms.Label();
            this.TxtCotObs = new System.Windows.Forms.TextBox();
            this.lblSERVAduaneiro = new System.Windows.Forms.Label();
            this.txtCotValorAduaneiro = new System.Windows.Forms.TextBox();
            this.lvlSERCIF = new System.Windows.Forms.Label();
            this.txtCotValorCIF = new System.Windows.Forms.TextBox();
            this.lblSERNumVolumes = new System.Windows.Forms.Label();
            this.TxtCotNumVolumes = new System.Windows.Forms.TextBox();
            this.BtnCotImprimir = new System.Windows.Forms.Button();
            this.dgvItemsServicosCOT = new System.Windows.Forms.DataGridView();
            this.DtpCotData = new System.Windows.Forms.DateTimePicker();
            this.lblSERData = new System.Windows.Forms.Label();
            this.lblSERCliente = new System.Windows.Forms.Label();
            this.cbCotCliente = new System.Windows.Forms.ComboBox();
            this.lblSEROperacao = new System.Windows.Forms.Label();
            this.cbCotOperacao = new System.Windows.Forms.ComboBox();
            this.lblSERCambio = new System.Windows.Forms.Label();
            this.txtCotCambio = new System.Windows.Forms.TextBox();
            this.lblSERTipoServ = new System.Windows.Forms.Label();
            this.cbCotTServico = new System.Windows.Forms.ComboBox();
            this.txtCotTimer = new System.Windows.Forms.TextBox();
            this.CbCotAno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsServicosCOT)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCotNumOperacao
            // 
            this.cbCotNumOperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCotNumOperacao.FormattingEnabled = true;
            this.cbCotNumOperacao.Location = new System.Drawing.Point(521, 117);
            this.cbCotNumOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCotNumOperacao.Name = "cbCotNumOperacao";
            this.cbCotNumOperacao.Size = new System.Drawing.Size(66, 25);
            this.cbCotNumOperacao.TabIndex = 159;
            this.cbCotNumOperacao.SelectedIndexChanged += new System.EventHandler(this.cbCotNumOperacao_SelectedIndexChanged);
            // 
            // CbCotTransporte
            // 
            this.CbCotTransporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCotTransporte.FormattingEnabled = true;
            this.CbCotTransporte.Location = new System.Drawing.Point(502, 217);
            this.CbCotTransporte.Name = "CbCotTransporte";
            this.CbCotTransporte.Size = new System.Drawing.Size(151, 25);
            this.CbCotTransporte.TabIndex = 115;
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
            // TxtCotTipoMercadoria
            // 
            this.TxtCotTipoMercadoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotTipoMercadoria.Location = new System.Drawing.Point(165, 570);
            this.TxtCotTipoMercadoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotTipoMercadoria.Name = "TxtCotTipoMercadoria";
            this.TxtCotTipoMercadoria.Size = new System.Drawing.Size(488, 25);
            this.TxtCotTipoMercadoria.TabIndex = 113;
            // 
            // TxtCotNomeCliente
            // 
            this.TxtCotNomeCliente.Enabled = false;
            this.TxtCotNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotNomeCliente.Location = new System.Drawing.Point(165, 185);
            this.TxtCotNomeCliente.Name = "TxtCotNomeCliente";
            this.TxtCotNomeCliente.Size = new System.Drawing.Size(488, 25);
            this.TxtCotNomeCliente.TabIndex = 101;
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
            this.BtnCotLimpaForm.Click += new System.EventHandler(this.BtnCotLimpaForm_Click);
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
            // TxtCotRUP
            // 
            this.TxtCotRUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotRUP.Location = new System.Drawing.Point(165, 444);
            this.TxtCotRUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotRUP.Name = "TxtCotRUP";
            this.TxtCotRUP.Size = new System.Drawing.Size(166, 25);
            this.TxtCotRUP.TabIndex = 109;
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
            // TxtCotDUP
            // 
            this.TxtCotDUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotDUP.Location = new System.Drawing.Point(165, 380);
            this.TxtCotDUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotDUP.Name = "TxtCotDUP";
            this.TxtCotDUP.Size = new System.Drawing.Size(166, 25);
            this.TxtCotDUP.TabIndex = 107;
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
            // TxtCotCNCA
            // 
            this.TxtCotCNCA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotCNCA.Location = new System.Drawing.Point(165, 347);
            this.TxtCotCNCA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotCNCA.Name = "TxtCotCNCA";
            this.TxtCotCNCA.Size = new System.Drawing.Size(166, 25);
            this.TxtCotCNCA.TabIndex = 106;
            // 
            // CbCotMoeda
            // 
            this.CbCotMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCotMoeda.FormattingEnabled = true;
            this.CbCotMoeda.Location = new System.Drawing.Point(165, 216);
            this.CbCotMoeda.Name = "CbCotMoeda";
            this.CbCotMoeda.Size = new System.Drawing.Size(166, 25);
            this.CbCotMoeda.TabIndex = 102;
            this.CbCotMoeda.SelectedIndexChanged += new System.EventHandler(this.CbCotMoeda_SelectedIndexChanged);
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
            // TxtPesoKGs
            // 
            this.TxtPesoKGs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesoKGs.Location = new System.Drawing.Point(502, 507);
            this.TxtPesoKGs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPesoKGs.Name = "TxtPesoKGs";
            this.TxtPesoKGs.Size = new System.Drawing.Size(151, 25);
            this.TxtPesoKGs.TabIndex = 126;
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
            // txtCotVReferencia
            // 
            this.txtCotVReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotVReferencia.Location = new System.Drawing.Point(165, 475);
            this.txtCotVReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCotVReferencia.Name = "txtCotVReferencia";
            this.txtCotVReferencia.Size = new System.Drawing.Size(166, 25);
            this.txtCotVReferencia.TabIndex = 110;
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
            // txtCotPorteBL
            // 
            this.txtCotPorteBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotPorteBL.Location = new System.Drawing.Point(165, 413);
            this.txtCotPorteBL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCotPorteBL.Name = "txtCotPorteBL";
            this.txtCotPorteBL.Size = new System.Drawing.Size(166, 25);
            this.txtCotPorteBL.TabIndex = 108;
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
            // TxtCotDU
            // 
            this.TxtCotDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotDU.Location = new System.Drawing.Point(502, 348);
            this.TxtCotDU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotDU.Name = "TxtCotDU";
            this.TxtCotDU.Size = new System.Drawing.Size(151, 25);
            this.TxtCotDU.TabIndex = 120;
            // 
            // DtpCotDataDu
            // 
            this.DtpCotDataDu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCotDataDu.Location = new System.Drawing.Point(502, 475);
            this.DtpCotDataDu.Name = "DtpCotDataDu";
            this.DtpCotDataDu.Size = new System.Drawing.Size(151, 25);
            this.DtpCotDataDu.TabIndex = 125;
            // 
            // DtpCotDataSaida
            // 
            this.DtpCotDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCotDataSaida.Location = new System.Drawing.Point(502, 444);
            this.DtpCotDataSaida.Name = "DtpCotDataSaida";
            this.DtpCotDataSaida.Size = new System.Drawing.Size(151, 25);
            this.DtpCotDataSaida.TabIndex = 123;
            // 
            // DtpCotDataEntrada
            // 
            this.DtpCotDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCotDataEntrada.Location = new System.Drawing.Point(502, 413);
            this.DtpCotDataEntrada.Name = "DtpCotDataEntrada";
            this.DtpCotDataEntrada.Size = new System.Drawing.Size(151, 25);
            this.DtpCotDataEntrada.TabIndex = 122;
            // 
            // dtpCotDataChegada
            // 
            this.dtpCotDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCotDataChegada.Location = new System.Drawing.Point(165, 538);
            this.dtpCotDataChegada.Name = "dtpCotDataChegada";
            this.dtpCotDataChegada.Size = new System.Drawing.Size(166, 25);
            this.dtpCotDataChegada.TabIndex = 112;
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
            // txtCotDar
            // 
            this.txtCotDar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotDar.Location = new System.Drawing.Point(502, 282);
            this.txtCotDar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCotDar.Name = "txtCotDar";
            this.txtCotDar.Size = new System.Drawing.Size(151, 25);
            this.txtCotDar.TabIndex = 117;
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
            // TxtCotManifesto
            // 
            this.TxtCotManifesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotManifesto.Location = new System.Drawing.Point(502, 249);
            this.TxtCotManifesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotManifesto.Name = "TxtCotManifesto";
            this.TxtCotManifesto.Size = new System.Drawing.Size(151, 25);
            this.TxtCotManifesto.TabIndex = 116;
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
            // TxtCotValorDar
            // 
            this.TxtCotValorDar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotValorDar.Location = new System.Drawing.Point(502, 315);
            this.TxtCotValorDar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotValorDar.Name = "TxtCotValorDar";
            this.TxtCotValorDar.Size = new System.Drawing.Size(151, 25);
            this.TxtCotValorDar.TabIndex = 119;
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
            // TxtCotObs
            // 
            this.TxtCotObs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotObs.Location = new System.Drawing.Point(165, 603);
            this.TxtCotObs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotObs.Multiline = true;
            this.TxtCotObs.Name = "TxtCotObs";
            this.TxtCotObs.Size = new System.Drawing.Size(488, 25);
            this.TxtCotObs.TabIndex = 114;
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
            // txtCotValorAduaneiro
            // 
            this.txtCotValorAduaneiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotValorAduaneiro.Location = new System.Drawing.Point(165, 281);
            this.txtCotValorAduaneiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCotValorAduaneiro.Name = "txtCotValorAduaneiro";
            this.txtCotValorAduaneiro.Size = new System.Drawing.Size(166, 25);
            this.txtCotValorAduaneiro.TabIndex = 104;
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
            // txtCotValorCIF
            // 
            this.txtCotValorCIF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotValorCIF.Location = new System.Drawing.Point(165, 248);
            this.txtCotValorCIF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCotValorCIF.Name = "txtCotValorCIF";
            this.txtCotValorCIF.Size = new System.Drawing.Size(166, 25);
            this.txtCotValorCIF.TabIndex = 103;
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
            // TxtCotNumVolumes
            // 
            this.TxtCotNumVolumes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotNumVolumes.Location = new System.Drawing.Point(502, 381);
            this.TxtCotNumVolumes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCotNumVolumes.Name = "TxtCotNumVolumes";
            this.TxtCotNumVolumes.Size = new System.Drawing.Size(151, 25);
            this.TxtCotNumVolumes.TabIndex = 121;
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
            // dgvItemsServicosCOT
            // 
            this.dgvItemsServicosCOT.AllowUserToAddRows = false;
            this.dgvItemsServicosCOT.AllowUserToDeleteRows = false;
            this.dgvItemsServicosCOT.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemsServicosCOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsServicosCOT.Location = new System.Drawing.Point(669, 24);
            this.dgvItemsServicosCOT.Name = "dgvItemsServicosCOT";
            this.dgvItemsServicosCOT.Size = new System.Drawing.Size(645, 604);
            this.dgvItemsServicosCOT.TabIndex = 136;
            this.dgvItemsServicosCOT.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsServicosCOT_CellValueChanged);
            // 
            // DtpCotData
            // 
            this.DtpCotData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCotData.Location = new System.Drawing.Point(165, 507);
            this.DtpCotData.Name = "DtpCotData";
            this.DtpCotData.Size = new System.Drawing.Size(166, 25);
            this.DtpCotData.TabIndex = 111;
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
            // cbCotCliente
            // 
            this.cbCotCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCotCliente.FormattingEnabled = true;
            this.cbCotCliente.Location = new System.Drawing.Point(165, 153);
            this.cbCotCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCotCliente.Name = "cbCotCliente";
            this.cbCotCliente.Size = new System.Drawing.Size(488, 25);
            this.cbCotCliente.TabIndex = 100;
            this.cbCotCliente.SelectedIndexChanged += new System.EventHandler(this.CbCotCliente_SelectedIndexChanged);
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
            // cbCotOperacao
            // 
            this.cbCotOperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCotOperacao.FormattingEnabled = true;
            this.cbCotOperacao.Location = new System.Drawing.Point(165, 117);
            this.cbCotOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCotOperacao.Name = "cbCotOperacao";
            this.cbCotOperacao.Size = new System.Drawing.Size(350, 25);
            this.cbCotOperacao.TabIndex = 99;
            this.cbCotOperacao.SelectedIndexChanged += new System.EventHandler(this.CbCotOperacao_SelectedIndexChanged);
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
            // txtCotCambio
            // 
            this.txtCotCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotCambio.Location = new System.Drawing.Point(165, 314);
            this.txtCotCambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCotCambio.Name = "txtCotCambio";
            this.txtCotCambio.Size = new System.Drawing.Size(166, 25);
            this.txtCotCambio.TabIndex = 105;
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
            // cbCotTServico
            // 
            this.cbCotTServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCotTServico.FormattingEnabled = true;
            this.cbCotTServico.Location = new System.Drawing.Point(165, 84);
            this.cbCotTServico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCotTServico.Name = "cbCotTServico";
            this.cbCotTServico.Size = new System.Drawing.Size(488, 25);
            this.cbCotTServico.TabIndex = 98;
            // 
            // txtCotTimer
            // 
            this.txtCotTimer.BackColor = System.Drawing.SystemColors.Control;
            this.txtCotTimer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotTimer.Location = new System.Drawing.Point(533, 26);
            this.txtCotTimer.Name = "txtCotTimer";
            this.txtCotTimer.Size = new System.Drawing.Size(120, 33);
            this.txtCotTimer.TabIndex = 135;
            this.txtCotTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotTimer.Visible = false;
            // 
            // CbCotAno
            // 
            this.CbCotAno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCotAno.FormattingEnabled = true;
            this.CbCotAno.Location = new System.Drawing.Point(593, 117);
            this.CbCotAno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbCotAno.Name = "CbCotAno";
            this.CbCotAno.Size = new System.Drawing.Size(60, 25);
            this.CbCotAno.TabIndex = 160;
            // 
            // FrmCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 653);
            this.Controls.Add(this.CbCotAno);
            this.Controls.Add(this.cbCotNumOperacao);
            this.Controls.Add(this.CbCotTransporte);
            this.Controls.Add(this.lblSERTipoMercadoria);
            this.Controls.Add(this.TxtCotTipoMercadoria);
            this.Controls.Add(this.txtCotTimer);
            this.Controls.Add(this.TxtCotNomeCliente);
            this.Controls.Add(this.BtnCotAnular);
            this.Controls.Add(this.BtnCotLimpaForm);
            this.Controls.Add(this.lblSERRUP);
            this.Controls.Add(this.TxtCotRUP);
            this.Controls.Add(this.lblSERDUP);
            this.Controls.Add(this.TxtCotDUP);
            this.Controls.Add(this.lblSERCNCA);
            this.Controls.Add(this.TxtCotCNCA);
            this.Controls.Add(this.CbCotMoeda);
            this.Controls.Add(this.lblSERMoeda);
            this.Controls.Add(this.lblSERPeso);
            this.Controls.Add(this.TxtPesoKGs);
            this.Controls.Add(this.lblSERReferencia);
            this.Controls.Add(this.txtCotVReferencia);
            this.Controls.Add(this.lblSERPorteBL);
            this.Controls.Add(this.txtCotPorteBL);
            this.Controls.Add(this.lblSERNumDU);
            this.Controls.Add(this.TxtCotDU);
            this.Controls.Add(this.DtpCotDataDu);
            this.Controls.Add(this.DtpCotDataSaida);
            this.Controls.Add(this.DtpCotDataEntrada);
            this.Controls.Add(this.dtpCotDataChegada);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblDataChegada);
            this.Controls.Add(this.lblDataDU);
            this.Controls.Add(this.lblSERNumDAR);
            this.Controls.Add(this.txtCotDar);
            this.Controls.Add(this.lblSERManifesto);
            this.Controls.Add(this.TxtCotManifesto);
            this.Controls.Add(this.lblAviaoNavio);
            this.Controls.Add(this.lblSERVDar);
            this.Controls.Add(this.TxtCotValorDar);
            this.Controls.Add(this.lblVNDObs);
            this.Controls.Add(this.TxtCotObs);
            this.Controls.Add(this.lblSERVAduaneiro);
            this.Controls.Add(this.txtCotValorAduaneiro);
            this.Controls.Add(this.lvlSERCIF);
            this.Controls.Add(this.txtCotValorCIF);
            this.Controls.Add(this.lblSERNumVolumes);
            this.Controls.Add(this.TxtCotNumVolumes);
            this.Controls.Add(this.BtnCotImprimir);
            this.Controls.Add(this.dgvItemsServicosCOT);
            this.Controls.Add(this.DtpCotData);
            this.Controls.Add(this.lblSERData);
            this.Controls.Add(this.lblSERCliente);
            this.Controls.Add(this.cbCotCliente);
            this.Controls.Add(this.lblSEROperacao);
            this.Controls.Add(this.cbCotOperacao);
            this.Controls.Add(this.lblSERCambio);
            this.Controls.Add(this.txtCotCambio);
            this.Controls.Add(this.lblSERTipoServ);
            this.Controls.Add(this.cbCotTServico);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCotacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação";
            this.Load += new System.EventHandler(this.FrmCotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsServicosCOT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbCotNumOperacao;
        public System.Windows.Forms.ComboBox CbCotTransporte;
        private System.Windows.Forms.Label lblSERTipoMercadoria;
        public System.Windows.Forms.TextBox TxtCotTipoMercadoria;
        public System.Windows.Forms.TextBox TxtCotNomeCliente;
        private System.Windows.Forms.Button BtnCotAnular;
        private System.Windows.Forms.Button BtnCotLimpaForm;
        private System.Windows.Forms.Label lblSERRUP;
        public System.Windows.Forms.TextBox TxtCotRUP;
        private System.Windows.Forms.Label lblSERDUP;
        public System.Windows.Forms.TextBox TxtCotDUP;
        private System.Windows.Forms.Label lblSERCNCA;
        public System.Windows.Forms.TextBox TxtCotCNCA;
        public System.Windows.Forms.ComboBox CbCotMoeda;
        private System.Windows.Forms.Label lblSERMoeda;
        private System.Windows.Forms.Label lblSERPeso;
        public System.Windows.Forms.TextBox TxtPesoKGs;
        private System.Windows.Forms.Label lblSERReferencia;
        public System.Windows.Forms.TextBox txtCotVReferencia;
        private System.Windows.Forms.Label lblSERPorteBL;
        public System.Windows.Forms.TextBox txtCotPorteBL;
        private System.Windows.Forms.Label lblSERNumDU;
        public System.Windows.Forms.TextBox TxtCotDU;
        public System.Windows.Forms.DateTimePicker DtpCotDataDu;
        public System.Windows.Forms.DateTimePicker DtpCotDataSaida;
        public System.Windows.Forms.DateTimePicker DtpCotDataEntrada;
        public System.Windows.Forms.DateTimePicker dtpCotDataChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label lblDataDU;
        private System.Windows.Forms.Label lblSERNumDAR;
        public System.Windows.Forms.TextBox txtCotDar;
        private System.Windows.Forms.Label lblSERManifesto;
        public System.Windows.Forms.TextBox TxtCotManifesto;
        private System.Windows.Forms.Label lblAviaoNavio;
        private System.Windows.Forms.Label lblSERVDar;
        public System.Windows.Forms.TextBox TxtCotValorDar;
        private System.Windows.Forms.Label lblVNDObs;
        public System.Windows.Forms.TextBox TxtCotObs;
        private System.Windows.Forms.Label lblSERVAduaneiro;
        public System.Windows.Forms.TextBox txtCotValorAduaneiro;
        private System.Windows.Forms.Label lvlSERCIF;
        public System.Windows.Forms.TextBox txtCotValorCIF;
        private System.Windows.Forms.Label lblSERNumVolumes;
        public System.Windows.Forms.TextBox TxtCotNumVolumes;
        private System.Windows.Forms.Button BtnCotImprimir;
        public System.Windows.Forms.DataGridView dgvItemsServicosCOT;
        public System.Windows.Forms.DateTimePicker DtpCotData;
        private System.Windows.Forms.Label lblSERData;
        private System.Windows.Forms.Label lblSERCliente;
        public System.Windows.Forms.ComboBox cbCotCliente;
        private System.Windows.Forms.Label lblSEROperacao;
        public System.Windows.Forms.ComboBox cbCotOperacao;
        private System.Windows.Forms.Label lblSERCambio;
        public System.Windows.Forms.TextBox txtCotCambio;
        private System.Windows.Forms.Label lblSERTipoServ;
        public System.Windows.Forms.ComboBox cbCotTServico;
        public System.Windows.Forms.TextBox txtCotTimer;
        public System.Windows.Forms.ComboBox CbCotAno;
    }
}