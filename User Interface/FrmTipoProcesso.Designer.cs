using System.ComponentModel;

namespace TRTv10.User_Interface
{
    partial class FrmTipoProcesso
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
            this.lblSERFRMTPTipoProc = new System.Windows.Forms.Label();
            this.cbSERFRMTPTipoProc = new System.Windows.Forms.ComboBox();
            this.btnSERFRMTPCria = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTRTProcesso = new System.Windows.Forms.ComboBox();
            this.lblHeaderProcesso = new System.Windows.Forms.Label();
            this.txtSERFRMTPProcesso = new System.Windows.Forms.TextBox();
            this.txtSERFRMTipoProcExistente = new System.Windows.Forms.TextBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 15);
            this.panel1.TabIndex = 48;
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
            // lblSERFRMTPTipoProc
            // 
            this.lblSERFRMTPTipoProc.AutoSize = true;
            this.lblSERFRMTPTipoProc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERFRMTPTipoProc.Location = new System.Drawing.Point(12, 158);
            this.lblSERFRMTPTipoProc.Name = "lblSERFRMTPTipoProc";
            this.lblSERFRMTPTipoProc.Size = new System.Drawing.Size(110, 17);
            this.lblSERFRMTPTipoProc.TabIndex = 47;
            this.lblSERFRMTPTipoProc.Text = "Tipo de Processo";
            // 
            // cbSERFRMTPTipoProc
            // 
            this.cbSERFRMTPTipoProc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSERFRMTPTipoProc.FormattingEnabled = true;
            this.cbSERFRMTPTipoProc.Location = new System.Drawing.Point(128, 155);
            this.cbSERFRMTPTipoProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSERFRMTPTipoProc.Name = "cbSERFRMTPTipoProc";
            this.cbSERFRMTPTipoProc.Size = new System.Drawing.Size(338, 25);
            this.cbSERFRMTPTipoProc.TabIndex = 46;
            this.cbSERFRMTPTipoProc.SelectedIndexChanged += new System.EventHandler(this.CbSERFRMTPTipoProc_SelectedIndexChanged);
            // 
            // btnSERFRMTPCria
            // 
            this.btnSERFRMTPCria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSERFRMTPCria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSERFRMTPCria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSERFRMTPCria.ForeColor = System.Drawing.Color.White;
            this.btnSERFRMTPCria.Location = new System.Drawing.Point(12, 39);
            this.btnSERFRMTPCria.Name = "btnSERFRMTPCria";
            this.btnSERFRMTPCria.Size = new System.Drawing.Size(109, 35);
            this.btnSERFRMTPCria.TabIndex = 45;
            this.btnSERFRMTPCria.Text = "Criar";
            this.btnSERFRMTPCria.UseVisualStyleBackColor = false;
            this.btnSERFRMTPCria.Click += new System.EventHandler(this.BtnSERFRMTPCria_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.cbTRTProcesso);
            this.panel3.Controls.Add(this.lblHeaderProcesso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 18);
            this.panel3.TabIndex = 49;
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
            // txtSERFRMTPProcesso
            // 
            this.txtSERFRMTPProcesso.Enabled = false;
            this.txtSERFRMTPProcesso.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMTPProcesso.Location = new System.Drawing.Point(15, 92);
            this.txtSERFRMTPProcesso.Name = "txtSERFRMTPProcesso";
            this.txtSERFRMTPProcesso.Size = new System.Drawing.Size(454, 43);
            this.txtSERFRMTPProcesso.TabIndex = 50;
            this.txtSERFRMTPProcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSERFRMTipoProcExistente
            // 
            this.txtSERFRMTipoProcExistente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSERFRMTipoProcExistente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERFRMTipoProcExistente.Location = new System.Drawing.Point(156, 42);
            this.txtSERFRMTipoProcExistente.Name = "txtSERFRMTipoProcExistente";
            this.txtSERFRMTipoProcExistente.Size = new System.Drawing.Size(292, 26);
            this.txtSERFRMTipoProcExistente.TabIndex = 52;
            this.txtSERFRMTipoProcExistente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmTipoProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 211);
            this.Controls.Add(this.txtSERFRMTipoProcExistente);
            this.Controls.Add(this.txtSERFRMTPProcesso);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSERFRMTPTipoProc);
            this.Controls.Add(this.cbSERFRMTPTipoProc);
            this.Controls.Add(this.btnSERFRMTPCria);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTipoProcesso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Processo";
            this.Load += new System.EventHandler(this.FrmTipoProcesso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSERFRMTPCria;
        private System.Windows.Forms.ComboBox cbSERFRMTPTipoProc;
        private System.Windows.Forms.ComboBox cbTRTProcesso;
        private System.Windows.Forms.Label lblHeaderProcesso;
        private System.Windows.Forms.Label lblHeaderUtilizador;
        private System.Windows.Forms.Label lblSERFRMTPTipoProc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSERFRMTipoProcExistente;
        private System.Windows.Forms.TextBox txtSERFRMTPProcesso;

        #endregion
    }
}