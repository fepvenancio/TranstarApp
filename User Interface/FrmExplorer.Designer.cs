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
            this.mnsExplorer = new System.Windows.Forms.MenuStrip();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProcessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprovaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsExplorer = new System.Windows.Forms.ToolStrip();
            this.tlsLabelUtilizador = new System.Windows.Forms.ToolStripLabel();
            this.aprovaçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsExplorer.SuspendLayout();
            this.tlsExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsExplorer
            // 
            this.mnsExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.processoToolStripMenuItem,
            this.aprovaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.tabelasToolStripMenuItem});
            this.mnsExplorer.Location = new System.Drawing.Point(0, 0);
            this.mnsExplorer.Name = "mnsExplorer";
            this.mnsExplorer.Size = new System.Drawing.Size(1155, 24);
            this.mnsExplorer.TabIndex = 0;
            this.mnsExplorer.Text = "mnsExplorer";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarServiçoToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // criarServiçoToolStripMenuItem
            // 
            this.criarServiçoToolStripMenuItem.Name = "criarServiçoToolStripMenuItem";
            this.criarServiçoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.criarServiçoToolStripMenuItem.Text = "Criar Serviço";
            this.criarServiçoToolStripMenuItem.Click += new System.EventHandler(this.CriarServiçoToolStripMenuItem_Click);
            // 
            // processoToolStripMenuItem
            // 
            this.processoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeProcessosToolStripMenuItem});
            this.processoToolStripMenuItem.Name = "processoToolStripMenuItem";
            this.processoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.processoToolStripMenuItem.Text = "Processos";
            // 
            // consultaDeProcessosToolStripMenuItem
            // 
            this.consultaDeProcessosToolStripMenuItem.Name = "consultaDeProcessosToolStripMenuItem";
            this.consultaDeProcessosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.consultaDeProcessosToolStripMenuItem.Text = "Consulta de Processos";
            this.consultaDeProcessosToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeProcessosToolStripMenuItem_Click);
            // 
            // aprovaçõesToolStripMenuItem
            // 
            this.aprovaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprovaçõesToolStripMenuItem1});
            this.aprovaçõesToolStripMenuItem.Name = "aprovaçõesToolStripMenuItem";
            this.aprovaçõesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.aprovaçõesToolStripMenuItem.Text = "Aprovações";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.tiposDeServiçoToolStripMenuItem,
            this.gruposToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // tiposDeServiçoToolStripMenuItem
            // 
            this.tiposDeServiçoToolStripMenuItem.Name = "tiposDeServiçoToolStripMenuItem";
            this.tiposDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tiposDeServiçoToolStripMenuItem.Text = "Tipos de Serviço";
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            // 
            // tlsExplorer
            // 
            this.tlsExplorer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsLabelUtilizador});
            this.tlsExplorer.Location = new System.Drawing.Point(0, 24);
            this.tlsExplorer.Name = "tlsExplorer";
            this.tlsExplorer.Size = new System.Drawing.Size(1155, 25);
            this.tlsExplorer.TabIndex = 1;
            this.tlsExplorer.Text = "toolStrip1";
            // 
            // tlsLabelUtilizador
            // 
            this.tlsLabelUtilizador.Name = "tlsLabelUtilizador";
            this.tlsLabelUtilizador.Size = new System.Drawing.Size(57, 22);
            this.tlsLabelUtilizador.Text = "Utilizador";
            // 
            // aprovaçõesToolStripMenuItem1
            // 
            this.aprovaçõesToolStripMenuItem1.Name = "aprovaçõesToolStripMenuItem1";
            this.aprovaçõesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aprovaçõesToolStripMenuItem1.Text = "Aprovações";
            this.aprovaçõesToolStripMenuItem1.Click += new System.EventHandler(this.aprovaçõesToolStripMenuItem1_Click);
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
            this.MainMenuStrip = this.mnsExplorer;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExplorer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transtar Explorer";
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
        private System.Windows.Forms.ToolStripMenuItem criarServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprovaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlsExplorer;
        private System.Windows.Forms.ToolStripLabel tlsLabelUtilizador;
        private System.Windows.Forms.ToolStripMenuItem aprovaçõesToolStripMenuItem1;
    }
}