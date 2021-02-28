
namespace TRTv10.User_Interface
{
    partial class FrmExtracto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtracto));
            this.BtnExtImprimir = new System.Windows.Forms.Button();
            this.dgvExtDocumentos = new System.Windows.Forms.DataGridView();
            this.lblSERCliente = new System.Windows.Forms.Label();
            this.CbExtCliente = new System.Windows.Forms.ComboBox();
            this.BtnExtActualizar = new System.Windows.Forms.Button();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.CbExtProcessos = new System.Windows.Forms.ComboBox();
            this.TxtExtNomeCliente = new System.Windows.Forms.TextBox();
            this.ChbExtRelFechada = new System.Windows.Forms.CheckBox();
            this.ChbExtRelMisto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExtImprimir
            // 
            this.BtnExtImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnExtImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExtImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnExtImprimir.Location = new System.Drawing.Point(117, 28);
            this.BtnExtImprimir.Name = "BtnExtImprimir";
            this.BtnExtImprimir.Size = new System.Drawing.Size(99, 38);
            this.BtnExtImprimir.TabIndex = 137;
            this.BtnExtImprimir.Text = "Imprimir";
            this.BtnExtImprimir.UseVisualStyleBackColor = false;
            // 
            // dgvExtDocumentos
            // 
            this.dgvExtDocumentos.AllowUserToAddRows = false;
            this.dgvExtDocumentos.AllowUserToDeleteRows = false;
            this.dgvExtDocumentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvExtDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtDocumentos.Location = new System.Drawing.Point(36, 202);
            this.dgvExtDocumentos.Name = "dgvExtDocumentos";
            this.dgvExtDocumentos.Size = new System.Drawing.Size(1208, 504);
            this.dgvExtDocumentos.TabIndex = 140;
            // 
            // lblSERCliente
            // 
            this.lblSERCliente.AutoSize = true;
            this.lblSERCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERCliente.Location = new System.Drawing.Point(33, 130);
            this.lblSERCliente.Name = "lblSERCliente";
            this.lblSERCliente.Size = new System.Drawing.Size(47, 17);
            this.lblSERCliente.TabIndex = 139;
            this.lblSERCliente.Text = "Cliente";
            // 
            // CbExtCliente
            // 
            this.CbExtCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbExtCliente.FormattingEnabled = true;
            this.CbExtCliente.Location = new System.Drawing.Point(112, 127);
            this.CbExtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbExtCliente.Name = "CbExtCliente";
            this.CbExtCliente.Size = new System.Drawing.Size(148, 25);
            this.CbExtCliente.TabIndex = 138;
            this.CbExtCliente.SelectedIndexChanged += new System.EventHandler(this.CbExtCliente_SelectedIndexChanged);
            // 
            // BtnExtActualizar
            // 
            this.BtnExtActualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnExtActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExtActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnExtActualizar.Location = new System.Drawing.Point(12, 28);
            this.BtnExtActualizar.Name = "BtnExtActualizar";
            this.BtnExtActualizar.Size = new System.Drawing.Size(99, 38);
            this.BtnExtActualizar.TabIndex = 141;
            this.BtnExtActualizar.Text = "Actualizar";
            this.BtnExtActualizar.UseVisualStyleBackColor = false;
            this.BtnExtActualizar.Click += new System.EventHandler(this.BtnExtActualizar_Click);
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesso.Location = new System.Drawing.Point(33, 168);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(61, 17);
            this.lblProcesso.TabIndex = 143;
            this.lblProcesso.Text = "Processo";
            // 
            // CbExtProcessos
            // 
            this.CbExtProcessos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbExtProcessos.FormattingEnabled = true;
            this.CbExtProcessos.Location = new System.Drawing.Point(112, 165);
            this.CbExtProcessos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbExtProcessos.Name = "CbExtProcessos";
            this.CbExtProcessos.Size = new System.Drawing.Size(148, 25);
            this.CbExtProcessos.TabIndex = 142;
            // 
            // TxtExtNomeCliente
            // 
            this.TxtExtNomeCliente.Enabled = false;
            this.TxtExtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExtNomeCliente.Location = new System.Drawing.Point(266, 127);
            this.TxtExtNomeCliente.Name = "TxtExtNomeCliente";
            this.TxtExtNomeCliente.Size = new System.Drawing.Size(626, 25);
            this.TxtExtNomeCliente.TabIndex = 144;
            // 
            // ChbExtRelFechada
            // 
            this.ChbExtRelFechada.AutoSize = true;
            this.ChbExtRelFechada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbExtRelFechada.Location = new System.Drawing.Point(1087, 45);
            this.ChbExtRelFechada.Name = "ChbExtRelFechada";
            this.ChbExtRelFechada.Size = new System.Drawing.Size(157, 21);
            this.ChbExtRelFechada.TabIndex = 145;
            this.ChbExtRelFechada.Text = "Rel. de Conta Fechada";
            this.ChbExtRelFechada.UseVisualStyleBackColor = true;
            this.ChbExtRelFechada.CheckedChanged += new System.EventHandler(this.ChbExtRelFechada_CheckedChanged);
            // 
            // ChbExtRelMisto
            // 
            this.ChbExtRelMisto.AutoSize = true;
            this.ChbExtRelMisto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbExtRelMisto.Location = new System.Drawing.Point(1087, 86);
            this.ChbExtRelMisto.Name = "ChbExtRelMisto";
            this.ChbExtRelMisto.Size = new System.Drawing.Size(142, 21);
            this.ChbExtRelMisto.TabIndex = 146;
            this.ChbExtRelMisto.Text = "Rel. de Conta Misto";
            this.ChbExtRelMisto.UseVisualStyleBackColor = true;
            this.ChbExtRelMisto.CheckedChanged += new System.EventHandler(this.ChbExtRelMisto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 147;
            this.label1.Text = "Data Inicial";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CustomFormat = "";
            this.dtpDataInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(112, 90);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(148, 25);
            this.dtpDataInicial.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 150;
            this.label2.Text = "Data Final";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "";
            this.dtpDataFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(337, 90);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(148, 25);
            this.dtpDataFinal.TabIndex = 151;
            // 
            // FrmExtracto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 718);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChbExtRelMisto);
            this.Controls.Add(this.ChbExtRelFechada);
            this.Controls.Add(this.TxtExtNomeCliente);
            this.Controls.Add(this.lblProcesso);
            this.Controls.Add(this.CbExtProcessos);
            this.Controls.Add(this.BtnExtActualizar);
            this.Controls.Add(this.BtnExtImprimir);
            this.Controls.Add(this.dgvExtDocumentos);
            this.Controls.Add(this.lblSERCliente);
            this.Controls.Add(this.CbExtCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExtracto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extracto de Processos";
            this.Load += new System.EventHandler(this.FrmExtracto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExtImprimir;
        public System.Windows.Forms.DataGridView dgvExtDocumentos;
        private System.Windows.Forms.Label lblSERCliente;
        public System.Windows.Forms.ComboBox CbExtCliente;
        private System.Windows.Forms.Button BtnExtActualizar;
        private System.Windows.Forms.Label lblProcesso;
        public System.Windows.Forms.ComboBox CbExtProcessos;
        public System.Windows.Forms.TextBox TxtExtNomeCliente;
        private System.Windows.Forms.CheckBox ChbExtRelFechada;
        private System.Windows.Forms.CheckBox ChbExtRelMisto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
    }
}