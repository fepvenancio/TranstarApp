using System.ComponentModel;

namespace TRTv10.User_Interface
{
    partial class FrmRqa
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
            this.btnSERFRMREQCria = new System.Windows.Forms.Button();
            this.txtSERFRMRQAProcesso = new System.Windows.Forms.TextBox();
            this.txtSERFRMRQANomeCliente = new System.Windows.Forms.TextBox();
            this.txtSERFRMRQACambio = new System.Windows.Forms.TextBox();
            this.lblSERFRMREQCambio = new System.Windows.Forms.Label();
            this.lblSERFRMREQData = new System.Windows.Forms.Label();
            this.dtpSERFRMRQAData = new System.Windows.Forms.DateTimePicker();
            this.lblSERFRMREQCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSERFRMRQAitem = new System.Windows.Forms.ComboBox();
            this.txtSERFRMRQAValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(582, 17);
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 17);
            this.panel3.TabIndex = 45;
            // 
            // cbTRTProcesso
            // 
            this.cbTRTProcesso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTRTProcesso.FormattingEnabled = true;
            this.cbTRTProcesso.Location = new System.Drawing.Point(810, 17);
            this.cbTRTProcesso.Name = "cbTRTProcesso";
            this.cbTRTProcesso.Size = new System.Drawing.Size(148, 29);
            this.cbTRTProcesso.TabIndex = 3;
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
            // btnSERFRMREQCria
            // 
            this.btnSERFRMREQCria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSERFRMREQCria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSERFRMREQCria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSERFRMREQCria.ForeColor = System.Drawing.Color.White;
            this.btnSERFRMREQCria.Location = new System.Drawing.Point(12, 40);
            this.btnSERFRMREQCria.Name = "btnSERFRMREQCria";
            this.btnSERFRMREQCria.Size = new System.Drawing.Size(109, 35);
            this.btnSERFRMREQCria.TabIndex = 46;
            this.btnSERFRMREQCria.Text = "Criar";
            this.btnSERFRMREQCria.UseVisualStyleBackColor = false;
            this.btnSERFRMREQCria.Click += new System.EventHandler(this.BtnSERFRMREQCria_Click);
            // 
            // txtSERFRMRQAProcesso
            // 
            this.txtSERFRMRQAProcesso.Enabled = false;
            this.txtSERFRMRQAProcesso.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMRQAProcesso.Location = new System.Drawing.Point(12, 96);
            this.txtSERFRMRQAProcesso.Name = "txtSERFRMRQAProcesso";
            this.txtSERFRMRQAProcesso.Size = new System.Drawing.Size(549, 43);
            this.txtSERFRMRQAProcesso.TabIndex = 47;
            this.txtSERFRMRQAProcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSERFRMRQANomeCliente
            // 
            this.txtSERFRMRQANomeCliente.Enabled = false;
            this.txtSERFRMRQANomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMRQANomeCliente.Location = new System.Drawing.Point(65, 158);
            this.txtSERFRMRQANomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERFRMRQANomeCliente.Name = "txtSERFRMRQANomeCliente";
            this.txtSERFRMRQANomeCliente.Size = new System.Drawing.Size(496, 25);
            this.txtSERFRMRQANomeCliente.TabIndex = 59;
            this.txtSERFRMRQANomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSERFRMRQACambio
            // 
            this.txtSERFRMRQACambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMRQACambio.Location = new System.Drawing.Point(65, 324);
            this.txtSERFRMRQACambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERFRMRQACambio.Name = "txtSERFRMRQACambio";
            this.txtSERFRMRQACambio.Size = new System.Drawing.Size(225, 25);
            this.txtSERFRMRQACambio.TabIndex = 58;
            // 
            // lblSERFRMREQCambio
            // 
            this.lblSERFRMREQCambio.AutoSize = true;
            this.lblSERFRMREQCambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMREQCambio.Location = new System.Drawing.Point(12, 327);
            this.lblSERFRMREQCambio.Name = "lblSERFRMREQCambio";
            this.lblSERFRMREQCambio.Size = new System.Drawing.Size(53, 17);
            this.lblSERFRMREQCambio.TabIndex = 57;
            this.lblSERFRMREQCambio.Text = "Cambio";
            // 
            // lblSERFRMREQData
            // 
            this.lblSERFRMREQData.AutoSize = true;
            this.lblSERFRMREQData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMREQData.Location = new System.Drawing.Point(12, 289);
            this.lblSERFRMREQData.Name = "lblSERFRMREQData";
            this.lblSERFRMREQData.Size = new System.Drawing.Size(35, 17);
            this.lblSERFRMREQData.TabIndex = 56;
            this.lblSERFRMREQData.Text = "Data";
            // 
            // dtpSERFRMRQAData
            // 
            this.dtpSERFRMRQAData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSERFRMRQAData.Location = new System.Drawing.Point(65, 283);
            this.dtpSERFRMRQAData.Name = "dtpSERFRMRQAData";
            this.dtpSERFRMRQAData.Size = new System.Drawing.Size(225, 25);
            this.dtpSERFRMRQAData.TabIndex = 55;
            // 
            // lblSERFRMREQCliente
            // 
            this.lblSERFRMREQCliente.AutoSize = true;
            this.lblSERFRMREQCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMREQCliente.Location = new System.Drawing.Point(12, 161);
            this.lblSERFRMREQCliente.Name = "lblSERFRMREQCliente";
            this.lblSERFRMREQCliente.Size = new System.Drawing.Size(47, 17);
            this.lblSERFRMREQCliente.TabIndex = 54;
            this.lblSERFRMREQCliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Item";
            // 
            // cbSERFRMRQAitem
            // 
            this.cbSERFRMRQAitem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERFRMRQAitem.FormattingEnabled = true;
            this.cbSERFRMRQAitem.Location = new System.Drawing.Point(65, 199);
            this.cbSERFRMRQAitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSERFRMRQAitem.Name = "cbSERFRMRQAitem";
            this.cbSERFRMRQAitem.Size = new System.Drawing.Size(496, 25);
            this.cbSERFRMRQAitem.TabIndex = 61;
            // 
            // txtSERFRMRQAValor
            // 
            this.txtSERFRMRQAValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMRQAValor.Location = new System.Drawing.Point(65, 241);
            this.txtSERFRMRQAValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSERFRMRQAValor.Name = "txtSERFRMRQAValor";
            this.txtSERFRMRQAValor.Size = new System.Drawing.Size(225, 25);
            this.txtSERFRMRQAValor.TabIndex = 62;
            this.txtSERFRMRQAValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Valor";
            // 
            // FrmRQA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSERFRMRQAValor);
            this.Controls.Add(this.cbSERFRMRQAitem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSERFRMRQANomeCliente);
            this.Controls.Add(this.txtSERFRMRQACambio);
            this.Controls.Add(this.lblSERFRMREQCambio);
            this.Controls.Add(this.lblSERFRMREQData);
            this.Controls.Add(this.dtpSERFRMRQAData);
            this.Controls.Add(this.lblSERFRMREQCliente);
            this.Controls.Add(this.txtSERFRMRQAProcesso);
            this.Controls.Add(this.btnSERFRMREQCria);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRqa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisição de Fundos - Adicional";
            this.Load += new System.EventHandler(this.FrmRQA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSERFRMREQCria;
        private System.Windows.Forms.ComboBox cbSERFRMRQAitem;
        private System.Windows.Forms.ComboBox cbTRTProcesso;
        private System.Windows.Forms.DateTimePicker dtpSERFRMRQAData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHeaderProcesso;
        private System.Windows.Forms.Label lblHeaderUtilizador;
        private System.Windows.Forms.Label lblSERFRMREQCambio;
        private System.Windows.Forms.Label lblSERFRMREQCliente;
        private System.Windows.Forms.Label lblSERFRMREQData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSERFRMRQACambio;
        private System.Windows.Forms.TextBox txtSERFRMRQANomeCliente;
        private System.Windows.Forms.TextBox txtSERFRMRQAProcesso;
        private System.Windows.Forms.TextBox txtSERFRMRQAValor;

        #endregion
    }
}