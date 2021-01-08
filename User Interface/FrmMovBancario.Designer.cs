
namespace TRTv10.User_Interface
{
    partial class FrmMovBancario
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
            this.cbMOVConta = new System.Windows.Forms.ComboBox();
            this.cbMOVmovimento = new System.Windows.Forms.ComboBox();
            this.txtMOVDescricao = new System.Windows.Forms.TextBox();
            this.lblContaBancaria = new System.Windows.Forms.Label();
            this.lblMovimento = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMOVConta
            // 
            this.cbMOVConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMOVConta.FormattingEnabled = true;
            this.cbMOVConta.Location = new System.Drawing.Point(167, 43);
            this.cbMOVConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMOVConta.Name = "cbMOVConta";
            this.cbMOVConta.Size = new System.Drawing.Size(181, 29);
            this.cbMOVConta.TabIndex = 8;
            // 
            // cbMOVmovimento
            // 
            this.cbMOVmovimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMOVmovimento.FormattingEnabled = true;
            this.cbMOVmovimento.Location = new System.Drawing.Point(167, 94);
            this.cbMOVmovimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMOVmovimento.Name = "cbMOVmovimento";
            this.cbMOVmovimento.Size = new System.Drawing.Size(181, 29);
            this.cbMOVmovimento.TabIndex = 9;
            // 
            // txtMOVDescricao
            // 
            this.txtMOVDescricao.Enabled = false;
            this.txtMOVDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOVDescricao.Location = new System.Drawing.Point(167, 147);
            this.txtMOVDescricao.Name = "txtMOVDescricao";
            this.txtMOVDescricao.Size = new System.Drawing.Size(488, 25);
            this.txtMOVDescricao.TabIndex = 88;
            // 
            // lblContaBancaria
            // 
            this.lblContaBancaria.AutoSize = true;
            this.lblContaBancaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaBancaria.Location = new System.Drawing.Point(33, 49);
            this.lblContaBancaria.Name = "lblContaBancaria";
            this.lblContaBancaria.Size = new System.Drawing.Size(95, 17);
            this.lblContaBancaria.TabIndex = 89;
            this.lblContaBancaria.Text = "Conta Bancária";
            // 
            // lblMovimento
            // 
            this.lblMovimento.AutoSize = true;
            this.lblMovimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimento.Location = new System.Drawing.Point(33, 100);
            this.lblMovimento.Name = "lblMovimento";
            this.lblMovimento.Size = new System.Drawing.Size(128, 17);
            this.lblMovimento.TabIndex = 90;
            this.lblMovimento.Text = "Movimento Bancário";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(33, 150);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 17);
            this.lblDescricao.TabIndex = 91;
            this.lblDescricao.Text = "Descrição";
            // 
            // FrmMovBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblMovimento);
            this.Controls.Add(this.lblContaBancaria);
            this.Controls.Add(this.txtMOVDescricao);
            this.Controls.Add(this.cbMOVmovimento);
            this.Controls.Add(this.cbMOVConta);
            this.Name = "FrmMovBancario";
            this.ShowIcon = false;
            this.Text = "7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMOVConta;
        private System.Windows.Forms.ComboBox cbMOVmovimento;
        private System.Windows.Forms.TextBox txtMOVDescricao;
        private System.Windows.Forms.Label lblContaBancaria;
        private System.Windows.Forms.Label lblMovimento;
        private System.Windows.Forms.Label lblDescricao;
    }
}