using System.ComponentModel;

namespace TRTv10.User_Interface
{
    partial class FrmDrv
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeaderUtilizador = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTRTProcesso = new System.Windows.Forms.ComboBox();
            this.lblHeaderProcesso = new System.Windows.Forms.Label();
            this.BtnRECCriar = new System.Windows.Forms.Button();
            this.TxtRECNomeCliente = new System.Windows.Forms.TextBox();
            this.TxtRECTotalIva = new System.Windows.Forms.TextBox();
            this.TxtRECTotalSIva = new System.Windows.Forms.TextBox();
            this.dgvLinhasDrv = new System.Windows.Forms.DataGridView();
            this.lblSERTipoServ = new System.Windows.Forms.Label();
            this.CbRECCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbRECProcesso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbRECDocumento = new System.Windows.Forms.ComboBox();
            this.CbRECNumero = new System.Windows.Forms.ComboBox();
            this.CbRECAno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRECTotalRetencao = new System.Windows.Forms.TextBox();
            this.TxtRecTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSERPorteBL = new System.Windows.Forms.Label();
            this.lblAviaoNavio = new System.Windows.Forms.Label();
            this.lblSERNumDAR = new System.Windows.Forms.Label();
            this.lblSERNumDU = new System.Windows.Forms.Label();
            this.TxtRECMoeda = new System.Windows.Forms.TextBox();
            this.TxtRECCambio = new System.Windows.Forms.TextBox();
            this.TxtRECTransporte = new System.Windows.Forms.TextBox();
            this.TxtRECBL = new System.Windows.Forms.TextBox();
            this.TxtRECNDar = new System.Windows.Forms.TextBox();
            this.TxtRECNDu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasDrv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblHeaderUtilizador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 17);
            this.panel1.TabIndex = 44;
            // 
            // lblHeaderUtilizador
            // 
            this.lblHeaderUtilizador.AutoSize = true;
            this.lblHeaderUtilizador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderUtilizador.ForeColor = System.Drawing.Color.White;
            this.lblHeaderUtilizador.Location = new System.Drawing.Point(1326, 34);
            this.lblHeaderUtilizador.Name = "lblHeaderUtilizador";
            this.lblHeaderUtilizador.Size = new System.Drawing.Size(61, 17);
            this.lblHeaderUtilizador.TabIndex = 3;
            this.lblHeaderUtilizador.Text = "Processo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.cbTRTProcesso);
            this.panel3.Controls.Add(this.lblHeaderProcesso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1339, 16);
            this.panel3.TabIndex = 45;
            // 
            // cbTRTProcesso
            // 
            this.cbTRTProcesso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTRTProcesso.FormattingEnabled = true;
            this.cbTRTProcesso.Location = new System.Drawing.Point(945, 22);
            this.cbTRTProcesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTRTProcesso.Name = "cbTRTProcesso";
            this.cbTRTProcesso.Size = new System.Drawing.Size(172, 29);
            this.cbTRTProcesso.TabIndex = 3;
            // 
            // lblHeaderProcesso
            // 
            this.lblHeaderProcesso.AutoSize = true;
            this.lblHeaderProcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderProcesso.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeaderProcesso.Location = new System.Drawing.Point(236, 20);
            this.lblHeaderProcesso.Name = "lblHeaderProcesso";
            this.lblHeaderProcesso.Size = new System.Drawing.Size(0, 17);
            this.lblHeaderProcesso.TabIndex = 2;
            // 
            // BtnRECCriar
            // 
            this.BtnRECCriar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRECCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRECCriar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRECCriar.ForeColor = System.Drawing.Color.White;
            this.BtnRECCriar.Location = new System.Drawing.Point(12, 40);
            this.BtnRECCriar.Name = "BtnRECCriar";
            this.BtnRECCriar.Size = new System.Drawing.Size(109, 35);
            this.BtnRECCriar.TabIndex = 46;
            this.BtnRECCriar.Text = "Criar";
            this.BtnRECCriar.UseVisualStyleBackColor = false;
            this.BtnRECCriar.Click += new System.EventHandler(this.BtnSERFRMREQCria_Click);
            // 
            // TxtRECNomeCliente
            // 
            this.TxtRECNomeCliente.Enabled = false;
            this.TxtRECNomeCliente.Location = new System.Drawing.Point(216, 112);
            this.TxtRECNomeCliente.Name = "TxtRECNomeCliente";
            this.TxtRECNomeCliente.Size = new System.Drawing.Size(401, 25);
            this.TxtRECNomeCliente.TabIndex = 49;
            this.TxtRECNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRECTotalIva
            // 
            this.TxtRECTotalIva.Enabled = false;
            this.TxtRECTotalIva.Location = new System.Drawing.Point(1174, 100);
            this.TxtRECTotalIva.Name = "TxtRECTotalIva";
            this.TxtRECTotalIva.Size = new System.Drawing.Size(147, 25);
            this.TxtRECTotalIva.TabIndex = 50;
            this.TxtRECTotalIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRECTotalSIva
            // 
            this.TxtRECTotalSIva.Enabled = false;
            this.TxtRECTotalSIva.Location = new System.Drawing.Point(1174, 69);
            this.TxtRECTotalSIva.Name = "TxtRECTotalSIva";
            this.TxtRECTotalSIva.Size = new System.Drawing.Size(147, 25);
            this.TxtRECTotalSIva.TabIndex = 52;
            this.TxtRECTotalSIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvLinhasDrv
            // 
            this.dgvLinhasDrv.AllowUserToAddRows = false;
            this.dgvLinhasDrv.AllowUserToDeleteRows = false;
            this.dgvLinhasDrv.BackgroundColor = System.Drawing.Color.White;
            this.dgvLinhasDrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhasDrv.Location = new System.Drawing.Point(652, 203);
            this.dgvLinhasDrv.Name = "dgvLinhasDrv";
            this.dgvLinhasDrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinhasDrv.Size = new System.Drawing.Size(669, 425);
            this.dgvLinhasDrv.TabIndex = 53;
            this.dgvLinhasDrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinhasDrv_CellContentClick);
            // 
            // lblSERTipoServ
            // 
            this.lblSERTipoServ.AutoSize = true;
            this.lblSERTipoServ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERTipoServ.Location = new System.Drawing.Point(9, 115);
            this.lblSERTipoServ.Name = "lblSERTipoServ";
            this.lblSERTipoServ.Size = new System.Drawing.Size(47, 17);
            this.lblSERTipoServ.TabIndex = 119;
            this.lblSERTipoServ.Text = "Cliente";
            // 
            // CbRECCliente
            // 
            this.CbRECCliente.FormattingEnabled = true;
            this.CbRECCliente.Location = new System.Drawing.Point(89, 112);
            this.CbRECCliente.Name = "CbRECCliente";
            this.CbRECCliente.Size = new System.Drawing.Size(121, 25);
            this.CbRECCliente.TabIndex = 120;
            this.CbRECCliente.SelectedIndexChanged += new System.EventHandler(this.CbRECCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Processo";
            // 
            // CbRECProcesso
            // 
            this.CbRECProcesso.FormattingEnabled = true;
            this.CbRECProcesso.Location = new System.Drawing.Point(89, 159);
            this.CbRECProcesso.Name = "CbRECProcesso";
            this.CbRECProcesso.Size = new System.Drawing.Size(121, 25);
            this.CbRECProcesso.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 123;
            this.label2.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 124;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 125;
            this.label4.Text = "Ano";
            // 
            // CbRECDocumento
            // 
            this.CbRECDocumento.FormattingEnabled = true;
            this.CbRECDocumento.Location = new System.Drawing.Point(89, 203);
            this.CbRECDocumento.Name = "CbRECDocumento";
            this.CbRECDocumento.Size = new System.Drawing.Size(528, 25);
            this.CbRECDocumento.TabIndex = 126;
            this.CbRECDocumento.SelectedIndexChanged += new System.EventHandler(this.CbRECDocumento_SelectedIndexChanged);
            // 
            // CbRECNumero
            // 
            this.CbRECNumero.FormattingEnabled = true;
            this.CbRECNumero.Location = new System.Drawing.Point(89, 249);
            this.CbRECNumero.Name = "CbRECNumero";
            this.CbRECNumero.Size = new System.Drawing.Size(121, 25);
            this.CbRECNumero.TabIndex = 127;
            // 
            // CbRECAno
            // 
            this.CbRECAno.FormattingEnabled = true;
            this.CbRECAno.Location = new System.Drawing.Point(297, 249);
            this.CbRECAno.Name = "CbRECAno";
            this.CbRECAno.Size = new System.Drawing.Size(89, 25);
            this.CbRECAno.TabIndex = 128;
            this.CbRECAno.SelectedIndexChanged += new System.EventHandler(this.CbRECAno_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1065, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 129;
            this.label5.Text = "Total s/Iva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1065, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 130;
            this.label6.Text = "Total Retenção";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1065, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 131;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1065, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 132;
            this.label8.Text = "Iva";
            // 
            // TxtRECTotalRetencao
            // 
            this.TxtRECTotalRetencao.Enabled = false;
            this.TxtRECTotalRetencao.Location = new System.Drawing.Point(1174, 132);
            this.TxtRECTotalRetencao.Name = "TxtRECTotalRetencao";
            this.TxtRECTotalRetencao.Size = new System.Drawing.Size(147, 25);
            this.TxtRECTotalRetencao.TabIndex = 133;
            this.TxtRECTotalRetencao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRecTotal
            // 
            this.TxtRecTotal.Enabled = false;
            this.TxtRecTotal.HideSelection = false;
            this.TxtRecTotal.Location = new System.Drawing.Point(1174, 163);
            this.TxtRecTotal.Name = "TxtRecTotal";
            this.TxtRecTotal.Size = new System.Drawing.Size(147, 25);
            this.TxtRecTotal.TabIndex = 134;
            this.TxtRecTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 135;
            this.label9.Text = "Moeda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 136;
            this.label10.Text = "Câmbio";
            // 
            // lblSERPorteBL
            // 
            this.lblSERPorteBL.AutoSize = true;
            this.lblSERPorteBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERPorteBL.Location = new System.Drawing.Point(9, 421);
            this.lblSERPorteBL.Name = "lblSERPorteBL";
            this.lblSERPorteBL.Size = new System.Drawing.Size(72, 17);
            this.lblSERPorteBL.TabIndex = 151;
            this.lblSERPorteBL.Text = "C. Porte/BL";
            // 
            // lblAviaoNavio
            // 
            this.lblAviaoNavio.AutoSize = true;
            this.lblAviaoNavio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviaoNavio.Location = new System.Drawing.Point(9, 378);
            this.lblAviaoNavio.Name = "lblAviaoNavio";
            this.lblAviaoNavio.Size = new System.Drawing.Size(71, 17);
            this.lblAviaoNavio.TabIndex = 152;
            this.lblAviaoNavio.Text = "Transporte";
            // 
            // lblSERNumDAR
            // 
            this.lblSERNumDAR.AutoSize = true;
            this.lblSERNumDAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumDAR.Location = new System.Drawing.Point(9, 464);
            this.lblSERNumDAR.Name = "lblSERNumDAR";
            this.lblSERNumDAR.Size = new System.Drawing.Size(56, 17);
            this.lblSERNumDAR.TabIndex = 153;
            this.lblSERNumDAR.Text = "N.º DAR";
            // 
            // lblSERNumDU
            // 
            this.lblSERNumDU.AutoSize = true;
            this.lblSERNumDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERNumDU.Location = new System.Drawing.Point(9, 509);
            this.lblSERNumDU.Name = "lblSERNumDU";
            this.lblSERNumDU.Size = new System.Drawing.Size(49, 17);
            this.lblSERNumDU.TabIndex = 154;
            this.lblSERNumDU.Text = "N.º DU";
            // 
            // TxtRECMoeda
            // 
            this.TxtRECMoeda.Enabled = false;
            this.TxtRECMoeda.Location = new System.Drawing.Point(89, 287);
            this.TxtRECMoeda.Name = "TxtRECMoeda";
            this.TxtRECMoeda.Size = new System.Drawing.Size(121, 25);
            this.TxtRECMoeda.TabIndex = 155;
            this.TxtRECMoeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRECCambio
            // 
            this.TxtRECCambio.Enabled = false;
            this.TxtRECCambio.Location = new System.Drawing.Point(89, 332);
            this.TxtRECCambio.Name = "TxtRECCambio";
            this.TxtRECCambio.Size = new System.Drawing.Size(121, 25);
            this.TxtRECCambio.TabIndex = 156;
            this.TxtRECCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRECTransporte
            // 
            this.TxtRECTransporte.Enabled = false;
            this.TxtRECTransporte.Location = new System.Drawing.Point(89, 375);
            this.TxtRECTransporte.Name = "TxtRECTransporte";
            this.TxtRECTransporte.Size = new System.Drawing.Size(528, 25);
            this.TxtRECTransporte.TabIndex = 157;
            this.TxtRECTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRECBL
            // 
            this.TxtRECBL.Enabled = false;
            this.TxtRECBL.Location = new System.Drawing.Point(89, 418);
            this.TxtRECBL.Name = "TxtRECBL";
            this.TxtRECBL.Size = new System.Drawing.Size(528, 25);
            this.TxtRECBL.TabIndex = 158;
            this.TxtRECBL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRECNDar
            // 
            this.TxtRECNDar.Enabled = false;
            this.TxtRECNDar.Location = new System.Drawing.Point(89, 461);
            this.TxtRECNDar.Name = "TxtRECNDar";
            this.TxtRECNDar.Size = new System.Drawing.Size(528, 25);
            this.TxtRECNDar.TabIndex = 159;
            this.TxtRECNDar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRECNDu
            // 
            this.TxtRECNDu.Enabled = false;
            this.TxtRECNDu.Location = new System.Drawing.Point(89, 506);
            this.TxtRECNDu.Name = "TxtRECNDu";
            this.TxtRECNDu.Size = new System.Drawing.Size(528, 25);
            this.TxtRECNDu.TabIndex = 160;
            this.TxtRECNDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmDrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 640);
            this.Controls.Add(this.TxtRECNDu);
            this.Controls.Add(this.TxtRECNDar);
            this.Controls.Add(this.TxtRECBL);
            this.Controls.Add(this.TxtRECTransporte);
            this.Controls.Add(this.TxtRECCambio);
            this.Controls.Add(this.TxtRECMoeda);
            this.Controls.Add(this.lblSERNumDU);
            this.Controls.Add(this.lblSERNumDAR);
            this.Controls.Add(this.lblAviaoNavio);
            this.Controls.Add(this.lblSERPorteBL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtRecTotal);
            this.Controls.Add(this.TxtRECTotalRetencao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbRECAno);
            this.Controls.Add(this.CbRECNumero);
            this.Controls.Add(this.CbRECDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbRECProcesso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbRECCliente);
            this.Controls.Add(this.lblSERTipoServ);
            this.Controls.Add(this.dgvLinhasDrv);
            this.Controls.Add(this.TxtRECTotalSIva);
            this.Controls.Add(this.TxtRECTotalIva);
            this.Controls.Add(this.TxtRECNomeCliente);
            this.Controls.Add(this.BtnRECCriar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDrv";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Declaração de Recepção de Valores";
            this.Load += new System.EventHandler(this.FrmDrv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasDrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button BtnRECCriar;
        private System.Windows.Forms.ComboBox cbTRTProcesso;
        private System.Windows.Forms.DataGridView dgvLinhasDrv;
        private System.Windows.Forms.Label lblHeaderProcesso;
        private System.Windows.Forms.Label lblHeaderUtilizador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtRECNomeCliente;
        private System.Windows.Forms.TextBox TxtRECTotalSIva;
        private System.Windows.Forms.TextBox TxtRECTotalIva;

        #endregion
        private System.Windows.Forms.Label lblSERTipoServ;
        private System.Windows.Forms.ComboBox CbRECCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbRECProcesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbRECDocumento;
        private System.Windows.Forms.ComboBox CbRECNumero;
        private System.Windows.Forms.ComboBox CbRECAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRECTotalRetencao;
        private System.Windows.Forms.TextBox TxtRecTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSERPorteBL;
        private System.Windows.Forms.Label lblAviaoNavio;
        private System.Windows.Forms.Label lblSERNumDAR;
        private System.Windows.Forms.Label lblSERNumDU;
        private System.Windows.Forms.TextBox TxtRECMoeda;
        private System.Windows.Forms.TextBox TxtRECCambio;
        private System.Windows.Forms.TextBox TxtRECTransporte;
        private System.Windows.Forms.TextBox TxtRECBL;
        private System.Windows.Forms.TextBox TxtRECNDar;
        private System.Windows.Forms.TextBox TxtRECNDu;
    }
}