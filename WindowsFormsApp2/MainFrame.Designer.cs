namespace WindowsFormsApp2
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGerador = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnMembro = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 75);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "AIRCOOLED";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1249, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 46);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1251, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(47, 46);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1304, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.btnGerador);
            this.panel2.Controls.Add(this.btnFinanceiro);
            this.panel2.Controls.Add(this.btnMembro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 686);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(-1, 340);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(270, 63);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnGerador
            // 
            this.btnGerador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerador.FlatAppearance.BorderSize = 0;
            this.btnGerador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGerador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerador.ForeColor = System.Drawing.Color.White;
            this.btnGerador.Image = ((System.Drawing.Image)(resources.GetObject("btnGerador.Image")));
            this.btnGerador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerador.Location = new System.Drawing.Point(-1, 271);
            this.btnGerador.Name = "btnGerador";
            this.btnGerador.Size = new System.Drawing.Size(270, 63);
            this.btnGerador.TabIndex = 1;
            this.btnGerador.Text = "       Gerador de Parcelas";
            this.btnGerador.UseVisualStyleBackColor = true;
            this.btnGerador.Click += new System.EventHandler(this.btnGerador_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceiro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 132);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(267, 63);
            this.btnFinanceiro.TabIndex = 2;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnMembro
            // 
            this.btnMembro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMembro.FlatAppearance.BorderSize = 0;
            this.btnMembro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMembro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMembro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembro.ForeColor = System.Drawing.Color.White;
            this.btnMembro.Image = ((System.Drawing.Image)(resources.GetObject("btnMembro.Image")));
            this.btnMembro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembro.Location = new System.Drawing.Point(0, 63);
            this.btnMembro.Name = "btnMembro";
            this.btnMembro.Size = new System.Drawing.Size(267, 63);
            this.btnMembro.TabIndex = 3;
            this.btnMembro.Text = "Membro";
            this.btnMembro.UseVisualStyleBackColor = true;
            this.btnMembro.Click += new System.EventHandler(this.btnMembro_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlConteudo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConteudo.BackgroundImage")));
            this.pnlConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(273, 75);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(1094, 686);
            this.pnlConteudo.TabIndex = 5;
            this.pnlConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConteudo_Paint);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(1194, 12);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(49, 46);
            this.btnMinimized.TabIndex = 4;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 761);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainFrame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "VW AIRCOOLED";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMembro;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnGerador;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinimized;
    }
}