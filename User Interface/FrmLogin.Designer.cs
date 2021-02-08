namespace TRTv10.User_Interface
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHeaderProcesso = new System.Windows.Forms.TextBox();
            this.lblHeaderProcesso = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLOGPassword = new System.Windows.Forms.TextBox();
            this.txtLOGUtilizador = new System.Windows.Forms.TextBox();
            this.lblLOGSucesso = new System.Windows.Forms.Label();
            this.timerLOGLogin = new System.Windows.Forms.Timer(this.components);
            this.BtnLOGEntrar = new System.Windows.Forms.Button();
            this.lblLOGUser = new System.Windows.Forms.Label();
            this.lblLOGPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 17);
            this.panel1.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(1174, 21);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 33);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtHeaderProcesso);
            this.panel3.Controls.Add(this.lblHeaderProcesso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 17);
            this.panel3.TabIndex = 3;
            // 
            // txtHeaderProcesso
            // 
            this.txtHeaderProcesso.BackColor = System.Drawing.Color.Silver;
            this.txtHeaderProcesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeaderProcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeaderProcesso.Location = new System.Drawing.Point(891, 4);
            this.txtHeaderProcesso.Name = "txtHeaderProcesso";
            this.txtHeaderProcesso.Size = new System.Drawing.Size(100, 18);
            this.txtHeaderProcesso.TabIndex = 3;
            this.txtHeaderProcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeaderProcesso
            // 
            this.lblHeaderProcesso.AutoSize = true;
            this.lblHeaderProcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderProcesso.Location = new System.Drawing.Point(824, 5);
            this.lblHeaderProcesso.Name = "lblHeaderProcesso";
            this.lblHeaderProcesso.Size = new System.Drawing.Size(61, 17);
            this.lblHeaderProcesso.TabIndex = 2;
            this.lblHeaderProcesso.Text = "Processo";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(84, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // txtLOGPassword
            // 
            this.txtLOGPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLOGPassword.Location = new System.Drawing.Point(82, 195);
            this.txtLOGPassword.Name = "txtLOGPassword";
            this.txtLOGPassword.Size = new System.Drawing.Size(393, 25);
            this.txtLOGPassword.TabIndex = 10;
            this.txtLOGPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLOGPassword.UseSystemPasswordChar = true;
            this.txtLOGPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLOGPassword_KeyDown);
            // 
            // txtLOGUtilizador
            // 
            this.txtLOGUtilizador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLOGUtilizador.ForeColor = System.Drawing.Color.Black;
            this.txtLOGUtilizador.Location = new System.Drawing.Point(82, 106);
            this.txtLOGUtilizador.Name = "txtLOGUtilizador";
            this.txtLOGUtilizador.Size = new System.Drawing.Size(393, 25);
            this.txtLOGUtilizador.TabIndex = 9;
            this.txtLOGUtilizador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLOGUtilizador.TextChanged += new System.EventHandler(this.TxtLOGUtilizador_TextChanged);
            // 
            // lblLOGSucesso
            // 
            this.lblLOGSucesso.AutoSize = true;
            this.lblLOGSucesso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGSucesso.Location = new System.Drawing.Point(140, 325);
            this.lblLOGSucesso.Name = "lblLOGSucesso";
            this.lblLOGSucesso.Size = new System.Drawing.Size(0, 25);
            this.lblLOGSucesso.TabIndex = 12;
            // 
            // timerLOGLogin
            // 
            this.timerLOGLogin.Interval = 1;
            this.timerLOGLogin.Tick += new System.EventHandler(this.TimerLOGLogin_Tick);
            // 
            // BtnLOGEntrar
            // 
            this.BtnLOGEntrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLOGEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLOGEntrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLOGEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnLOGEntrar.Location = new System.Drawing.Point(209, 260);
            this.BtnLOGEntrar.Name = "BtnLOGEntrar";
            this.BtnLOGEntrar.Size = new System.Drawing.Size(142, 40);
            this.BtnLOGEntrar.TabIndex = 15;
            this.BtnLOGEntrar.Text = "Entrar";
            this.BtnLOGEntrar.UseVisualStyleBackColor = false;
            this.BtnLOGEntrar.Click += new System.EventHandler(this.BtnLOGEntrar_Click);
            // 
            // lblLOGUser
            // 
            this.lblLOGUser.AutoSize = true;
            this.lblLOGUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGUser.Location = new System.Drawing.Point(243, 66);
            this.lblLOGUser.Name = "lblLOGUser";
            this.lblLOGUser.Size = new System.Drawing.Size(77, 21);
            this.lblLOGUser.TabIndex = 16;
            this.lblLOGUser.Text = "Utilizador";
            // 
            // lblLOGPassword
            // 
            this.lblLOGPassword.AutoSize = true;
            this.lblLOGPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGPassword.Location = new System.Drawing.Point(243, 155);
            this.lblLOGPassword.Name = "lblLOGPassword";
            this.lblLOGPassword.Size = new System.Drawing.Size(76, 21);
            this.lblLOGPassword.TabIndex = 17;
            this.lblLOGPassword.Text = "Password";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(565, 366);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLOGPassword);
            this.Controls.Add(this.lblLOGUser);
            this.Controls.Add(this.BtnLOGEntrar);
            this.Controls.Add(this.lblLOGSucesso);
            this.Controls.Add(this.txtLOGPassword);
            this.Controls.Add(this.txtLOGUtilizador);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transtar - Menu de Acesso";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button BtnLOGEntrar;
        private System.Windows.Forms.Label lblHeaderProcesso;
        private System.Windows.Forms.Label lblLOGPassword;
        private System.Windows.Forms.Label lblLOGSucesso;
        private System.Windows.Forms.Label lblLOGUser;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timerLOGLogin;
        private System.Windows.Forms.TextBox txtHeaderProcesso;
        private System.Windows.Forms.TextBox txtLOGPassword;
        private System.Windows.Forms.TextBox txtLOGUtilizador;

        #endregion
    }
}