using System.ComponentModel;

namespace TRTv10.User_Interface
{
    partial class FrmRequisicao
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
            this.btnSERFRMREQCria = new System.Windows.Forms.Button();
            this.lblSERFRMREQTipoProc = new System.Windows.Forms.Label();
            this.cbSERFRMREQTipoProc = new System.Windows.Forms.ComboBox();
            this.txtSERFRMREQProcesso = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeaderUtilizador = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTRTProcesso = new System.Windows.Forms.ComboBox();
            this.lblHeaderProcesso = new System.Windows.Forms.Label();
            this.lblSERFRMREQCliente = new System.Windows.Forms.Label();
            this.cbSERFRMREQCliente = new System.Windows.Forms.ComboBox();
            this.dtpSERFRMREQData = new System.Windows.Forms.DateTimePicker();
            this.lblSERFRMREQData = new System.Windows.Forms.Label();
            this.lblSERFRMREQCambio = new System.Windows.Forms.Label();
            this.txtSERFRMREQCambio = new System.Windows.Forms.TextBox();
            this.txtSERFRMREQREQExistente = new System.Windows.Forms.TextBox();
            this.txtSERFRMREQNomeCliente = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSERFRMREQCria
            // 
            this.btnSERFRMREQCria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSERFRMREQCria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSERFRMREQCria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSERFRMREQCria.ForeColor = System.Drawing.Color.White;
            this.btnSERFRMREQCria.Location = new System.Drawing.Point(12, 41);
            this.btnSERFRMREQCria.Name = "btnSERFRMREQCria";
            this.btnSERFRMREQCria.Size = new System.Drawing.Size(109, 35);
            this.btnSERFRMREQCria.TabIndex = 39;
            this.btnSERFRMREQCria.Text = "Criar";
            this.btnSERFRMREQCria.UseVisualStyleBackColor = false;
            this.btnSERFRMREQCria.Click += new System.EventHandler(this.BtnSERFRMREQCria_Click);
            // 
            // lblSERFRMREQTipoProc
            // 
            this.lblSERFRMREQTipoProc.AutoSize = true;
            this.lblSERFRMREQTipoProc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMREQTipoProc.Location = new System.Drawing.Point(12, 158);
            this.lblSERFRMREQTipoProc.Name = "lblSERFRMREQTipoProc";
            this.lblSERFRMREQTipoProc.Size = new System.Drawing.Size(110, 17);
            this.lblSERFRMREQTipoProc.TabIndex = 41;
            this.lblSERFRMREQTipoProc.Text = "Tipo de Processo";
            // 
            // cbSERFRMREQTipoProc
            // 
            this.cbSERFRMREQTipoProc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERFRMREQTipoProc.FormattingEnabled = true;
            this.cbSERFRMREQTipoProc.Location = new System.Drawing.Point(151, 155);
            this.cbSERFRMREQTipoProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSERFRMREQTipoProc.Name = "cbSERFRMREQTipoProc";
            this.cbSERFRMREQTipoProc.Size = new System.Drawing.Size(378, 25);
            this.cbSERFRMREQTipoProc.TabIndex = 40;
            this.cbSERFRMREQTipoProc.SelectedIndexChanged += new System.EventHandler(this.CbSERFRMREQTipoProc_SelectedIndexChanged);
            // 
            // txtSERFRMREQProcesso
            // 
            this.txtSERFRMREQProcesso.Enabled = false;
            this.txtSERFRMREQProcesso.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMREQProcesso.Location = new System.Drawing.Point(12, 100);
            this.txtSERFRMREQProcesso.Name = "txtSERFRMREQProcesso";
            this.txtSERFRMREQProcesso.Size = new System.Drawing.Size(517, 43);
            this.txtSERFRMREQProcesso.TabIndex = 42;
            this.txtSERFRMREQProcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblHeaderUtilizador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 17);
            this.panel1.TabIndex = 43;
            // 
            // lblHeaderUtilizador
            // 
            this.lblHeaderUtilizador.AutoSize = true;
            this.lblHeaderUtilizador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderUtilizador.ForeColor = System.Drawing.Color.White;
            this.lblHeaderUtilizador.Location = new System.Drawing.Point(1137, 26);
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 18);
            this.panel3.TabIndex = 44;
            // 
            // cbTRTProcesso
            // 
            this.cbTRTProcesso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTRTProcesso.FormattingEnabled = true;
            this.cbTRTProcesso.Location = new System.Drawing.Point(810, 17);
            this.cbTRTProcesso.Name = "cbTRTProcesso";
            this.cbTRTProcesso.Size = new System.Drawing.Size(148, 29);
            this.cbTRTProcesso.TabIndex = 3;
            this.cbTRTProcesso.Text = "Requisição";
            // 
            // lblHeaderProcesso
            // 
            this.lblHeaderProcesso.AutoSize = true;
            this.lblHeaderProcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderProcesso.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeaderProcesso.Location = new System.Drawing.Point(202, 15);
            this.lblHeaderProcesso.Name = "lblHeaderProcesso";
            this.lblHeaderProcesso.Size = new System.Drawing.Size(0, 17);
            this.lblHeaderProcesso.TabIndex = 2;
            // 
            // lblSERFRMREQCliente
            // 
            this.lblSERFRMREQCliente.AutoSize = true;
            this.lblSERFRMREQCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMREQCliente.Location = new System.Drawing.Point(12, 200);
            this.lblSERFRMREQCliente.Name = "lblSERFRMREQCliente";
            this.lblSERFRMREQCliente.Size = new System.Drawing.Size(47, 17);
            this.lblSERFRMREQCliente.TabIndex = 46;
            this.lblSERFRMREQCliente.Text = "Cliente";
            // 
            // cbSERFRMREQCliente
            // 
            this.cbSERFRMREQCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERFRMREQCliente.FormattingEnabled = true;
            this.cbSERFRMREQCliente.Location = new System.Drawing.Point(151, 192);
            this.cbSERFRMREQCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSERFRMREQCliente.Name = "cbSERFRMREQCliente";
            this.cbSERFRMREQCliente.Size = new System.Drawing.Size(378, 25);
            this.cbSERFRMREQCliente.TabIndex = 45;
            this.cbSERFRMREQCliente.SelectedIndexChanged += new System.EventHandler(this.CbSERFRMREQCliente_SelectedIndexChanged);
            // 
            // dtpSERFRMREQData
            // 
            this.dtpSERFRMREQData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSERFRMREQData.Location = new System.Drawing.Point(151, 278);
            this.dtpSERFRMREQData.Name = "dtpSERFRMREQData";
            this.dtpSERFRMREQData.Size = new System.Drawing.Size(151, 25);
            this.dtpSERFRMREQData.TabIndex = 47;
            // 
            // lblSERFRMREQData
            // 
            this.lblSERFRMREQData.AutoSize = true;
            this.lblSERFRMREQData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMREQData.Location = new System.Drawing.Point(12, 289);
            this.lblSERFRMREQData.Name = "lblSERFRMREQData";
            this.lblSERFRMREQData.Size = new System.Drawing.Size(35, 17);
            this.lblSERFRMREQData.TabIndex = 48;
            this.lblSERFRMREQData.Text = "Data";
            // 
            // lblSERFRMREQCambio
            // 
            this.lblSERFRMREQCambio.AutoSize = true;
            this.lblSERFRMREQCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMREQCambio.Location = new System.Drawing.Point(12, 327);
            this.lblSERFRMREQCambio.Name = "lblSERFRMREQCambio";
            this.lblSERFRMREQCambio.Size = new System.Drawing.Size(53, 17);
            this.lblSERFRMREQCambio.TabIndex = 49;
            this.lblSERFRMREQCambio.Text = "Cambio";
            // 
            // txtSERFRMREQCambio
            // 
            this.txtSERFRMREQCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMREQCambio.Location = new System.Drawing.Point(151, 319);
            this.txtSERFRMREQCambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERFRMREQCambio.Name = "txtSERFRMREQCambio";
            this.txtSERFRMREQCambio.Size = new System.Drawing.Size(151, 25);
            this.txtSERFRMREQCambio.TabIndex = 50;
            // 
            // txtSERFRMREQREQExistente
            // 
            this.txtSERFRMREQREQExistente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSERFRMREQREQExistente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMREQREQExistente.Location = new System.Drawing.Point(151, 44);
            this.txtSERFRMREQREQExistente.Name = "txtSERFRMREQREQExistente";
            this.txtSERFRMREQREQExistente.Size = new System.Drawing.Size(292, 26);
            this.txtSERFRMREQREQExistente.TabIndex = 51;
            this.txtSERFRMREQREQExistente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSERFRMREQNomeCliente
            // 
            this.txtSERFRMREQNomeCliente.Enabled = false;
            this.txtSERFRMREQNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMREQNomeCliente.Location = new System.Drawing.Point(15, 234);
            this.txtSERFRMREQNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERFRMREQNomeCliente.Name = "txtSERFRMREQNomeCliente";
            this.txtSERFRMREQNomeCliente.Size = new System.Drawing.Size(514, 25);
            this.txtSERFRMREQNomeCliente.TabIndex = 52;
            this.txtSERFRMREQNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 366);
            this.Controls.Add(this.txtSERFRMREQNomeCliente);
            this.Controls.Add(this.txtSERFRMREQREQExistente);
            this.Controls.Add(this.txtSERFRMREQCambio);
            this.Controls.Add(this.lblSERFRMREQCambio);
            this.Controls.Add(this.lblSERFRMREQData);
            this.Controls.Add(this.dtpSERFRMREQData);
            this.Controls.Add(this.lblSERFRMREQCliente);
            this.Controls.Add(this.cbSERFRMREQCliente);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSERFRMREQProcesso);
            this.Controls.Add(this.lblSERFRMREQTipoProc);
            this.Controls.Add(this.cbSERFRMREQTipoProc);
            this.Controls.Add(this.btnSERFRMREQCria);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRequisicao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisição de Fundos";
            this.Load += new System.EventHandler(this.FrmRequisao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSERFRMREQCria;
        private System.Windows.Forms.ComboBox cbSERFRMREQCliente;
        private System.Windows.Forms.ComboBox cbSERFRMREQTipoProc;
        private System.Windows.Forms.ComboBox cbTRTProcesso;
        private System.Windows.Forms.DateTimePicker dtpSERFRMREQData;
        private System.Windows.Forms.Label lblHeaderProcesso;
        private System.Windows.Forms.Label lblHeaderUtilizador;
        private System.Windows.Forms.Label lblSERFRMREQCambio;
        private System.Windows.Forms.Label lblSERFRMREQCliente;
        private System.Windows.Forms.Label lblSERFRMREQData;
        private System.Windows.Forms.Label lblSERFRMREQTipoProc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSERFRMREQCambio;
        private System.Windows.Forms.TextBox txtSERFRMREQNomeCliente;
        private System.Windows.Forms.TextBox txtSERFRMREQProcesso;
        private System.Windows.Forms.TextBox txtSERFRMREQREQExistente;

        #endregion
    }
}