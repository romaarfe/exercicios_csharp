namespace projetoCreditoDebito
{
    partial class Form1
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
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.dgvDevedores = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxCreditoDebito = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAddMovimentos = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTotalDeb = new System.Windows.Forms.TextBox();
            this.txtTotalCred = new System.Windows.Forms.TextBox();
            this.lblTotalDebito = new System.Windows.Forms.Label();
            this.lblTotaCredito = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTAGENSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteMêsCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancetesváriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMPRESSºOESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClientePeloNúmeroDoMêsEAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancetePorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancetePorIntervaloDeDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevedores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(141, 63);
            this.lstClientes.Margin = new System.Windows.Forms.Padding(2);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(188, 121);
            this.lstClientes.TabIndex = 0;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // dgvDevedores
            // 
            this.dgvDevedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevedores.Location = new System.Drawing.Point(100, 223);
            this.dgvDevedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDevedores.Name = "dgvDevedores";
            this.dgvDevedores.RowHeadersWidth = 51;
            this.dgvDevedores.RowTemplate.Height = 24;
            this.dgvDevedores.Size = new System.Drawing.Size(664, 256);
            this.dgvDevedores.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(32, 78);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(39, 63);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(82, 13);
            this.lblPesquisa.TabIndex = 3;
            this.lblPesquisa.Text = "Pesquisar nome";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(539, 120);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(209, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(648, 164);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // cbxCreditoDebito
            // 
            this.cbxCreditoDebito.FormattingEnabled = true;
            this.cbxCreditoDebito.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cbxCreditoDebito.Location = new System.Drawing.Point(539, 163);
            this.cbxCreditoDebito.Name = "cbxCreditoDebito";
            this.cbxCreditoDebito.Size = new System.Drawing.Size(100, 21);
            this.cbxCreditoDebito.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(604, 104);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblAddMovimentos
            // 
            this.lblAddMovimentos.AutoSize = true;
            this.lblAddMovimentos.Location = new System.Drawing.Point(617, 39);
            this.lblAddMovimentos.Name = "lblAddMovimentos";
            this.lblAddMovimentos.Size = new System.Drawing.Size(156, 13);
            this.lblAddMovimentos.TabIndex = 10;
            this.lblAddMovimentos.Text = "ADICIONAR MOVIMENTAÇÃO";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(754, 120);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 64);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(539, 69);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(297, 20);
            this.dtpData.TabIndex = 12;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(679, 148);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(574, 147);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo";
            // 
            // txtTotalDeb
            // 
            this.txtTotalDeb.Location = new System.Drawing.Point(480, 508);
            this.txtTotalDeb.Name = "txtTotalDeb";
            this.txtTotalDeb.Size = new System.Drawing.Size(75, 20);
            this.txtTotalDeb.TabIndex = 16;
            // 
            // txtTotalCred
            // 
            this.txtTotalCred.Location = new System.Drawing.Point(561, 508);
            this.txtTotalCred.Name = "txtTotalCred";
            this.txtTotalCred.Size = new System.Drawing.Size(78, 20);
            this.txtTotalCred.TabIndex = 17;
            // 
            // lblTotalDebito
            // 
            this.lblTotalDebito.AutoSize = true;
            this.lblTotalDebito.Location = new System.Drawing.Point(480, 485);
            this.lblTotalDebito.Name = "lblTotalDebito";
            this.lblTotalDebito.Size = new System.Drawing.Size(65, 13);
            this.lblTotalDebito.TabIndex = 18;
            this.lblTotalDebito.Text = "Total Débito";
            // 
            // lblTotaCredito
            // 
            this.lblTotaCredito.AutoSize = true;
            this.lblTotaCredito.Location = new System.Drawing.Point(558, 485);
            this.lblTotaCredito.Name = "lblTotaCredito";
            this.lblTotaCredito.Size = new System.Drawing.Size(67, 13);
            this.lblTotaCredito.TabIndex = 19;
            this.lblTotaCredito.Text = "Total Crédito";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "CLIENTES";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // mOVIMENTOSToolStripMenuItem
            // 
            this.mOVIMENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.alterarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.eliminarEntreDatasToolStripMenuItem});
            this.mOVIMENTOSToolStripMenuItem.Name = "mOVIMENTOSToolStripMenuItem";
            this.mOVIMENTOSToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mOVIMENTOSToolStripMenuItem.Text = "MOVIMENTOS";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // alterarToolStripMenuItem1
            // 
            this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.alterarToolStripMenuItem1.Text = "Alterar";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // eliminarEntreDatasToolStripMenuItem
            // 
            this.eliminarEntreDatasToolStripMenuItem.Name = "eliminarEntreDatasToolStripMenuItem";
            this.eliminarEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarEntreDatasToolStripMenuItem.Text = "Eliminar entre datas";
            // 
            // lISTAGENSToolStripMenuItem
            // 
            this.lISTAGENSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClienteToolStripMenuItem,
            this.porClienteEntreDatasToolStripMenuItem,
            this.porClienteMêsCorrenteToolStripMenuItem,
            this.balancetesváriosToolStripMenuItem});
            this.lISTAGENSToolStripMenuItem.Name = "lISTAGENSToolStripMenuItem";
            this.lISTAGENSToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.lISTAGENSToolStripMenuItem.Text = "LISTAGENS";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.porClienteToolStripMenuItem.Text = "Por cliente";
            // 
            // porClienteEntreDatasToolStripMenuItem
            // 
            this.porClienteEntreDatasToolStripMenuItem.Name = "porClienteEntreDatasToolStripMenuItem";
            this.porClienteEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.porClienteEntreDatasToolStripMenuItem.Text = "Por cliente, entre datas";
            // 
            // porClienteMêsCorrenteToolStripMenuItem
            // 
            this.porClienteMêsCorrenteToolStripMenuItem.Name = "porClienteMêsCorrenteToolStripMenuItem";
            this.porClienteMêsCorrenteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.porClienteMêsCorrenteToolStripMenuItem.Text = "Por cliente, mês corrente";
            // 
            // balancetesváriosToolStripMenuItem
            // 
            this.balancetesváriosToolStripMenuItem.Name = "balancetesváriosToolStripMenuItem";
            this.balancetesváriosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.balancetesváriosToolStripMenuItem.Text = "Balancetes (vários)";
            // 
            // iMPRESSºOESToolStripMenuItem
            // 
            this.iMPRESSºOESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClientePeloNúmeroDoMêsEAnoToolStripMenuItem,
            this.balancetePorMêsToolStripMenuItem,
            this.balancetePorIntervaloDeDatasToolStripMenuItem});
            this.iMPRESSºOESToolStripMenuItem.Name = "iMPRESSºOESToolStripMenuItem";
            this.iMPRESSºOESToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.iMPRESSºOESToolStripMenuItem.Text = "IMPRESSÕES";
            // 
            // porClientePeloNúmeroDoMêsEAnoToolStripMenuItem
            // 
            this.porClientePeloNúmeroDoMêsEAnoToolStripMenuItem.Name = "porClientePeloNúmeroDoMêsEAnoToolStripMenuItem";
            this.porClientePeloNúmeroDoMêsEAnoToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.porClientePeloNúmeroDoMêsEAnoToolStripMenuItem.Text = "Por cliente, pelo número do mês e ano";
            // 
            // balancetePorMêsToolStripMenuItem
            // 
            this.balancetePorMêsToolStripMenuItem.Name = "balancetePorMêsToolStripMenuItem";
            this.balancetePorMêsToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.balancetePorMêsToolStripMenuItem.Text = "Balancete por mês";
            // 
            // balancetePorIntervaloDeDatasToolStripMenuItem
            // 
            this.balancetePorIntervaloDeDatasToolStripMenuItem.Name = "balancetePorIntervaloDeDatasToolStripMenuItem";
            this.balancetePorIntervaloDeDatasToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.balancetePorIntervaloDeDatasToolStripMenuItem.Text = "Balancete por intervalo de datas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mOVIMENTOSToolStripMenuItem,
            this.lISTAGENSToolStripMenuItem,
            this.iMPRESSºOESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 625);
            this.Controls.Add(this.lblTotaCredito);
            this.Controls.Add(this.lblTotalDebito);
            this.Controls.Add(this.txtTotalCred);
            this.Controls.Add(this.txtTotalDeb);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAddMovimentos);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cbxCreditoDebito);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvDevedores);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MOVIMENTOS DO SR. JOAQUIM LTDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevedores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.DataGridView dgvDevedores;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbxCreditoDebito;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAddMovimentos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTotalDeb;
        private System.Windows.Forms.TextBox txtTotalCred;
        private System.Windows.Forms.Label lblTotalDebito;
        private System.Windows.Forms.Label lblTotaCredito;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarEntreDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTAGENSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteEntreDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteMêsCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balancetesváriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMPRESSºOESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClientePeloNúmeroDoMêsEAnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balancetePorMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balancetePorIntervaloDeDatasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

