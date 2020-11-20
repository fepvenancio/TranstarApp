using System.ComponentModel;

namespace TRTv10.User_Interface
{
    partial class FrmRecibo
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
            this.chbTotal = new System.Windows.Forms.CheckBox();
            this.chbParcial = new System.Windows.Forms.CheckBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtValorTot = new System.Windows.Forms.TextBox();
            this.txtValorRec = new System.Windows.Forms.TextBox();
            this.dgvLinhasRecibo = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasRecibo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(740, 17);
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
            this.panel3.Size = new System.Drawing.Size(740, 16);
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
            // chbTotal
            // 
            this.chbTotal.Location = new System.Drawing.Point(12, 219);
            this.chbTotal.Name = "chbTotal";
            this.chbTotal.Size = new System.Drawing.Size(210, 24);
            this.chbTotal.TabIndex = 47;
            this.chbTotal.Text = "Valor total do documento";
            this.chbTotal.UseVisualStyleBackColor = true;
            this.chbTotal.CheckedChanged += new System.EventHandler(this.ChbTotal_CheckedChanged);
            // 
            // chbParcial
            // 
            this.chbParcial.Location = new System.Drawing.Point(12, 261);
            this.chbParcial.Name = "chbParcial";
            this.chbParcial.Size = new System.Drawing.Size(210, 24);
            this.chbParcial.TabIndex = 48;
            this.chbParcial.Text = "Valor parcial do documento";
            this.chbParcial.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(12, 108);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(187, 25);
            this.txtDocumento.TabIndex = 49;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorTot
            // 
            this.txtValorTot.Enabled = false;
            this.txtValorTot.Location = new System.Drawing.Point(12, 141);
            this.txtValorTot.Name = "txtValorTot";
            this.txtValorTot.Size = new System.Drawing.Size(187, 25);
            this.txtValorTot.TabIndex = 50;
            this.txtValorTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorRec
            // 
            this.txtValorRec.Enabled = false;
            this.txtValorRec.Location = new System.Drawing.Point(12, 172);
            this.txtValorRec.Name = "txtValorRec";
            this.txtValorRec.Size = new System.Drawing.Size(187, 25);
            this.txtValorRec.TabIndex = 52;
            this.txtValorRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvLinhasRecibo
            // 
            this.dgvLinhasRecibo.AllowUserToAddRows = false;
            this.dgvLinhasRecibo.AllowUserToDeleteRows = false;
            this.dgvLinhasRecibo.BackgroundColor = System.Drawing.Color.White;
            this.dgvLinhasRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhasRecibo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Item,
            this.ValorTotal,
            this.IdLinha});
            this.dgvLinhasRecibo.Location = new System.Drawing.Point(239, 40);
            this.dgvLinhasRecibo.Name = "dgvLinhasRecibo";
            this.dgvLinhasRecibo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinhasRecibo.Size = new System.Drawing.Size(490, 245);
            this.dgvLinhasRecibo.TabIndex = 53;
            this.dgvLinhasRecibo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLinhasRecibo_CellValueChanged);
            // 
            // Select
            // 
            this.Select.HeaderText = "Sel";
            this.Select.Name = "Select";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // IdLinha
            // 
            this.IdLinha.HeaderText = "IdLinha";
            this.IdLinha.Name = "IdLinha";
            // 
            // FrmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 307);
            this.Controls.Add(this.dgvLinhasRecibo);
            this.Controls.Add(this.txtValorRec);
            this.Controls.Add(this.txtValorTot);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.chbParcial);
            this.Controls.Add(this.chbTotal);
            this.Controls.Add(this.btnSERFRMREQCria);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRecibo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.FrmRecibo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasRecibo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSERFRMREQCria;
        private System.Windows.Forms.ComboBox cbTRTProcesso;
        private System.Windows.Forms.CheckBox chbParcial;
        private System.Windows.Forms.CheckBox chbTotal;
        private System.Windows.Forms.DataGridView dgvLinhasRecibo;
        private System.Windows.Forms.Label lblHeaderProcesso;
        private System.Windows.Forms.Label lblHeaderUtilizador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtValorRec;
        private System.Windows.Forms.TextBox txtValorTot;

        #endregion

        private new System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLinha;
    }
}