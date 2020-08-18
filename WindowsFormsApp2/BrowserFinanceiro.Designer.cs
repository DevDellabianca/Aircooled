namespace WindowsFormsApp2
{
    partial class BrowserFinanceiro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.CmbPag = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReabrir = new System.Windows.Forms.Button();
            this.BtnBaixar = new System.Windows.Forms.Button();
            this.BtnVisu = new System.Windows.Forms.Button();
            this.BtnAlter = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nome,
            this.Tipo,
            this.Valor,
            this.Vencimento,
            this.Pagamento});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(10, 138);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 572);
            this.dataGridView1.TabIndex = 130;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.BtnAlter_Click);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "Vencimento";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.MinimumWidth = 6;
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Pagamento
            // 
            this.Pagamento.DataPropertyName = "Pagamento";
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.MinimumWidth = 6;
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.ReadOnly = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFiltrar.Location = new System.Drawing.Point(879, 792);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 32);
            this.btnFiltrar.TabIndex = 131;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // CmbPag
            // 
            this.CmbPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbPag.BackColor = System.Drawing.Color.White;
            this.CmbPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPag.FormattingEnabled = true;
            this.CmbPag.Items.AddRange(new object[] {
            "A Pagar",
            "Pago",
            "Todos"});
            this.CmbPag.Location = new System.Drawing.Point(12, 743);
            this.CmbPag.Name = "CmbPag";
            this.CmbPag.Size = new System.Drawing.Size(106, 28);
            this.CmbPag.TabIndex = 137;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(176, 794);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(657, 26);
            this.txtDescricao.TabIndex = 139;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbFiltro.BackColor = System.Drawing.Color.White;
            this.CmbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Nome"});
            this.CmbFiltro.Location = new System.Drawing.Point(12, 794);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(106, 28);
            this.CmbFiltro.TabIndex = 138;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnFechar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFechar.Location = new System.Drawing.Point(973, 792);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(88, 32);
            this.BtnFechar.TabIndex = 141;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Todos",
            "Pagar",
            "Receber"});
            this.cmbTipo.Location = new System.Drawing.Point(176, 743);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(106, 28);
            this.cmbTipo.TabIndex = 142;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 723);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 143;
            this.label1.Text = "Situação";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(173, 723);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 774);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 145;
            this.label3.Text = "Tipo de Filtro";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(173, 774);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 146;
            this.label4.Text = "Nome do Favorecido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 63);
            this.label5.TabIndex = 147;
            this.label5.Text = "Financeiro";
            // 
            // btnReabrir
            // 
            this.btnReabrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnReabrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReabrir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReabrir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnReabrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReabrir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReabrir.Location = new System.Drawing.Point(829, 86);
            this.btnReabrir.Name = "btnReabrir";
            this.btnReabrir.Size = new System.Drawing.Size(150, 46);
            this.btnReabrir.TabIndex = 140;
            this.btnReabrir.Text = "Reabrir Parcela";
            this.btnReabrir.UseVisualStyleBackColor = false;
            this.btnReabrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBaixar
            // 
            this.BtnBaixar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BtnBaixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBaixar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBaixar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnBaixar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnBaixar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaixar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBaixar.Location = new System.Drawing.Point(673, 86);
            this.BtnBaixar.Name = "BtnBaixar";
            this.BtnBaixar.Size = new System.Drawing.Size(150, 46);
            this.BtnBaixar.TabIndex = 136;
            this.BtnBaixar.Text = "Baixar Parcela";
            this.BtnBaixar.UseVisualStyleBackColor = false;
            this.BtnBaixar.Click += new System.EventHandler(this.BtnBaixar_Click);
            // 
            // BtnVisu
            // 
            this.BtnVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BtnVisu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVisu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVisu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnVisu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnVisu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnVisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisu.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVisu.Location = new System.Drawing.Point(166, 86);
            this.BtnVisu.Name = "BtnVisu";
            this.BtnVisu.Size = new System.Drawing.Size(150, 46);
            this.BtnVisu.TabIndex = 133;
            this.BtnVisu.Text = "Visualizar";
            this.BtnVisu.UseVisualStyleBackColor = false;
            this.BtnVisu.Click += new System.EventHandler(this.BtnVisu_Click);
            // 
            // BtnAlter
            // 
            this.BtnAlter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BtnAlter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAlter.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnAlter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAlter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlter.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAlter.Location = new System.Drawing.Point(322, 86);
            this.BtnAlter.Name = "BtnAlter";
            this.BtnAlter.Size = new System.Drawing.Size(150, 46);
            this.BtnAlter.TabIndex = 134;
            this.BtnAlter.Text = "Alterar";
            this.BtnAlter.UseVisualStyleBackColor = false;
            this.BtnAlter.Click += new System.EventHandler(this.BtnAlter_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDel.Location = new System.Drawing.Point(478, 86);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(150, 46);
            this.BtnDel.TabIndex = 135;
            this.BtnDel.Text = "Excluir";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnNovo.Location = new System.Drawing.Point(10, 86);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(150, 46);
            this.BtnNovo.TabIndex = 132;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(632, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 54);
            this.label6.TabIndex = 148;
            this.label6.Text = "|";
            // 
            // BrowserFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 827);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnBaixar);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.btnReabrir);
            this.Controls.Add(this.BtnAlter);
            this.Controls.Add(this.BtnVisu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.CmbPag);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowserFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox CmbPag;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Button BtnFechar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReabrir;
        private System.Windows.Forms.Button BtnBaixar;
        private System.Windows.Forms.Button BtnVisu;
        private System.Windows.Forms.Button BtnAlter;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}