namespace TRTv10.User_Interface
{
    partial class FrmExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExplorer));
            this.mnsExplorer = new System.Windows.Forms.MenuStrip();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarCotacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoDeCOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisiçõesInternasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProcessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprovaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprovaçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsExplorer = new System.Windows.Forms.ToolStrip();
            this.tlsLabelUtilizador = new System.Windows.Forms.ToolStripLabel();
            this.mnsExplorer.SuspendLayout();
            this.tlsExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsExplorer
            // 
            this.mnsExplorer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.processoToolStripMenuItem,
            this.aprovaçõesToolStripMenuItem,
            this.tabelasToolStripMenuItem});
            this.mnsExplorer.Location = new System.Drawing.Point(0, 0);
            this.mnsExplorer.Name = "mnsExplorer";
            this.mnsExplorer.Size = new System.Drawing.Size(1155, 29);
            this.mnsExplorer.TabIndex = 0;
            this.mnsExplorer.Text = "mnsExplorer";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarCotacaoToolStripMenuItem,
            this.conversãoDeCOTToolStripMenuItem,
            this.requisiçõesToolStripMenuItem,
            this.pagamentosDeClienteToolStripMenuItem,
            this.requisiçõesInternasToolStripMenuItem,
            this.documentosToolStripMenuItem1,
            this.recibosToolStripMenuItem,
            this.reimpressãoToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.serviçosToolStripMenuItem.Text = "Documentos";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // criarCotacaoToolStripMenuItem
            // 
            this.criarCotacaoToolStripMenuItem.Name = "criarCotacaoToolStripMenuItem";
            this.criarCotacaoToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.criarCotacaoToolStripMenuItem.Text = "Cotações";
            this.criarCotacaoToolStripMenuItem.Click += new System.EventHandler(this.CriarCotacaoToolStripMenuItem_Click);
            // 
            // conversãoDeCOTToolStripMenuItem
            // 
            this.conversãoDeCOTToolStripMenuItem.Name = "conversãoDeCOTToolStripMenuItem";
            this.conversãoDeCOTToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.conversãoDeCOTToolStripMenuItem.Text = "Conversão de Cotações em Requisições";
            this.conversãoDeCOTToolStripMenuItem.Click += new System.EventHandler(this.conversãoDeCOTToolStripMenuItem_Click);
            // 
            // requisiçõesToolStripMenuItem
            // 
            this.requisiçõesToolStripMenuItem.Name = "requisiçõesToolStripMenuItem";
            this.requisiçõesToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.requisiçõesToolStripMenuItem.Text = "Requisições";
            this.requisiçõesToolStripMenuItem.Click += new System.EventHandler(this.requisiçõesToolStripMenuItem_Click);
            // 
            // pagamentosDeClienteToolStripMenuItem
            // 
            this.pagamentosDeClienteToolStripMenuItem.Name = "pagamentosDeClienteToolStripMenuItem";
            this.pagamentosDeClienteToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.pagamentosDeClienteToolStripMenuItem.Text = "Declaração de Recepção de Valores";
            this.pagamentosDeClienteToolStripMenuItem.Click += new System.EventHandler(this.drv_ToolStripMenuItem_Click);
            // 
            // requisiçõesInternasToolStripMenuItem
            // 
            this.requisiçõesInternasToolStripMenuItem.Name = "requisiçõesInternasToolStripMenuItem";
            this.requisiçõesInternasToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.requisiçõesInternasToolStripMenuItem.Text = "Requisições Internas";
            this.requisiçõesInternasToolStripMenuItem.Click += new System.EventHandler(this.requisiçõesInternasToolStripMenuItem_Click);
            // 
            // documentosToolStripMenuItem1
            // 
            this.documentosToolStripMenuItem1.Name = "documentosToolStripMenuItem1";
            this.documentosToolStripMenuItem1.Size = new System.Drawing.Size(354, 26);
            this.documentosToolStripMenuItem1.Text = "Outros Documentos";
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.recibosToolStripMenuItem.Text = "Recibos";
            // 
            // reimpressãoToolStripMenuItem
            // 
            this.reimpressãoToolStripMenuItem.Name = "reimpressãoToolStripMenuItem";
            this.reimpressãoToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.reimpressãoToolStripMenuItem.Text = "Reimpressão";
            this.reimpressãoToolStripMenuItem.Click += new System.EventHandler(this.reimpressãoToolStripMenuItem_Click);
            // 
            // processoToolStripMenuItem
            // 
            this.processoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeProcessosToolStripMenuItem});
            this.processoToolStripMenuItem.Name = "processoToolStripMenuItem";
            this.processoToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.processoToolStripMenuItem.Text = "Processos";
            // 
            // consultaDeProcessosToolStripMenuItem
            // 
            this.consultaDeProcessosToolStripMenuItem.Name = "consultaDeProcessosToolStripMenuItem";
            this.consultaDeProcessosToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.consultaDeProcessosToolStripMenuItem.Text = "Extracto de Processos";
            this.consultaDeProcessosToolStripMenuItem.Click += new System.EventHandler(this.ExtractoDeProcessosToolStripMenuItem_Click);
            // 
            // aprovaçõesToolStripMenuItem
            // 
            this.aprovaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprovaçõesToolStripMenuItem1});
            this.aprovaçõesToolStripMenuItem.Name = "aprovaçõesToolStripMenuItem";
            this.aprovaçõesToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.aprovaçõesToolStripMenuItem.Text = "Aprovações";
            // 
            // aprovaçõesToolStripMenuItem1
            // 
            this.aprovaçõesToolStripMenuItem1.Name = "aprovaçõesToolStripMenuItem1";
            this.aprovaçõesToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.aprovaçõesToolStripMenuItem1.Text = "Aprovações";
            this.aprovaçõesToolStripMenuItem1.Click += new System.EventHandler(this.aprovaçõesToolStripMenuItem1_Click);
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.tiposDeServiçoToolStripMenuItem,
            this.gruposToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // tiposDeServiçoToolStripMenuItem
            // 
            this.tiposDeServiçoToolStripMenuItem.Name = "tiposDeServiçoToolStripMenuItem";
            this.tiposDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.tiposDeServiçoToolStripMenuItem.Text = "Tipos de Serviço";
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.gruposToolStripMenuItem.Text = "Grupos";
            // 
            // tlsExplorer
            // 
            this.tlsExplorer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsLabelUtilizador});
            this.tlsExplorer.Location = new System.Drawing.Point(0, 29);
            this.tlsExplorer.Name = "tlsExplorer";
            this.tlsExplorer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tlsExplorer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlsExplorer.Size = new System.Drawing.Size(1155, 25);
            this.tlsExplorer.TabIndex = 1;
            this.tlsExplorer.Text = "toolStrip1";
            // 
            // tlsLabelUtilizador
            // 
            this.tlsLabelUtilizador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsLabelUtilizador.Name = "tlsLabelUtilizador";
            this.tlsLabelUtilizador.Size = new System.Drawing.Size(77, 22);
            this.tlsLabelUtilizador.Text = "Utilizador";
            // 
            // FrmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1155, 588);
            this.Controls.Add(this.tlsExplorer);
            this.Controls.Add(this.mnsExplorer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsExplorer;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transtar Operações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmExplorer_Load);
            this.mnsExplorer.ResumeLayout(false);
            this.mnsExplorer.PerformLayout();
            this.tlsExplorer.ResumeLayout(false);
            this.tlsExplorer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsExplorer;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarCotacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprovaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlsExplorer;
        private System.Windows.Forms.ToolStripLabel tlsLabelUtilizador;
        private System.Windows.Forms.ToolStripMenuItem aprovaçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requisiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requisiçõesInternasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reimpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoDeCOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
    }
}