namespace TRTv10.User_Interface
{
    partial class FrmServicos
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSERTipoServ = new System.Windows.Forms.Label();
            this.cbSERCod = new System.Windows.Forms.ComboBox();
            this.lblSERCambio = new System.Windows.Forms.Label();
            this.txtSERCambio = new System.Windows.Forms.TextBox();
            this.lblSEROperacao = new System.Windows.Forms.Label();
            this.cbSEROperacao = new System.Windows.Forms.ComboBox();
            this.cbSERNumSimulacao = new System.Windows.Forms.ComboBox();
            this.lblSERCliente = new System.Windows.Forms.Label();
            this.cbSEREntidade = new System.Windows.Forms.ComboBox();
            this.lblSERData = new System.Windows.Forms.Label();
            this.dtpSERData = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewSER = new System.Windows.Forms.DataGridView();
            this.txtItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValoresSimulacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIVASimulacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntSERImprimir = new System.Windows.Forms.Button();
            this.lblSERNumVolumes = new System.Windows.Forms.Label();
            this.txtSERNumVolumes = new System.Windows.Forms.TextBox();
            this.lvlSERCIF = new System.Windows.Forms.Label();
            this.txtSERVCIF = new System.Windows.Forms.TextBox();
            this.lblSERVAduaneiro = new System.Windows.Forms.Label();
            this.txtSERVAduaneiro = new System.Windows.Forms.TextBox();
            this.lblVNDObs = new System.Windows.Forms.Label();
            this.txtSERObs = new System.Windows.Forms.TextBox();
            this.lblSERNumDAR = new System.Windows.Forms.Label();
            this.txtSERNumDAR = new System.Windows.Forms.TextBox();
            this.lblSERManifesto = new System.Windows.Forms.Label();
            this.txtSERManifesto = new System.Windows.Forms.TextBox();
            this.lblAviaoNavio = new System.Windows.Forms.Label();
            this.lblSERVDar = new System.Windows.Forms.Label();
            this.txtSERValorDAR = new System.Windows.Forms.TextBox();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblDataDU = new System.Windows.Forms.Label();
            this.dtpSERDataChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpSERDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSERDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpSERDataDU = new System.Windows.Forms.DateTimePicker();
            this.lblSERNumDU = new System.Windows.Forms.Label();
            this.txtSERDU = new System.Windows.Forms.TextBox();
            this.lblSERPorteBL = new System.Windows.Forms.Label();
            this.txtSERBLCartaPorte = new System.Windows.Forms.TextBox();
            this.lblSERReferencia = new System.Windows.Forms.Label();
            this.txtSERReferencia = new System.Windows.Forms.TextBox();
            this.lblSERPeso = new System.Windows.Forms.Label();
            this.txtSERPeso = new System.Windows.Forms.TextBox();
            this.lblSERMoeda = new System.Windows.Forms.Label();
            this.cbSERMoeda = new System.Windows.Forms.ComboBox();
            this.lblSERCNCA = new System.Windows.Forms.Label();
            this.txtSERCNCA = new System.Windows.Forms.TextBox();
            this.lblSERDUP = new System.Windows.Forms.Label();
            this.txtSERDUP = new System.Windows.Forms.TextBox();
            this.lblSERRUP = new System.Windows.Forms.Label();
            this.txtSERRUP = new System.Windows.Forms.TextBox();
            this.btnSERLimpar = new System.Windows.Forms.Button();
            this.BtnSERAnula = new System.Windows.Forms.Button();
            this.txtSERNomeCliente = new System.Windows.Forms.TextBox();
            this.txtSERRequisicao = new System.Windows.Forms.TextBox();
            this.txtSERValidaData = new System.Windows.Forms.TextBox();
            this.txtSERTipoMercadoria = new System.Windows.Forms.TextBox();
            this.lblSERTipoMercadoria = new System.Windows.Forms.Label();
            this.txtSERProcesso = new System.Windows.Forms.TextBox();
            this.cbSERAviaoNavio = new System.Windows.Forms.ComboBox();
            this.chkSERCotacao = new System.Windows.Forms.CheckBox();
            this.chkSERRequisicao = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSER)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSERTipoServ
            // 
            this.lblSERTipoServ.AutoSize = true;
            this.lblSERTipoServ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERTipoServ.Location = new System.Drawing.Point(27, 82);
            this.lblSERTipoServ.Name = "lblSERTipoServ";
            this.lblSERTipoServ.Size = new System.Drawing.Size(99, 17);
            this.lblSERTipoServ.TabIndex = 25;
            this.lblSERTipoServ.Text = "Tipo de Serviço";
            // 
            // cbSERCod
            // 
            this.cbSERCod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERCod.FormattingEnabled = true;
            this.cbSERCod.Location = new System.Drawing.Point(166, 79);
            this.cbSERCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSERCod.Name = "cbSERCod";
            this.cbSERCod.Size = new System.Drawing.Size(488, 25);
            this.cbSERCod.TabIndex = 24;
            this.cbSERCod.SelectedIndexChanged += new System.EventHandler(this.CbSERCod_SelectedIndexChanged);
            // 
            // lblSERCambio
            // 
            this.lblSERCambio.AutoSize = true;
            this.lblSERCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCambio.Location = new System.Drawing.Point(27, 313);
            this.lblSERCambio.Name = "lblSERCambio";
            this.lblSERCambio.Size = new System.Drawing.Size(53, 17);
            this.lblSERCambio.TabIndex = 29;
            this.lblSERCambio.Text = "Câmbio";
            // 
            // txtSERCambio
            // 
            this.txtSERCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERCambio.Location = new System.Drawing.Point(166, 309);
            this.txtSERCambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERCambio.Name = "txtSERCambio";
            this.txtSERCambio.Size = new System.Drawing.Size(166, 25);
            this.txtSERCambio.TabIndex = 28;
            // 
            // lblSEROperacao
            // 
            this.lblSEROperacao.AutoSize = true;
            this.lblSEROperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEROperacao.Location = new System.Drawing.Point(28, 115);
            this.lblSEROperacao.Name = "lblSEROperacao";
            this.lblSEROperacao.Size = new System.Drawing.Size(66, 17);
            this.lblSEROperacao.TabIndex = 31;
            this.lblSEROperacao.Text = "Operação";
            // 
            // cbSEROperacao
            // 
            this.cbSEROperacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSEROperacao.FormattingEnabled = true;
            this.cbSEROperacao.Location = new System.Drawing.Point(166, 112);
            this.cbSEROperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSEROperacao.Name = "cbSEROperacao";
            this.cbSEROperacao.Size = new System.Drawing.Size(488, 25);
            this.cbSEROperacao.TabIndex = 30;
            this.cbSEROperacao.SelectedIndexChanged += new System.EventHandler(this.CbSEROperacao_SelectedIndexChanged);
            // 
            // cbSERNumSimulacao
            // 
            this.cbSERNumSimulacao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERNumSimulacao.FormattingEnabled = true;
            this.cbSERNumSimulacao.Location = new System.Drawing.Point(1173, 19);
            this.cbSERNumSimulacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSERNumSimulacao.Name = "cbSERNumSimulacao";
            this.cbSERNumSimulacao.Size = new System.Drawing.Size(137, 38);
            this.cbSERNumSimulacao.TabIndex = 32;
            this.cbSERNumSimulacao.SelectedIndexChanged += new System.EventHandler(this.CbSERNumSimulacao_SelectedIndexChanged);
            // 
            // lblSERCliente
            // 
            this.lblSERCliente.AutoSize = true;
            this.lblSERCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCliente.Location = new System.Drawing.Point(28, 151);
            this.lblSERCliente.Name = "lblSERCliente";
            this.lblSERCliente.Size = new System.Drawing.Size(47, 17);
            this.lblSERCliente.TabIndex = 34;
            this.lblSERCliente.Text = "Cliente";
            // 
            // cbSEREntidade
            // 
            this.cbSEREntidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSEREntidade.FormattingEnabled = true;
            this.cbSEREntidade.Location = new System.Drawing.Point(166, 148);
            this.cbSEREntidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSEREntidade.Name = "cbSEREntidade";
            this.cbSEREntidade.Size = new System.Drawing.Size(488, 25);
            this.cbSEREntidade.TabIndex = 33;
            this.cbSEREntidade.SelectedIndexChanged += new System.EventHandler(this.CbSEREntidade_SelectedIndexChanged);
            // 
            // lblSERData
            // 
            this.lblSERData.AutoSize = true;
            this.lblSERData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERData.Location = new System.Drawing.Point(27, 508);
            this.lblSERData.Name = "lblSERData";
            this.lblSERData.Size = new System.Drawing.Size(35, 17);
            this.lblSERData.TabIndex = 35;
            this.lblSERData.Text = "Data";
            // 
            // dtpSERData
            // 
            this.dtpSERData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSERData.Location = new System.Drawing.Point(166, 502);
            this.dtpSERData.Name = "dtpSERData";
            this.dtpSERData.Size = new System.Drawing.Size(166, 25);
            this.dtpSERData.TabIndex = 36;
            // 
            // dataGridViewSER
            // 
            this.dataGridViewSER.AllowUserToAddRows = false;
            this.dataGridViewSER.AllowUserToDeleteRows = false;
            this.dataGridViewSER.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtItem,
            this.txtValoresSimulacao,
            this.txtIVASimulacao,
            this.txtProcesso,
            this.txtDescricao,
            this.txtData});
            this.dataGridViewSER.Location = new System.Drawing.Point(670, 79);
            this.dataGridViewSER.Name = "dataGridViewSER";
            this.dataGridViewSER.Size = new System.Drawing.Size(645, 544);
            this.dataGridViewSER.TabIndex = 37;
            this.dataGridViewSER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSER_CellContentClick);
            this.dataGridViewSER.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSER_CellValueChanged);
            // 
            // txtItem
            // 
            this.txtItem.DataPropertyName = "CDU_Items";
            this.txtItem.HeaderText = "ItemServ";
            this.txtItem.Name = "txtItem";
            // 
            // txtValoresSimulacao
            // 
            this.txtValoresSimulacao.DataPropertyName = "CDU_ValoresSimulacao";
            this.txtValoresSimulacao.HeaderText = "Valores Simulacao";
            this.txtValoresSimulacao.Name = "txtValoresSimulacao";
            // 
            // txtIVASimulacao
            // 
            this.txtIVASimulacao.DataPropertyName = "CDU_IVASimulacao";
            this.txtIVASimulacao.HeaderText = "Valores IVA Sim.";
            this.txtIVASimulacao.Name = "txtIVASimulacao";
            // 
            // txtProcesso
            // 
            this.txtProcesso.DataPropertyName = "CDU_Processo";
            this.txtProcesso.HeaderText = "Processo";
            this.txtProcesso.Name = "txtProcesso";
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataPropertyName = "CDU_Descricao";
            this.txtDescricao.HeaderText = "Doc / Dados / Descricao";
            this.txtDescricao.Name = "txtDescricao";
            // 
            // txtData
            // 
            this.txtData.DataPropertyName = "CDU_Data";
            this.txtData.HeaderText = "Data";
            this.txtData.Name = "txtData";
            // 
            // bntSERImprimir
            // 
            this.bntSERImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntSERImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSERImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSERImprimir.ForeColor = System.Drawing.Color.White;
            this.bntSERImprimir.Location = new System.Drawing.Point(30, 22);
            this.bntSERImprimir.Name = "bntSERImprimir";
            this.bntSERImprimir.Size = new System.Drawing.Size(109, 35);
            this.bntSERImprimir.TabIndex = 38;
            this.bntSERImprimir.Text = "Imprimir";
            this.bntSERImprimir.UseVisualStyleBackColor = false;
            this.bntSERImprimir.Click += new System.EventHandler(this.BntSERImprimir_Click);
            // 
            // lblSERNumVolumes
            // 
            this.lblSERNumVolumes.AutoSize = true;
            this.lblSERNumVolumes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumVolumes.Location = new System.Drawing.Point(363, 379);
            this.lblSERNumVolumes.Name = "lblSERNumVolumes";
            this.lblSERNumVolumes.Size = new System.Drawing.Size(80, 17);
            this.lblSERNumVolumes.TabIndex = 42;
            this.lblSERNumVolumes.Text = "N.º Volumes";
            // 
            // txtSERNumVolumes
            // 
            this.txtSERNumVolumes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERNumVolumes.Location = new System.Drawing.Point(503, 376);
            this.txtSERNumVolumes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERNumVolumes.Name = "txtSERNumVolumes";
            this.txtSERNumVolumes.Size = new System.Drawing.Size(151, 25);
            this.txtSERNumVolumes.TabIndex = 41;
            // 
            // lvlSERCIF
            // 
            this.lvlSERCIF.AutoSize = true;
            this.lvlSERCIF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSERCIF.Location = new System.Drawing.Point(27, 247);
            this.lvlSERCIF.Name = "lvlSERCIF";
            this.lvlSERCIF.Size = new System.Drawing.Size(59, 17);
            this.lvlSERCIF.TabIndex = 44;
            this.lvlSERCIF.Text = "Valor CIF";
            // 
            // txtSERVCIF
            // 
            this.txtSERVCIF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERVCIF.Location = new System.Drawing.Point(166, 243);
            this.txtSERVCIF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERVCIF.Name = "txtSERVCIF";
            this.txtSERVCIF.Size = new System.Drawing.Size(166, 25);
            this.txtSERVCIF.TabIndex = 43;
            // 
            // lblSERVAduaneiro
            // 
            this.lblSERVAduaneiro.AutoSize = true;
            this.lblSERVAduaneiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERVAduaneiro.Location = new System.Drawing.Point(27, 279);
            this.lblSERVAduaneiro.Name = "lblSERVAduaneiro";
            this.lblSERVAduaneiro.Size = new System.Drawing.Size(102, 17);
            this.lblSERVAduaneiro.TabIndex = 46;
            this.lblSERVAduaneiro.Text = "Valor Aduaneiro";
            // 
            // txtSERVAduaneiro
            // 
            this.txtSERVAduaneiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERVAduaneiro.Location = new System.Drawing.Point(166, 276);
            this.txtSERVAduaneiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERVAduaneiro.Name = "txtSERVAduaneiro";
            this.txtSERVAduaneiro.Size = new System.Drawing.Size(166, 25);
            this.txtSERVAduaneiro.TabIndex = 45;
            // 
            // lblVNDObs
            // 
            this.lblVNDObs.AutoSize = true;
            this.lblVNDObs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVNDObs.Location = new System.Drawing.Point(27, 601);
            this.lblVNDObs.Name = "lblVNDObs";
            this.lblVNDObs.Size = new System.Drawing.Size(84, 17);
            this.lblVNDObs.TabIndex = 48;
            this.lblVNDObs.Text = "Observações";
            // 
            // txtSERObs
            // 
            this.txtSERObs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERObs.Location = new System.Drawing.Point(166, 598);
            this.txtSERObs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERObs.Multiline = true;
            this.txtSERObs.Name = "txtSERObs";
            this.txtSERObs.Size = new System.Drawing.Size(488, 25);
            this.txtSERObs.TabIndex = 47;
            // 
            // lblSERNumDAR
            // 
            this.lblSERNumDAR.AutoSize = true;
            this.lblSERNumDAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumDAR.Location = new System.Drawing.Point(363, 280);
            this.lblSERNumDAR.Name = "lblSERNumDAR";
            this.lblSERNumDAR.Size = new System.Drawing.Size(56, 17);
            this.lblSERNumDAR.TabIndex = 56;
            this.lblSERNumDAR.Text = "DAR N.º";
            // 
            // txtSERNumDAR
            // 
            this.txtSERNumDAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERNumDAR.Location = new System.Drawing.Point(503, 277);
            this.txtSERNumDAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERNumDAR.Name = "txtSERNumDAR";
            this.txtSERNumDAR.Size = new System.Drawing.Size(151, 25);
            this.txtSERNumDAR.TabIndex = 55;
            // 
            // lblSERManifesto
            // 
            this.lblSERManifesto.AutoSize = true;
            this.lblSERManifesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERManifesto.Location = new System.Drawing.Point(363, 247);
            this.lblSERManifesto.Name = "lblSERManifesto";
            this.lblSERManifesto.Size = new System.Drawing.Size(66, 17);
            this.lblSERManifesto.TabIndex = 54;
            this.lblSERManifesto.Text = "Manifesto";
            // 
            // txtSERManifesto
            // 
            this.txtSERManifesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERManifesto.Location = new System.Drawing.Point(503, 244);
            this.txtSERManifesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERManifesto.Name = "txtSERManifesto";
            this.txtSERManifesto.Size = new System.Drawing.Size(151, 25);
            this.txtSERManifesto.TabIndex = 53;
            // 
            // lblAviaoNavio
            // 
            this.lblAviaoNavio.AutoSize = true;
            this.lblAviaoNavio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviaoNavio.Location = new System.Drawing.Point(363, 214);
            this.lblAviaoNavio.Name = "lblAviaoNavio";
            this.lblAviaoNavio.Size = new System.Drawing.Size(135, 17);
            this.lblAviaoNavio.TabIndex = 52;
            this.lblAviaoNavio.Text = "Avião/Navio/Ref Tran.";
            // 
            // lblSERVDar
            // 
            this.lblSERVDar.AutoSize = true;
            this.lblSERVDar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERVDar.Location = new System.Drawing.Point(363, 313);
            this.lblSERVDar.Name = "lblSERVDar";
            this.lblSERVDar.Size = new System.Drawing.Size(67, 17);
            this.lblSERVDar.TabIndex = 50;
            this.lblSERVDar.Text = "Valor DAR";
            // 
            // txtSERValorDAR
            // 
            this.txtSERValorDAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERValorDAR.Location = new System.Drawing.Point(503, 310);
            this.txtSERValorDAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERValorDAR.Name = "txtSERValorDAR";
            this.txtSERValorDAR.Size = new System.Drawing.Size(151, 25);
            this.txtSERValorDAR.TabIndex = 49;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(363, 445);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(90, 17);
            this.lblDataSaida.TabIndex = 64;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(363, 414);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(103, 17);
            this.lblDataEntrada.TabIndex = 62;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataChegada.Location = new System.Drawing.Point(28, 539);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(91, 17);
            this.lblDataChegada.TabIndex = 60;
            this.lblDataChegada.Text = "Data Chegada";
            // 
            // lblDataDU
            // 
            this.lblDataDU.AutoSize = true;
            this.lblDataDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDU.Location = new System.Drawing.Point(363, 475);
            this.lblDataDU.Name = "lblDataDU";
            this.lblDataDU.Size = new System.Drawing.Size(57, 17);
            this.lblDataDU.TabIndex = 58;
            this.lblDataDU.Text = "Data DU";
            // 
            // dtpSERDataChegada
            // 
            this.dtpSERDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSERDataChegada.Location = new System.Drawing.Point(166, 533);
            this.dtpSERDataChegada.Name = "dtpSERDataChegada";
            this.dtpSERDataChegada.Size = new System.Drawing.Size(166, 25);
            this.dtpSERDataChegada.TabIndex = 65;
            // 
            // dtpSERDataEntrada
            // 
            this.dtpSERDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSERDataEntrada.Location = new System.Drawing.Point(503, 408);
            this.dtpSERDataEntrada.Name = "dtpSERDataEntrada";
            this.dtpSERDataEntrada.Size = new System.Drawing.Size(151, 25);
            this.dtpSERDataEntrada.TabIndex = 66;
            // 
            // dtpSERDataSaida
            // 
            this.dtpSERDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSERDataSaida.Location = new System.Drawing.Point(503, 439);
            this.dtpSERDataSaida.Name = "dtpSERDataSaida";
            this.dtpSERDataSaida.Size = new System.Drawing.Size(151, 25);
            this.dtpSERDataSaida.TabIndex = 67;
            // 
            // dtpSERDataDU
            // 
            this.dtpSERDataDU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSERDataDU.Location = new System.Drawing.Point(503, 470);
            this.dtpSERDataDU.Name = "dtpSERDataDU";
            this.dtpSERDataDU.Size = new System.Drawing.Size(151, 25);
            this.dtpSERDataDU.TabIndex = 68;
            // 
            // lblSERNumDU
            // 
            this.lblSERNumDU.AutoSize = true;
            this.lblSERNumDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumDU.Location = new System.Drawing.Point(363, 346);
            this.lblSERNumDU.Name = "lblSERNumDU";
            this.lblSERNumDU.Size = new System.Drawing.Size(49, 17);
            this.lblSERNumDU.TabIndex = 70;
            this.lblSERNumDU.Text = "N.º DU";
            // 
            // txtSERDU
            // 
            this.txtSERDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERDU.Location = new System.Drawing.Point(503, 343);
            this.txtSERDU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERDU.Name = "txtSERDU";
            this.txtSERDU.Size = new System.Drawing.Size(151, 25);
            this.txtSERDU.TabIndex = 69;
            // 
            // lblSERPorteBL
            // 
            this.lblSERPorteBL.AutoSize = true;
            this.lblSERPorteBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERPorteBL.Location = new System.Drawing.Point(27, 411);
            this.lblSERPorteBL.Name = "lblSERPorteBL";
            this.lblSERPorteBL.Size = new System.Drawing.Size(119, 17);
            this.lblSERPorteBL.TabIndex = 72;
            this.lblSERPorteBL.Text = "Carta de Porte / BL";
            // 
            // txtSERBLCartaPorte
            // 
            this.txtSERBLCartaPorte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERBLCartaPorte.Location = new System.Drawing.Point(166, 408);
            this.txtSERBLCartaPorte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERBLCartaPorte.Name = "txtSERBLCartaPorte";
            this.txtSERBLCartaPorte.Size = new System.Drawing.Size(166, 25);
            this.txtSERBLCartaPorte.TabIndex = 71;
            // 
            // lblSERReferencia
            // 
            this.lblSERReferencia.AutoSize = true;
            this.lblSERReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERReferencia.Location = new System.Drawing.Point(28, 473);
            this.lblSERReferencia.Name = "lblSERReferencia";
            this.lblSERReferencia.Size = new System.Drawing.Size(86, 17);
            this.lblSERReferencia.TabIndex = 74;
            this.lblSERReferencia.Text = "V/ Referência";
            // 
            // txtSERReferencia
            // 
            this.txtSERReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERReferencia.Location = new System.Drawing.Point(166, 470);
            this.txtSERReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERReferencia.Name = "txtSERReferencia";
            this.txtSERReferencia.Size = new System.Drawing.Size(166, 25);
            this.txtSERReferencia.TabIndex = 73;
            // 
            // lblSERPeso
            // 
            this.lblSERPeso.AutoSize = true;
            this.lblSERPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERPeso.Location = new System.Drawing.Point(363, 505);
            this.lblSERPeso.Name = "lblSERPeso";
            this.lblSERPeso.Size = new System.Drawing.Size(84, 17);
            this.lblSERPeso.TabIndex = 76;
            this.lblSERPeso.Text = "Peso em KGs";
            // 
            // txtSERPeso
            // 
            this.txtSERPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERPeso.Location = new System.Drawing.Point(503, 502);
            this.txtSERPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERPeso.Name = "txtSERPeso";
            this.txtSERPeso.Size = new System.Drawing.Size(151, 25);
            this.txtSERPeso.TabIndex = 75;
            // 
            // lblSERMoeda
            // 
            this.lblSERMoeda.AutoSize = true;
            this.lblSERMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERMoeda.Location = new System.Drawing.Point(27, 214);
            this.lblSERMoeda.Name = "lblSERMoeda";
            this.lblSERMoeda.Size = new System.Drawing.Size(98, 17);
            this.lblSERMoeda.TabIndex = 77;
            this.lblSERMoeda.Text = "Moeda Origem";
            // 
            // cbSERMoeda
            // 
            this.cbSERMoeda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERMoeda.FormattingEnabled = true;
            this.cbSERMoeda.Location = new System.Drawing.Point(166, 211);
            this.cbSERMoeda.Name = "cbSERMoeda";
            this.cbSERMoeda.Size = new System.Drawing.Size(166, 25);
            this.cbSERMoeda.TabIndex = 78;
            // 
            // lblSERCNCA
            // 
            this.lblSERCNCA.AutoSize = true;
            this.lblSERCNCA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCNCA.Location = new System.Drawing.Point(27, 345);
            this.lblSERCNCA.Name = "lblSERCNCA";
            this.lblSERCNCA.Size = new System.Drawing.Size(42, 17);
            this.lblSERCNCA.TabIndex = 80;
            this.lblSERCNCA.Text = "CNCA";
            // 
            // txtSERCNCA
            // 
            this.txtSERCNCA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERCNCA.Location = new System.Drawing.Point(166, 342);
            this.txtSERCNCA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERCNCA.Name = "txtSERCNCA";
            this.txtSERCNCA.Size = new System.Drawing.Size(166, 25);
            this.txtSERCNCA.TabIndex = 79;
            // 
            // lblSERDUP
            // 
            this.lblSERDUP.AutoSize = true;
            this.lblSERDUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERDUP.Location = new System.Drawing.Point(27, 379);
            this.lblSERDUP.Name = "lblSERDUP";
            this.lblSERDUP.Size = new System.Drawing.Size(33, 17);
            this.lblSERDUP.TabIndex = 82;
            this.lblSERDUP.Text = "DUP";
            // 
            // txtSERDUP
            // 
            this.txtSERDUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERDUP.Location = new System.Drawing.Point(166, 375);
            this.txtSERDUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERDUP.Name = "txtSERDUP";
            this.txtSERDUP.Size = new System.Drawing.Size(166, 25);
            this.txtSERDUP.TabIndex = 81;
            // 
            // lblSERRUP
            // 
            this.lblSERRUP.AutoSize = true;
            this.lblSERRUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERRUP.Location = new System.Drawing.Point(27, 442);
            this.lblSERRUP.Name = "lblSERRUP";
            this.lblSERRUP.Size = new System.Drawing.Size(32, 17);
            this.lblSERRUP.TabIndex = 84;
            this.lblSERRUP.Text = "RUP";
            // 
            // txtSERRUP
            // 
            this.txtSERRUP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERRUP.Location = new System.Drawing.Point(166, 439);
            this.txtSERRUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERRUP.Name = "txtSERRUP";
            this.txtSERRUP.Size = new System.Drawing.Size(166, 25);
            this.txtSERRUP.TabIndex = 83;
            // 
            // btnSERLimpar
            // 
            this.btnSERLimpar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSERLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSERLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSERLimpar.ForeColor = System.Drawing.Color.White;
            this.btnSERLimpar.Location = new System.Drawing.Point(151, 22);
            this.btnSERLimpar.Name = "btnSERLimpar";
            this.btnSERLimpar.Size = new System.Drawing.Size(109, 35);
            this.btnSERLimpar.TabIndex = 85;
            this.btnSERLimpar.Text = "Limpar Dados";
            this.btnSERLimpar.UseVisualStyleBackColor = false;
            this.btnSERLimpar.Click += new System.EventHandler(this.BtnSERLimpar_Click);
            // 
            // BtnSERAnula
            // 
            this.BtnSERAnula.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSERAnula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSERAnula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSERAnula.ForeColor = System.Drawing.Color.White;
            this.BtnSERAnula.Location = new System.Drawing.Point(1058, 22);
            this.BtnSERAnula.Name = "BtnSERAnula";
            this.BtnSERAnula.Size = new System.Drawing.Size(109, 35);
            this.BtnSERAnula.TabIndex = 86;
            this.BtnSERAnula.Text = "Anular";
            this.BtnSERAnula.UseVisualStyleBackColor = false;
            this.BtnSERAnula.Click += new System.EventHandler(this.BtnSERAnula_Click);
            // 
            // txtSERNomeCliente
            // 
            this.txtSERNomeCliente.Enabled = false;
            this.txtSERNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERNomeCliente.Location = new System.Drawing.Point(166, 180);
            this.txtSERNomeCliente.Name = "txtSERNomeCliente";
            this.txtSERNomeCliente.Size = new System.Drawing.Size(488, 25);
            this.txtSERNomeCliente.TabIndex = 87;
            // 
            // txtSERRequisicao
            // 
            this.txtSERRequisicao.BackColor = System.Drawing.SystemColors.Control;
            this.txtSERRequisicao.Enabled = false;
            this.txtSERRequisicao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERRequisicao.Location = new System.Drawing.Point(272, 22);
            this.txtSERRequisicao.Name = "txtSERRequisicao";
            this.txtSERRequisicao.Size = new System.Drawing.Size(149, 33);
            this.txtSERRequisicao.TabIndex = 88;
            this.txtSERRequisicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSERRequisicao.Visible = false;
            // 
            // txtSERValidaData
            // 
            this.txtSERValidaData.BackColor = System.Drawing.SystemColors.Control;
            this.txtSERValidaData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERValidaData.Location = new System.Drawing.Point(485, 22);
            this.txtSERValidaData.Name = "txtSERValidaData";
            this.txtSERValidaData.Size = new System.Drawing.Size(120, 33);
            this.txtSERValidaData.TabIndex = 89;
            this.txtSERValidaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSERValidaData.Visible = false;
            // 
            // txtSERTipoMercadoria
            // 
            this.txtSERTipoMercadoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERTipoMercadoria.Location = new System.Drawing.Point(166, 565);
            this.txtSERTipoMercadoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERTipoMercadoria.Name = "txtSERTipoMercadoria";
            this.txtSERTipoMercadoria.Size = new System.Drawing.Size(488, 25);
            this.txtSERTipoMercadoria.TabIndex = 90;
            // 
            // lblSERTipoMercadoria
            // 
            this.lblSERTipoMercadoria.AutoSize = true;
            this.lblSERTipoMercadoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERTipoMercadoria.Location = new System.Drawing.Point(27, 568);
            this.lblSERTipoMercadoria.Name = "lblSERTipoMercadoria";
            this.lblSERTipoMercadoria.Size = new System.Drawing.Size(125, 17);
            this.lblSERTipoMercadoria.TabIndex = 91;
            this.lblSERTipoMercadoria.Text = "Tipo de Mercadoria";
            // 
            // txtSERProcesso
            // 
            this.txtSERProcesso.BackColor = System.Drawing.SystemColors.Control;
            this.txtSERProcesso.Enabled = false;
            this.txtSERProcesso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERProcesso.Location = new System.Drawing.Point(427, 22);
            this.txtSERProcesso.Name = "txtSERProcesso";
            this.txtSERProcesso.Size = new System.Drawing.Size(52, 33);
            this.txtSERProcesso.TabIndex = 92;
            this.txtSERProcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSERProcesso.Visible = false;
            // 
            // cbSERAviaoNavio
            // 
            this.cbSERAviaoNavio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERAviaoNavio.FormattingEnabled = true;
            this.cbSERAviaoNavio.Location = new System.Drawing.Point(503, 212);
            this.cbSERAviaoNavio.Name = "cbSERAviaoNavio";
            this.cbSERAviaoNavio.Size = new System.Drawing.Size(151, 25);
            this.cbSERAviaoNavio.TabIndex = 93;
            // 
            // chkSERCotacao
            // 
            this.chkSERCotacao.AutoSize = true;
            this.chkSERCotacao.Location = new System.Drawing.Point(806, 30);
            this.chkSERCotacao.Name = "chkSERCotacao";
            this.chkSERCotacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSERCotacao.Size = new System.Drawing.Size(81, 21);
            this.chkSERCotacao.TabIndex = 94;
            this.chkSERCotacao.Text = "Cotações";
            this.chkSERCotacao.UseVisualStyleBackColor = true;
            this.chkSERCotacao.CheckedChanged += new System.EventHandler(this.chkSERCotacao_CheckedChanged);
            // 
            // chkSERRequisicao
            // 
            this.chkSERRequisicao.AutoSize = true;
            this.chkSERRequisicao.Location = new System.Drawing.Point(919, 30);
            this.chkSERRequisicao.Name = "chkSERRequisicao";
            this.chkSERRequisicao.Size = new System.Drawing.Size(96, 21);
            this.chkSERRequisicao.TabIndex = 95;
            this.chkSERRequisicao.Text = "Requisições";
            this.chkSERRequisicao.UseVisualStyleBackColor = true;
            this.chkSERRequisicao.CheckedChanged += new System.EventHandler(this.chkSERRequisicao_CheckedChanged);
            // 
            // FrmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1339, 653);
            this.Controls.Add(this.chkSERRequisicao);
            this.Controls.Add(this.chkSERCotacao);
            this.Controls.Add(this.cbSERAviaoNavio);
            this.Controls.Add(this.txtSERProcesso);
            this.Controls.Add(this.lblSERTipoMercadoria);
            this.Controls.Add(this.txtSERTipoMercadoria);
            this.Controls.Add(this.txtSERValidaData);
            this.Controls.Add(this.txtSERRequisicao);
            this.Controls.Add(this.txtSERNomeCliente);
            this.Controls.Add(this.BtnSERAnula);
            this.Controls.Add(this.btnSERLimpar);
            this.Controls.Add(this.lblSERRUP);
            this.Controls.Add(this.txtSERRUP);
            this.Controls.Add(this.lblSERDUP);
            this.Controls.Add(this.txtSERDUP);
            this.Controls.Add(this.lblSERCNCA);
            this.Controls.Add(this.txtSERCNCA);
            this.Controls.Add(this.cbSERMoeda);
            this.Controls.Add(this.lblSERMoeda);
            this.Controls.Add(this.lblSERPeso);
            this.Controls.Add(this.txtSERPeso);
            this.Controls.Add(this.lblSERReferencia);
            this.Controls.Add(this.txtSERReferencia);
            this.Controls.Add(this.lblSERPorteBL);
            this.Controls.Add(this.txtSERBLCartaPorte);
            this.Controls.Add(this.lblSERNumDU);
            this.Controls.Add(this.txtSERDU);
            this.Controls.Add(this.dtpSERDataDU);
            this.Controls.Add(this.dtpSERDataSaida);
            this.Controls.Add(this.dtpSERDataEntrada);
            this.Controls.Add(this.dtpSERDataChegada);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblDataChegada);
            this.Controls.Add(this.lblDataDU);
            this.Controls.Add(this.lblSERNumDAR);
            this.Controls.Add(this.txtSERNumDAR);
            this.Controls.Add(this.lblSERManifesto);
            this.Controls.Add(this.txtSERManifesto);
            this.Controls.Add(this.lblAviaoNavio);
            this.Controls.Add(this.lblSERVDar);
            this.Controls.Add(this.txtSERValorDAR);
            this.Controls.Add(this.lblVNDObs);
            this.Controls.Add(this.txtSERObs);
            this.Controls.Add(this.lblSERVAduaneiro);
            this.Controls.Add(this.txtSERVAduaneiro);
            this.Controls.Add(this.lvlSERCIF);
            this.Controls.Add(this.txtSERVCIF);
            this.Controls.Add(this.lblSERNumVolumes);
            this.Controls.Add(this.txtSERNumVolumes);
            this.Controls.Add(this.bntSERImprimir);
            this.Controls.Add(this.dataGridViewSER);
            this.Controls.Add(this.dtpSERData);
            this.Controls.Add(this.lblSERData);
            this.Controls.Add(this.lblSERCliente);
            this.Controls.Add(this.cbSEREntidade);
            this.Controls.Add(this.cbSERNumSimulacao);
            this.Controls.Add(this.lblSEROperacao);
            this.Controls.Add(this.cbSEROperacao);
            this.Controls.Add(this.lblSERCambio);
            this.Controls.Add(this.txtSERCambio);
            this.Controls.Add(this.lblSERTipoServ);
            this.Controls.Add(this.cbSERCod);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmServicos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.FrmServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button bntSERImprimir;
        private System.Windows.Forms.Button BtnSERAnula;
        private System.Windows.Forms.Button btnSERLimpar;
        private System.Windows.Forms.ComboBox cbSERCod;
        private System.Windows.Forms.ComboBox cbSEREntidade;
        private System.Windows.Forms.ComboBox cbSERMoeda;
        public System.Windows.Forms.ComboBox cbSERNumSimulacao;
        private System.Windows.Forms.ComboBox cbSEROperacao;
        public System.Windows.Forms.DataGridView dataGridViewSER;
        private System.Windows.Forms.DateTimePicker dtpSERData;
        private System.Windows.Forms.DateTimePicker dtpSERDataChegada;
        private System.Windows.Forms.DateTimePicker dtpSERDataDU;
        private System.Windows.Forms.DateTimePicker dtpSERDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpSERDataSaida;
        private System.Windows.Forms.Label lblAviaoNavio;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label lblDataDU;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblSERCambio;
        private System.Windows.Forms.Label lblSERCliente;
        private System.Windows.Forms.Label lblSERCNCA;
        private System.Windows.Forms.Label lblSERData;
        private System.Windows.Forms.Label lblSERDUP;
        private System.Windows.Forms.Label lblSERManifesto;
        private System.Windows.Forms.Label lblSERMoeda;
        private System.Windows.Forms.Label lblSERNumDAR;
        private System.Windows.Forms.Label lblSERNumDU;
        private System.Windows.Forms.Label lblSERNumVolumes;
        private System.Windows.Forms.Label lblSEROperacao;
        private System.Windows.Forms.Label lblSERPeso;
        private System.Windows.Forms.Label lblSERPorteBL;
        private System.Windows.Forms.Label lblSERReferencia;
        private System.Windows.Forms.Label lblSERRUP;
        private System.Windows.Forms.Label lblSERTipoMercadoria;
        private System.Windows.Forms.Label lblSERTipoServ;
        private System.Windows.Forms.Label lblSERVAduaneiro;
        private System.Windows.Forms.Label lblSERVDar;
        private System.Windows.Forms.Label lblVNDObs;
        private System.Windows.Forms.Label lvlSERCIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtData;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIVASimulacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProcesso;
        private System.Windows.Forms.TextBox txtSERBLCartaPorte;
        private System.Windows.Forms.TextBox txtSERCambio;
        private System.Windows.Forms.TextBox txtSERCNCA;
        private System.Windows.Forms.TextBox txtSERDU;
        private System.Windows.Forms.TextBox txtSERDUP;
        private System.Windows.Forms.TextBox txtSERManifesto;
        private System.Windows.Forms.TextBox txtSERNomeCliente;
        private System.Windows.Forms.TextBox txtSERNumDAR;
        private System.Windows.Forms.TextBox txtSERNumVolumes;
        private System.Windows.Forms.TextBox txtSERObs;
        private System.Windows.Forms.TextBox txtSERPeso;
        private System.Windows.Forms.TextBox txtSERProcesso;
        private System.Windows.Forms.TextBox txtSERReferencia;
        private System.Windows.Forms.TextBox txtSERRequisicao;
        private System.Windows.Forms.TextBox txtSERRUP;
        private System.Windows.Forms.TextBox txtSERTipoMercadoria;
        private System.Windows.Forms.TextBox txtSERVAduaneiro;
        private System.Windows.Forms.TextBox txtSERValidaData;
        private System.Windows.Forms.TextBox txtSERValorDAR;
        private System.Windows.Forms.TextBox txtSERVCIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValoresSimulacao;

        #endregion

        private System.Windows.Forms.ComboBox cbSERAviaoNavio;
        private System.Windows.Forms.CheckBox chkSERCotacao;
        private System.Windows.Forms.CheckBox chkSERRequisicao;
    }
}