using System.ComponentModel;

namespace TRTv10.User_Interface
{
    partial class FrmTransporte
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
            this.chbSERFRMSubCT = new System.Windows.Forms.CheckBox();
            this.chbSERFRMInt = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeaderUtilizador = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbSERFRMSubCT
            // 
            this.chbSERFRMSubCT.Location = new System.Drawing.Point(27, 64);
            this.chbSERFRMSubCT.Name = "chbSERFRMSubCT";
            this.chbSERFRMSubCT.Size = new System.Drawing.Size(141, 24);
            this.chbSERFRMSubCT.TabIndex = 0;
            this.chbSERFRMSubCT.Text = "SubContratado";
            this.chbSERFRMSubCT.UseVisualStyleBackColor = true;
            this.chbSERFRMSubCT.CheckedChanged += new System.EventHandler(this.ChbSERFRMSubCT_Alterada);
            // 
            // chbSERFRMInt
            // 
            this.chbSERFRMInt.Location = new System.Drawing.Point(201, 64);
            this.chbSERFRMInt.Name = "chbSERFRMInt";
            this.chbSERFRMInt.Size = new System.Drawing.Size(152, 24);
            this.chbSERFRMInt.TabIndex = 1;
            this.chbSERFRMInt.Text = "Próprio/Interno";
            this.chbSERFRMInt.UseVisualStyleBackColor = true;
            this.chbSERFRMInt.CheckedChanged += new System.EventHandler(this.ChbSERFRMInt_Alterada);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblHeaderUtilizador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 15);
            this.panel1.TabIndex = 2;
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 18);
            this.panel3.TabIndex = 3;
            // 
            // FrmTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 114);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chbSERFRMInt);
            this.Controls.Add(this.chbSERFRMSubCT);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTransporte";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transporte";
            this.Load += new System.EventHandler(this.FrmTransporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.CheckBox chbSERFRMInt;
        private System.Windows.Forms.CheckBox chbSERFRMSubCT;
        private System.Windows.Forms.Label lblHeaderUtilizador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;

        #endregion
    }
}